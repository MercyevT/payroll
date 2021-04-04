//Author Anan Osothsilp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

using projectpayroll.Data;
using projectpayroll.Models;
using System.Text;

using System.IO;

using System.Globalization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace projectpayroll.Controllers
{
    public class ClockingController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public ClockingController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: Clocking
        public async Task<IActionResult> Index()
        {
            var result = await _context.clockings
                              .Select(x=> new{
                                  employeeId    = x.employeeId,
                                  employeeName  = x.employee.FirstName+" "+x.employee.LastName,
                                  department    = x.employee.department.departmentName,
                                  departmentId  = x.employee.department.departmentId,
                                  breakIn       = x.breakIn,
                                  breakOut      = x.breakOut,
                                  clockingId    = x.clockingId,
                                  clockingIn    = x.clockingIn,
                                  clockingOut   = x.clockingOut,
                                  date          = x.Date
                              })
                               .ToListAsync();
            ViewBag.clockings = result;       
            var result2 = await _context.workingTimes
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.workingTimes = result2;      
            var result3 = await _context.departments
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.departments = result3;                                        
            return View();
        }//end function
 
        // GET: Clocking/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table
            ViewBag.employees = _context.employees.Select(x=> new {x.employeeId,x.FirstName});
            //ViewBag.select_employee = ViewBag.employees[0];

            return View();
        }//end function

        // POST: Clocking/Add
        [HttpPost]
        public async Task<IActionResult> Add(clocking clocking)
        {
               try{
                _context.Add(clocking);
                await _context.SaveChangesAsync();
                return Json( new {
                              error=-1,
                              message = "yes"
                });
               }//end try
               catch(Exception ex){
                    return Json( new {
                              error=1,
                              message = "yes",
                              exception = ex.Message
                    });
               }  //end Exception
             
        }//end function

        // GET: Clocking/Edit/1
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return Json( new {
                              error=1,
                              message = "no",
                              exception= " please define id"
                    });
            }

            var clocking = await _context.clockings.FindAsync(id);
            if (clocking == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var employees = _context.employees.Select(x=> new {x.employeeId,x.FirstName});
            ViewBag.employees = employees;
            ViewBag.select_employee = await employees.FirstOrDefaultAsync(x=>x.employeeId == clocking.employeeId);
            
           

             ViewBag.clocking = clocking;
            return View();
        }//end function

        // POST: Clocking/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(clocking clocking)
        {
             try{
                _context.clockings.Update(clocking);
                await _context.SaveChangesAsync();
                return Json( new {
                              error=-1,
                              message = "yes"
                });
               }//end try
               catch(Exception ex){
                    return Json( new {
                              error=1,
                              message = "yes",
                              exception = ex.Message
                    });
               }  //end Exception
        }//end function

        // GET: Clocking/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clocking = await _context.clockings
                .FirstOrDefaultAsync(m => m.clockingId == id);
            if (clocking == null)
            {
                return NotFound();
            }

            return View(clocking);
        }//end function

        // POST: Clocking/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clocking = await _context.clockings.FindAsync(id);
            _context.clockings.Remove(clocking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool ClockingExists(int id)
        {
            return _context.clockings.Any(e => e.clockingId == id);
        }//end function

        public IActionResult importView(){
            return View("import");
        }
        public async Task<IActionResult> importFile2(IFormFile file1){
            var obj = new{
                file1.FileName,
                file1.Length
            };
            return Json(obj);

        }
   
        public async Task<IActionResult> importFile(IFormFile file1){
            List<clocking> list1 = new List<clocking>();
            
            //empty table product type
            var lookup = await _context.employees.ToDictionaryAsync(x=>x.employeeId);
            
             
            
            //get file name & size
              using (var stream = new MemoryStream())
            {
                //4: copy file to stream
                await file1.CopyToAsync(stream);
                //5: allocate memory for excel package, auto handle memory life cycle
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet wk = package.Workbook.Worksheets[0];
                    //7: find rows count
                    int rowCount = wk.Dimension.Rows;

                    for (int i = 2; i <=rowCount; i++)
                    {
                        int empId = int.Parse(wk.Cells[i, 2].Value.ToString().Trim());
                        string ClockingIn = wk.Cells[i, 3].Value.ToString().Trim();
                        string BreakIn = wk.Cells[i, 4].Value.ToString().Trim();
                        string BreakOut = wk.Cells[i, 5].Value.ToString().Trim();
                        string ClockingOut = wk.Cells[i, 6].Value.ToString().Trim();
                        string Date = wk.Cells[i, 7].Value.ToString().Trim();
                        clocking p = new clocking(){
                            
                            employeeId   =lookup[empId].employeeId,
                            clockingIn  = ClockingIn,
                            breakIn     = BreakIn,
                            breakOut    = BreakOut,
                            clockingOut = ClockingOut,
                            Date        = Date
                        };

                        list1.Add(p);
                        
                        
                    }//end for
                    
                    await _context.clockings.AddRangeAsync(list1);
                    await _context.SaveChangesAsync();
                    
                    return Json(new {
                        error=-1,
                        msg = "done",

                    });

                }//end inner using
            }//end using
        }//ef

        
            [HttpPost]
            ///Import csv Code 
            public async Task<IActionResult> importFile4(IFormFile file1){
             List<clock> clockings = new List<clock>();
              List<clocking> clockings2 = new List<clocking>();
              
            
            //get file name & size
              var filePath = Path.GetTempFileName();
                using (var stream = System.IO.File.Create(filePath))
                {
                // The formFile is the method parameter which type is IFormFile
                // Saves the files to the local file system using a file name generated by the app.
                await file1.CopyToAsync(stream);
                }
                string[] csvLines = System.IO.File.ReadAllLines(@filePath);
                 for (int i=1;i<csvLines.Length;i++){
                    clock st = new clock(csvLines[i]);
                    clockings.Add(st);
                    
                }
                for (int i = 0;i<clockings.Count;i++){
                    Console.WriteLine(clockings[i]);
                }
                for (int i = 0;i<clockings.Count;i++){
                    clocking p = new clocking(){
                        employeeId  =clockings[i].EmployeeID,
                        clockingIn  =clockings[i].ClockingIn,
                        breakIn     =clockings[i].BreakIn,
                        breakOut    =clockings[i].BreakOut,
                        clockingOut =clockings[i].ClockingOut,
                        Date        =clockings[i].Date
                        };
                        clockings2.Add(p);
                }
                await _context.clockings.AddRangeAsync(clockings2);
                await _context.SaveChangesAsync();
                 
                return Json(new {
                        error=-1,
                        msg = "done",

                    });

        
            }
        
       public class clock
    {
        public int EmployeeID;
        public string ClockingIn, BreakIn, BreakOut,ClockingOut,Date;
        public clock(string rowData) 
        {
            List<string> data = rowData.Split(',').ToList();
            List<clocking> list1 = new List<clocking>();
            // Parse data into properties
            
            this.EmployeeID = int.Parse(data[1]);
            this.ClockingIn = data[2];
            this.BreakIn = data[3];
            this.BreakOut = data[4];
            this.ClockingOut = data[5];
            this.Date = data[6];

        }

        public override string ToString()
        {
            string str = $"{EmployeeID}," +$"{ClockingIn},"+$"{BreakIn},"+$"{BreakOut},"+$"{ClockingOut},"+$"{Date},";
            
            return str;
        }

    }
        
        

    }//end class
}//end namespace
