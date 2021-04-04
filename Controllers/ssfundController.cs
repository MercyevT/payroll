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
    public class ssfundController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public ssfundController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: ssfund
        public async Task<IActionResult> Index()
        {
            var result = await _context.ssfunds
                              .Select(x=> new{
                                  ssfundId      =   x.ssfundId,
                                  employeeId    =   x.employeeId,
                                  employeeName  =   x.employee.FirstName+" "+x.employee.LastName,
                                  amountE       =   x.amountE,
                                  amountM       =   x.amountM,
                                  month         =   x.month,
                                  year          =   x.year
                              })
                               .ToListAsync();
            ViewBag.ssfunds = result;  
            var result2 = await _context.employees
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.employees = result2;
            var result3 = await _context.CurrentSalarys
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.currentSalarys = result3;  
            //pie employee
             var result4 = await _context.ssfunds
                                .GroupBy(x =>x.amountE)
                                .Select(g => new{
                                  value = g.Count(),
                                  name = g.Key.ToString()  
                                })
                                .OrderBy(x=>x.value)
                                .ToListAsync();
            ViewBag.pieE = result4; 

            //pie company                   
            var result5 = await _context.ssfunds
                                .GroupBy(x =>x.amountM)
                                .Select(g => new{
                                  value = g.Count(),
                                  name = g.Key.ToString()
                                })
                                .OrderBy(x=>x.value)
                                .ToListAsync();  
            ViewBag.pieM = result5;                                                
            return View();
        }//end function
 
        // GET: ssfund/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table
            ViewBag.employees = _context.employees.Select(x=> new {x.employeeId,x.FirstName});
            //ViewBag.select_employee = ViewBag.employees[0];

            return View();
        }//end function

        // POST: ssfund/Add
        [HttpPost]
        public async Task<IActionResult> Add(ssfund ssfund)
        {
               try{
                _context.Add(ssfund);
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

        // GET: ssfund/Edit/1
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

            var ssfund = await _context.ssfunds.FindAsync(id);
            if (ssfund == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var employees = _context.employees.Select(x=> new {x.employeeId,x.FirstName});
            ViewBag.employees = employees;
            ViewBag.select_employee = await employees.FirstOrDefaultAsync(x=>x.employeeId == ssfund.employeeId);
            
           

             ViewBag.ssfund = ssfund;
            return View();
        }//end function

        // POST: ssfund/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(ssfund ssfund)
        {
             try{
                _context.ssfunds.Update(ssfund);
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

        // GET: ssfund/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ssfund = await _context.ssfunds
                .FirstOrDefaultAsync(m => m.ssfundId == id);
            if (ssfund == null)
            {
                return NotFound();
            }

            return View(ssfund);
        }//end function
        

        // POST: ssfund/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ssfund = await _context.ssfunds.FindAsync(id);
            _context.ssfunds.Remove(ssfund);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool ssfundExists(int id)
        {
            return _context.ssfunds.Any(e => e.ssfundId == id);
        }//end function
    }//end class
}//end namespace
