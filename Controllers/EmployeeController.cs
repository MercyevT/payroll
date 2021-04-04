//Author Anan Osothsilp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using projectpayroll.Data;
using projectpayroll.Models;

namespace projectpayroll.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public EmployeeController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: Employee
        
        public async Task<IActionResult> Index()
        {
            var result = await _context.employees
                              .Select(x=>new{
                                  EmployeeId        = x.employeeId,
                                  EmployeeName      = x.FirstName+" "+x.LastName,
                                  Position          = x.Position,
                                  DepartmentName    = x.department.departmentName,
                                  Phone             = x.Phone,
                                  Email             = x.Email

                              })
                               .ToListAsync();
            ViewBag.employees = result;                                              
            return View();
        }//end function
 
        // GET: Employee/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table
            ViewBag.departments = _context.departments.Select(x=> new {x.departmentId,x.departmentName});
            //ViewBag.select_department = ViewBag.departments[0];
            ViewBag.banks = _context.banks.Select(x=> new {x.bankId,x.bankName});
            //ViewBag.select_bank = ViewBag.banks[0];

            return View();
        }//end function

        // POST: Employee/Add
        [HttpPost]
        public async Task<IActionResult> Add(employee employee)
        {
               try{
                _context.Add(employee);
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

        // GET: Employee/Edit/1
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

            var employee = await _context.employees.FindAsync(id);
            if (employee == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var departments = _context.departments.Select(x=> new {x.departmentId,x.departmentName});
            ViewBag.departments = departments;
            ViewBag.select_department = await departments.FirstOrDefaultAsync(x=>x.departmentId == employee.departmentId);
            
           
            var banks = _context.banks.Select(x=> new {x.bankId,x.bankName});
            ViewBag.banks = banks;
            ViewBag.select_bank = await banks.FirstOrDefaultAsync(x=>x.bankId == employee.bankId);
            
           

             ViewBag.employee = employee;
            return View();
        }//end function

        // POST: Employee/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(employee employee)
        {
             try{
                _context.employees.Update(employee);
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

        // GET: Employee/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.employees
                .FirstOrDefaultAsync(m => m.employeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }//end function

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.employees.FindAsync(id);
            _context.employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool EmployeeExists(int id)
        {
            return _context.employees.Any(e => e.employeeId == id);
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
            List<employee> list1 = new List<employee>();
            
            //empty table product type
            var lookupd = await _context.departments.ToDictionaryAsync(x=>x.departmentId);
            var lookupb = await _context.banks.ToDictionaryAsync(x=>x.bankId);
            
             
            
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
                        int emp_empID   = int.Parse(wk.Cells[i, 1].Value.ToString().Trim());
                        string emp_fname = wk.Cells[i, 2].Value.ToString().Trim();
                        string emp_lname = wk.Cells[i, 3].Value.ToString().Trim();
                        int emp_dep = int.Parse(wk.Cells[i, 4].Value.ToString().Trim());
                        string emp_pos = wk.Cells[i, 5].Value.ToString().Trim();
                        string emp_address = wk.Cells[i, 6].Value.ToString().Trim();
                        string emp_moblie = wk.Cells[i, 7].Value.ToString().Trim();
                        string emp_email = wk.Cells[i, 8].Value.ToString().Trim();
                        string emp_citizen_id = wk.Cells[i, 9].Value.ToString().Trim();
                        string emp_passport_id = wk.Cells[i, 10].Value.ToString().Trim();
                        int emp_bank = int.Parse(wk.Cells[i, 12].Value.ToString().Trim());
                        string emp_account = wk.Cells[i, 11].Value.ToString().Trim();
                        employee p = new employee(){
                            employeeId=emp_empID,
                            FirstName=emp_fname,
                            LastName=emp_lname,
                            departmentId=lookupd[emp_dep].departmentId,
                            Position=emp_pos,
                            Address=emp_address,
                            Phone=emp_moblie,
                            Email=emp_email,
                            CitizenID=emp_citizen_id,
                            PassportNo=emp_passport_id,
                            bankId=lookupb[emp_bank].bankId,
                            BankAccount=emp_account
                            
                        };

                        list1.Add(p);
                        
                        
                    }//end for
                    
                    await _context.employees.AddRangeAsync(list1);
                    await _context.SaveChangesAsync();
                    
                    return Json(new {
                        error=-1,
                        msg = "done",

                    });

                }//end inner using
            }//end using


        }//ef
        [HttpGet]
         public async Task<IActionResult> Report1()
        {   
            var result = await _context.employees
                                .GroupBy(x=>x.department.departmentName)
                                .Select(g=>new{
                                        departmentName = g.Key,
                                        no = g.Count()
                                })
                                .OrderByDescending(x=>x.no )
                                .ToListAsync();                                          
            var x_data = result.Select(x=>x.departmentName).ToArray();
            var y_data = result.Select(x=>x.no).ToArray();
                return Json(new {
                x_data,
                y_data
             });
            //return Json(result);
        }//end function

        public IActionResult Report(){
            return View("Report1");
        }
    }//end class
}//end namespace
