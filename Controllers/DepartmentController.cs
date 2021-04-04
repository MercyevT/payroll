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
    public class DepartmentController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public DepartmentController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: Department
        public async Task<IActionResult> Index()
        {
            var result = await _context.departments
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.departments = result;                                              
            return View();
        }//end function
 
        // GET: Department/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table

            return View();
        }//end function

        // POST: Department/Add
        [HttpPost]
        public async Task<IActionResult> Add(department department)
        {
               try{
                _context.Add(department);
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

        // GET: Department/Edit/1
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

            var department = await _context.departments.FindAsync(id);
            if (department == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }

             ViewBag.department = department;
            return View();
        }//end function

        // POST: Department/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(department department)
        {
             try{
                _context.departments.Update(department);
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

        // GET: Department/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await _context.departments
                .FirstOrDefaultAsync(m => m.departmentId == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }//end function

        // POST: Department/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var department = await _context.departments.FindAsync(id);
            _context.departments.Remove(department);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool DepartmentExists(int id)
        {
            return _context.departments.Any(e => e.departmentId == id);
        }//end function
    }//end class
}//end namespace
