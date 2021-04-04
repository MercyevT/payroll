//Author Anan Osothsilp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using projectpayroll.Data;
using projectpayroll.Models;


namespace projectpayroll.Controllers
{
    public class slipSalaryController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public slipSalaryController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: slipSalary
        public async Task<IActionResult> Index()
        {
            var result = await _context.slipSalarys
                              .Select(x=>new{
                                  slipSalaryId      =   x.slipSalaryId,
                                  employeeId        =   x.employee.employeeId,
                                  employeeName      =   x.employee.FirstName+" "+x.employee.LastName,
                                  netSalary         =   x.NetSalary,
                                  totalearning      =   x.Totalearning,
                                  totaldeducttion   =   x.Totaldeducttion,
                                  month             =   int.Parse(x.Month),
                                  year              =   x.Year

                              })
                               .ToListAsync();
            ViewBag.slipSalarys = result;
            var result2 =   await _context.OTCs
                            .Select(x=> new{
                                employeeId      = x.OT.employeeId,
                                value           = x.value,
                                year            = x.years,
                                slipMasterId    = 2
                            })
                            .ToListAsync();
            ViewBag.OTCs = result2;
            var result3 = await _context.CurrentSalarys
                              .Select(x=> new{
                                  employeeId = x.employeeId,
                                  value      = x.currentSalaryAmount,
                                  year       = x.year,
                                  slipMasterId    = 1
                              })
                               .ToListAsync();
            ViewBag.CurrentSalarys = result3;
            var result4 = await _context.taxs
                              .Select(x=> new{
                                  employeeId = x.employeeId,
                                  value      = x.taxY,
                                  year       = x.year,
                                  slipMasterId    = 3
                              })
                               .ToListAsync();
            ViewBag.taxs = result4;
            var result5 = await _context.ssfunds
                              .Select(x=> new{
                                  employeeId = x.employeeId,
                                  value      = x.amountE,
                                  month      = x.month,
                                  year       = x.year,
                                  slipMasterId    = 4
                              })
                               .ToListAsync();
            ViewBag.ssfunds = result5;
            var result6 = await _context.employees
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.employee = result6;
            var result7 = await _context.slipMasters
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.slipMasters = result7;
            return View();
        }//end function
 
        // GET: slipSalary/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table
            ViewBag.employees = _context.employees.Select(x=> new {x.employeeId});
            //ViewBag.select_employee = ViewBag.employees[0];
            ViewBag.slipMasters = _context.slipMasters.Select(x=> new {x.slipMasterId,x.slipMasterName});
            //ViewBag.select_slipMaster	= ViewBag.slipMasters[0];

