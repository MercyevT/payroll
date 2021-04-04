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
    public class workingTimeController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public workingTimeController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: workingTime
        public async Task<IActionResult> Index()
        {
            var result = await _context.workingTimes
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.workingTimes = result;                                              
            return View();
        }//end function
 
        // GET: workingTime/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table
            ViewBag.departments = _context.departments.Select(x=> new {x.departmentId,x.departmentName});
            //ViewBag.select_department = ViewBag.departments[0];

            return View();
        }//end function

        // POST: workingTime/Add
        [HttpPost]
        public async Task<IActionResult> Add(workingTime workingTime)
        {
               try{
                _context.Add(workingTime);
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

        // GET: workingTime/Edit/1
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

            var workingTime = await _context.workingTimes.FindAsync(id);
            if (workingTime == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var departments = _context.departments.Select(x=> new {x.departmentId,x.departmentName});
            ViewBag.departments = departments;
            ViewBag.select_department = await departments.FirstOrDefaultAsync(x=>x.departmentId == workingTime.departmentId);
            
           

             ViewBag.workingTime = workingTime;
            return View();
        }//end function

        // POST: workingTime/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(workingTime workingTime)
        {
             try{
                _context.workingTimes.Update(workingTime);
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

        // GET: workingTime/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workingTime = await _context.workingTimes
                .FirstOrDefaultAsync(m => m.workingTimeId == id);
            if (workingTime == null)
            {
                return NotFound();
            }

            return View(workingTime);
        }//end function

        // POST: workingTime/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workingTime = await _context.workingTimes.FindAsync(id);
            _context.workingTimes.Remove(workingTime);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool workingTimeExists(int id)
        {
            return _context.workingTimes.Any(e => e.workingTimeId == id);
        }//end function
    }//end class
}//end namespace
