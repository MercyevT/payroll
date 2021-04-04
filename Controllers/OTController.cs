//Author Anan Osothsilp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projectpayroll.Data;
using projectpayroll.Models;

namespace projectpayroll.Controllers
{
    public class OTController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public OTController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: OT
        public async Task<IActionResult> Index()
        {
            var result = await _context.OTs
                              .Select(x=> new{
                                  employeeId    = x.employeeId,
                                  employeeName  = x.employee.FirstName+" "+x.employee.LastName,
                                  oStatus       = x.oStatus,
                                  oTDate        = x.oTDate,
                                  oTFinish      = x.oTFinish,
                                  oTId          = x.oTId,
                                  oTStart       = x.oTStart,
                                  totalHour     = x.TotalHour
                              })
                               .ToListAsync();
            ViewBag.oTs = result;
            var result2 = await _context.clockings
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.clockings = result2;                                               
            return View();
        }//end function
        // GET: OT/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table
            ViewBag.employees = _context.employees.Select(x=> new {x.employeeId,x.FirstName});
            //ViewBag.select_employee = ViewBag.employees[0];

            return View();
        }//end function

        // POST: OT/Add
        [HttpPost]
        public async Task<IActionResult> Add(OT oT)
        {
               try{
                _context.Add(oT);
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

        // GET: OT/Edit/1
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

            var oT = await _context.OTs.FindAsync(id);
            if (oT == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var employees = _context.employees.Select(x=> new {x.employeeId,x.FirstName});
            ViewBag.employees = employees;
            ViewBag.select_employee = await employees.FirstOrDefaultAsync(x=>x.employeeId == oT.employeeId);
            
           

             ViewBag.oT = oT;
            return View();
        }//end function
        public async Task<IActionResult> Check(int? id)
        {
            if (id == null)
            {
                return Json( new {
                              error=1,
                              message = "no",
                              exception= " please define id"
                    });
            }

            var oT = await _context.OTs.FindAsync(id);
            if (oT == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var employees = _context.employees.Select(x=> new {x.employeeId,x.FirstName});
            ViewBag.employees = employees;
            ViewBag.select_employee = await employees.FirstOrDefaultAsync(x=>x.employeeId == oT.employeeId);
             ViewBag.oT = oT;
             
             var result = await _context.clockings
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.clockings = result;  
            return View();
        }//end function
        // POST: OT/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(OT oT)
        {
             try{
                _context.OTs.Update(oT);
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
        [HttpPost]
        public async Task<IActionResult> update(OT oT)
        {
             try{
                _context.OTs.Update(oT);
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

        // GET: OT/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oT = await _context.OTs
                .FirstOrDefaultAsync(m => m.oTId == id);
            if (oT == null)
            {
                return NotFound();
            }

            return View(oT);
        }//end function
        public IActionResult importView(){
            return View("import");
        }
        [HttpPost]
            ///Import csv Code 
            public async Task<IActionResult> importFile4(IFormFile file1){
             List<o> ot = new List<o>();
              List<OT> ots = new List<OT>();
              
            
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
                    o st = new o(csvLines[i]);
                    ot.Add(st);
                    
                }
                for (int i = 0;i<ot.Count;i++){
                    Console.WriteLine(ot[i]);
                }
                for (int i = 0;i<ot.Count;i++){
                    OT p = new OT(){
                        employeeId  =ot[i].employeeID,
                        oTStart  =ot[i].oTStart,
                        oTFinish     =ot[i].oTFinish,
                        oTDate    =ot[i].oTDate,
                        TotalHour = ot[i].TotalHour,
                        oStatus =ot[i].oStatus
                        
                        };
                        ots.Add(p);
                }
                await _context.OTs.AddRangeAsync(ots);
                await _context.SaveChangesAsync();
                 
                return Json(new {
                        error=-1,
                        msg = "done",

                    });

        
            }
        
       public class o
    {
        public int employeeID,TotalHour;
        public string oTStart, oTFinish, oTDate,oStatus;
        public o(string rowData) 
        {
            List<string> data = rowData.Split(',').ToList();
            List<OT> list1 = new List<OT>();
            // Parse data into properties
            
            this.employeeID = int.Parse(data[0]);
            this.oTStart = data[1];
            this.oTFinish = data[2];
            this.oTDate = data[3];
            this.TotalHour = int.Parse(data[4]);
            this.oStatus = "incomplete";

        }

        public override string ToString()
        {
            string str = $"{employeeID}," +$"{oTStart},"+$"{oTDate},"+$"{TotalHour},"+$"{oStatus},";
            
            return str;
        }

    }

        // POST: OT/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oT = await _context.OTs.FindAsync(id);
            _context.OTs.Remove(oT);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool OTExists(int id)
        {
            return _context.OTs.Any(e => e.oTId == id);
        }//end function
    }//end class
}//end namespace
