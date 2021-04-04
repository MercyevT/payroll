//Author Anan Osothsilp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using projectpayroll.Data;
using projectpayroll.Models;

namespace projectpayroll.Controllers
{
    public class taxController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public taxController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: tax
        public async Task<IActionResult> Index()
        {
            var result = await _context.taxs
                              .Select(x=>new{
                                  taxId         = x.taxId,
                                  employeeId    = x.employee.employeeId,
                                  employeeName  = x.employee.FirstName+" "+x.employee.LastName,
                                  netSalary     = x.netSalary,
                                  taxY          = x.taxY,
                                  year          = x.year
                              })
                              .OrderBy(x=>x.employeeId)
                               .ToListAsync();
            ViewBag.taxs = result;                       
            var result2 = await _context.CurrentSalarys
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.CurrentSalarys = result2;
            var result3 = await _context.EmployeeInfos
                              .Select(x=>new{
                                  employeeInfoId    = x.employeeInfoId,
                                  employeeId        = x.employeeId,
                                  value             = x.InfoMaster.value
                              })
                               .ToListAsync();
            ViewBag.employeeInfos = result3;       
            var result4 = await _context.employees
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.employees = result4;                                                 
            return View();
        }//end function
 
        // GET: tax/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table
            ViewBag.employees = _context.employees.Select(x=> new {x.employeeId});
            //ViewBag.select_employee = ViewBag.employees[0];

            return View();
        }//end function

        // POST: tax/Add
        [HttpPost]
        public async Task<IActionResult> Add(tax tax)
        {
               try{
                _context.Add(tax);
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

        // GET: tax/Edit/1
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

            var tax = await _context.taxs.FindAsync(id);
            if (tax == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var employees = _context.employees.Select(x=> new {x.employeeId});
            ViewBag.employees = employees;
            ViewBag.select_employee = await employees.FirstOrDefaultAsync(x=>x.employeeId == tax.employeeId);
            
           

             ViewBag.tax = tax;
            return View();
        }//end function

        // POST: tax/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(tax tax)
        {
             try{
                _context.taxs.Update(tax);
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

        // GET: tax/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tax = await _context.taxs
                .FirstOrDefaultAsync(m => m.taxId == id);
            if (tax == null)
            {
                return NotFound();
            }

            return View(tax);
        }//end function

        // POST: tax/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tax = await _context.taxs.FindAsync(id);
            _context.taxs.Remove(tax);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool taxExists(int id)
        {
            return _context.taxs.Any(e => e.taxId == id);
        }//end function
    }//end class
}//end namespace
