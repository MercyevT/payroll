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
using OfficeOpenXml;
using projectpayroll.Data;
using projectpayroll.Models;

namespace projectpayroll.Controllers
{
    public class CurrentSalaryController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public CurrentSalaryController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: CurrentSalary
        public async Task<IActionResult> Index()
        {
            var result = await _context.CurrentSalarys
                              .Select(x=> new{
                                  currentSalaryAmount   =   x.currentSalaryAmount,
                                  currentSalaryId       =   x.currentSalaryId,
                                  employeeId            =   x.employeeId,
                                  employeeName          =   x.employee.FirstName+" "+x.employee.LastName,
                                  employeeSalaryMasterId=   x.employeeSalaryMasterId,
                                  year                  =   x.year       
                              })
                               .ToListAsync();
            ViewBag.currentSalarys = result;      
            var result2 = await _context.employees
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.employees = result2;    
            var result3 = await _context.EmployeeSalaryMasters
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.EmployeeSalaryMasters = result3;                                              
            return View();
        }//end function
 
        // GET: CurrentSalary/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table
            ViewBag.employees = _context.employees.Select(x=> new {x.employeeId,x.departmentId});
            //ViewBag.select_employee = ViewBag.employees[0];
            ViewBag.employeeSalaryMasters = _context.EmployeeSalaryMasters.Select(x=> new {x.employeeSalaryMasterId,x.basicSalary,x.salaryRate});
            //ViewBag.select_employeeSalaryMaster = ViewBag.employeeSalaryMasters[0];

            return View();
        }//end function

        // POST: CurrentSalary/Add
        [HttpPost]
        public async Task<IActionResult> Add(CurrentSalary currentSalary)
        {
               try{
                _context.Add(currentSalary);
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

        // GET: CurrentSalary/Edit/1
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

            var currentSalary = await _context.CurrentSalarys.FindAsync(id);
            if (currentSalary == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var employees = _context.employees.Select(x=> new {x.employeeId,x.departmentId});
            ViewBag.employees = employees;
            ViewBag.select_employee = await employees.FirstOrDefaultAsync(x=>x.employeeId == currentSalary.employeeId);
            
           
            var employeeSalaryMasters = _context.EmployeeSalaryMasters.Select(x=> new {x.employeeSalaryMasterId,x.basicSalary,x.salaryRate});
            ViewBag.employeeSalaryMasters = employeeSalaryMasters;
            ViewBag.select_employeeSalaryMaster = await employeeSalaryMasters.FirstOrDefaultAsync(x=>x.employeeSalaryMasterId == currentSalary.employeeSalaryMasterId);
            
           

             ViewBag.currentSalary = currentSalary;
            return View();
        }//end function

        // POST: CurrentSalary/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(CurrentSalary currentSalary)
        {
             try{
                _context.CurrentSalarys.Update(currentSalary);
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
        public IActionResult importView(){
            return View("import");
        }
        public async Task<IActionResult> importFile(IFormFile file1){
            List<CurrentSalary> list1 = new List<CurrentSalary>();
            
            //empty table product type
            var lookupE = await _context.employees.ToDictionaryAsync(x=>x.employeeId);
            var lookupSM = await _context.slipMasters.ToDictionaryAsync(x=>x.slipMasterId);
            
             
            
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

                    for (int i = 2; i <= rowCount; i++)
                    {
                        int emp_currentsalaryId   = int.Parse(wk.Cells[i, 1].Value.ToString().Trim());
                        int emp_empId = int.Parse(wk.Cells[i, 4].Value.ToString().Trim());
                        int emp_empSalaryMasterId = int.Parse(wk.Cells[i, 2].Value.ToString().Trim());
                        int emp_currentSalaryAmount = int.Parse(wk.Cells[i, 3].Value.ToString().Trim());              
                        int emp_year = int.Parse(wk.Cells[i, 4].Value.ToString().Trim());
                        
                        CurrentSalary p = new CurrentSalary(){
                            currentSalaryId=emp_currentsalaryId,
                            employeeId=lookupE[emp_empId].employeeId,
                            employeeSalaryMasterId=lookupSM[emp_empSalaryMasterId].slipMasterId,
                            currentSalaryAmount=emp_currentSalaryAmount,
                
                            year=emp_year,

                        };

                        list1.Add(p);
                        
                        
                    }//end for
                    
                    await _context.CurrentSalarys.AddRangeAsync(list1);
                    await _context.SaveChangesAsync();
                    
                    return Json(new {
                        error=-1,
                        msg = "done",

                    });

                }//end inner using
            }//end using


        }//ef

        // GET: CurrentSalary/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currentSalary = await _context.CurrentSalarys
                .FirstOrDefaultAsync(m => m.currentSalaryId == id);
            if (currentSalary == null)
            {
                return NotFound();
            }

            return View(currentSalary);
        }//end function

        // POST: CurrentSalary/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var currentSalary = await _context.CurrentSalarys.FindAsync(id);
            _context.CurrentSalarys.Remove(currentSalary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool CurrentSalaryExists(int id)
        {
            return _context.CurrentSalarys.Any(e => e.currentSalaryId == id);
        }//end function
    }//end class
}//end namespace