            return View();
        }//end function

        // POST: slipSalary/Add
        [HttpPost]
        public async Task<IActionResult> Add(slipSalary slipSalary)
        {
               try{
                _context.Add(slipSalary);
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

        // GET: slipSalary/Edit/1
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

            var slipSalary = await _context.slipSalarys.FindAsync(id);
            if (slipSalary == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var employees = _context.employees.Select(x=> new {x.employeeId});
            ViewBag.employees = employees;
            ViewBag.select_employee = await employees.FirstOrDefaultAsync(x=>x.employeeId == slipSalary.employeeId);
            
           
            var slipMasters = _context.slipMasters.Select(x=> new {x.slipMasterId,x.slipMasterName});
            
            
           

             ViewBag.slipSalary = slipSalary;
            return View();
        }//end function

        // POST: slipSalary/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(slipSalary slipSalary)
        {
             try{
                _context.slipSalarys.Update(slipSalary);
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

        // GET: slipSalary/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slipSalary = await _context.slipSalarys
                .FirstOrDefaultAsync(m => m.slipSalaryId == id);
            if (slipSalary == null)
            {
                return NotFound();
            }

            return View(slipSalary);
        }//end function

        // POST: slipSalary/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slipSalary = await _context.slipSalarys.FindAsync(id);
            _context.slipSalarys.Remove(slipSalary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function
        public async Task<IActionResult> slip(int? id)
        {   
           
            string[] a = id.ToString().Split("99");
            Console.WriteLine(int.Parse(a[0]));
            if (int.Parse(a[0]) == null)
            {
                return Json( new {
                              error=1,
                              message = "no",
                              exception= " please define id"
                    });
            }

            var employee = await _context.employees.FindAsync(int.Parse(a[0]));
            if (employee == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= int.Parse(a[0]).ToString() + " not found"
                    });
            }
            ViewBag.employee = employee;
            var result2 = await _context.departments
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.departments = result2;
             var result3 =   await _context.OTCs
                            .Select(x=> new{
                                employeeId      = x.OT.employeeId,
                                value           = x.value,
                                year            = x.years,
                                month           = x.month,
                                slipMasterId    = 2
                            })
                            .ToListAsync();
            ViewBag.OTCs = result3.Where(x=>x.employeeId==int.Parse(a[0])&&x.month==a[1]);
            var result4 = await _context.CurrentSalarys
                              .Select(x=> new{
                                  employeeId = x.employeeId,
                                  value      = x.currentSalaryAmount,
                                  year       = x.year,
                                  slipMasterId    = 1
                              })
                               .ToListAsync();
            ViewBag.CurrentSalarys = result4.Where(x=>x.employeeId==int.Parse(a[0]));
            var result5 = await _context.taxs
                              .Select(x=> new{
                                  employeeId = x.employeeId,
                                  value      = x.taxY,
                                  year       = x.year,
                                  slipMasterId    = 3
                              })
                               .ToListAsync();
            ViewBag.taxs = result5.Where(x=>x.employeeId==int.Parse(a[0]));
            var result6 = await _context.ssfunds
                              .Select(x=> new{
                                  employeeId = x.employeeId,
                                  value      = x.amountE,
                                  month      = x.month,
                                  year       = x.year,
                                  slipMasterId    = 4
                              })
                               .ToListAsync();
            ViewBag.ssfunds = result6.Where(x=>x.employeeId==int.Parse(a[0])&&x.month==a[1]);
            var result7 = await _context.slipMasters
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.slipMasters = result7;
            
             
            return View();
        }//end function
        public async Task<IActionResult> PND(){
            var result = await _context.slipSalarys
                              .Select(x=>new{
                                  employeeId        =   x.employeeId,
                                  employeeF         =   x.employee.FirstName,
                                  employeeL         =   x.employee.LastName,
                                  employeeA         =   x.employee.Address,
                                  employeeCId       =   x.employee.CitizenID,
                                  netSalary         =   x.NetSalary,
                                  totalearning      =   x.Totalearning,
                                  totaldeducttion   =   x.Totaldeducttion,
                                  month             =   int.Parse(x.Month),
                                  year              =   x.Year

                              })
                               .OrderBy(x=>x.employeeId)
                               .ToListAsync();
            ViewBag.slipSalarys = result;
            var result2 = await _context.taxs
                              .Select(x=>x)
                               .OrderBy(x=>x.employeeId)
                               .ToListAsync();
            ViewBag.taxs = result2;
            var result3 = await _context.CurrentSalarys
                              .Select(x=>x)
                               .OrderBy(x=>x.employeeId)
                               .ToListAsync();
            ViewBag.CurrentSalarys = result3;
            var result4 = await _context.ManagerInfos
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.ManagerInfos = result4;

            return View();
        }
        public async Task<IActionResult> export1(){
                var result = await _context.slipSalarys
                              .Select(x=>new{
                                  employeeId        =   x.employeeId,
                                  employeeF         =   x.employee.FirstName,
                                  employeeL         =   x.employee.LastName,
                                  employeeA         =   x.employee.Address,
                                  employeeCId       =   x.employee.CitizenID,
                                  netSalary         =   x.NetSalary,
                                  totalearning      =   x.Totalearning,
                                  totaldeducttion   =   x.Totaldeducttion,
                                  month             =   int.Parse(x.Month),
                                  year              =   x.Year

                              })
                               .OrderBy(x=>x.employeeId)
                               .ToListAsync();
            ViewBag.slipSalarys = result;
            var result2 = await _context.taxs
                              .Select(x=>x)
                               .OrderBy(x=>x.employeeId)
                               .ToListAsync();
            ViewBag.taxs = result2;
            var result3 = await _context.CurrentSalarys
                              .Select(x=>x)
                               .OrderBy(x=>x.employeeId)
                               .ToListAsync();
            ViewBag.CurrentSalarys = result3;
            var result4 = await _context.ManagerInfos
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.ManagerInfos = result4;
              return View();
        }
        public async Task<IActionResult> v50(){
            var result = await _context.slipSalarys
                              .Select(x=>new{
                                  employeeId        =   x.employeeId,
                                  employeeF         =   x.employee.FirstName,
                                  employeeL         =   x.employee.LastName,
                                  employeeA         =   x.employee.Address,
                                  employeeCId       =   x.employee.CitizenID,
                                  netSalary         =   x.NetSalary,
                                  totalearning      =   x.Totalearning,
                                  totaldeducttion   =   x.Totaldeducttion,
                                  month             =   int.Parse(x.Month),
                                  year              =   x.Year

                              })
                               .OrderBy(x=>x.employeeId)
                               .ToListAsync();
            ViewBag.slipSalarys = result;
            var result2 = await _context.ManagerInfos
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.ManagerInfos = result2;
                
              return View();
        }
        
         
        public async Task<IActionResult> BankReport(int? id)
        {   
            
            var result = await _context.slipSalarys
                                .Select(x=>new{
                                    employeeId      =   x.employee.employeeId,
                                    employeeName    =   x.employee.FirstName+" "+x.employee.LastName,
                                    employeeAccount =   x.employee.BankAccount,
                                    salary          =   x.NetSalary.ToString("N2"),
                                    month           =   x.Month
                                })
                                .OrderBy(x=>x.employeeId)
                                .Where(x=>x.month==id.ToString())
                               .ToListAsync(); 
        ExcelPackage excel = new ExcelPackage();
        var workSheet = excel.Workbook.Worksheets.Add("Sheet1"); 
        workSheet.TabColor = System.Drawing.Color.Black;
        workSheet.DefaultRowHeight = 12;
        workSheet.Row(1).Height = 20;
        workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
        workSheet.Row(1).Style.Font.Bold = true;
        workSheet.Cells[1, 1].Value = "Employee Id";
        workSheet.Cells[1, 2].Value = "Employee Name";
        workSheet.Cells[1, 3].Value = "Employee Account";
        workSheet.Cells[1, 4].Value = "Salary";
        int recordIndex = 2;
          
        foreach (var Result in result)
        {
            workSheet.Cells[recordIndex, 1].Value = Result.employeeId;
            workSheet.Cells[recordIndex, 2].Value = Result.employeeName;
            workSheet.Cells[recordIndex, 3].Value = Result.employeeAccount;
            workSheet.Cells[recordIndex, 4].Value = Result.salary;
            recordIndex++;
        }
        workSheet.Column(1).AutoFit();
        workSheet.Column(2).AutoFit();
        workSheet.Column(3).AutoFit();
        workSheet.Column(4).AutoFit();
         
         //string filePath = "C:\\Users\\max_w\\Downloads\\Test1.xlsx";
         //FileInfo fi = new FileInfo(filePath);
         //excel.SaveAs(fi);
          return File(excel.GetAsByteArray(), "application/xlsx", "BankReport.xlsx");
            
            //return Json(result);
        }//end function
        
        


        private bool slipSalaryExists(int id)
        {
            return _context.slipSalarys.Any(e => e.slipSalaryId == id);
        }//end function
    }//end class
}//end namespace
