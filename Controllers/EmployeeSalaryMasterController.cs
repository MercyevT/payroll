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
    public class EmployeeSalaryMasterController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public EmployeeSalaryMasterController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: EmployeeSalaryMaster
        public async Task<IActionResult> Index()
        {
            var result = await _context.EmployeeSalaryMasters
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.employeeSalaryMasters = result;                                              
            return View();
        }//end function
 
        // GET: EmployeeSalaryMaster/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table
            ViewBag.departments = _context.departments.Select(x=> new {x.departmentId,x.departmentName});
            //ViewBag.select_department = ViewBag.departments[0];

            return View();
        }//end function

        // POST: EmployeeSalaryMaster/Add
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeSalaryMaster employeeSalaryMaster)
        {
               try{
                _context.Add(employeeSalaryMaster);
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

        // GET: EmployeeSalaryMaster/Edit/1
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

            var employeeSalaryMaster = await _context.EmployeeSalaryMasters.FindAsync(id);
            if (employeeSalaryMaster == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var departments = _context.departments.Select(x=> new {x.departmentId,x.departmentName});
            ViewBag.departments = departments;
            ViewBag.select_department = await departments.FirstOrDefaultAsync(x=>x.departmentId == employeeSalaryMaster.departmentId);
            
           

             ViewBag.employeeSalaryMaster = employeeSalaryMaster;
            return View();
        }//end function

        // POST: EmployeeSalaryMaster/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeSalaryMaster employeeSalaryMaster)
        {
             try{
                _context.EmployeeSalaryMasters.Update(employeeSalaryMaster);
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

        // GET: EmployeeSalaryMaster/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeSalaryMaster = await _context.EmployeeSalaryMasters
                .FirstOrDefaultAsync(m => m.employeeSalaryMasterId == id);
            if (employeeSalaryMaster == null)
            {
                return NotFound();
            }

            return View(employeeSalaryMaster);
        }//end function

        // POST: EmployeeSalaryMaster/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeSalaryMaster = await _context.EmployeeSalaryMasters.FindAsync(id);
            _context.EmployeeSalaryMasters.Remove(employeeSalaryMaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool EmployeeSalaryMasterExists(int id)
        {
            return _context.EmployeeSalaryMasters.Any(e => e.employeeSalaryMasterId == id);
        }//end function
    }//end class
}//end namespace
