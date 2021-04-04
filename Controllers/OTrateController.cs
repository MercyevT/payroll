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
    public class OTrateController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public OTrateController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: OTrate
        public async Task<IActionResult> Index()
        {
            var result = await _context.OTrates
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.oTrates = result;                                              
            return View();
        }//end function
 
        // GET: OTrate/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table
            ViewBag.departments = _context.departments.Select(x=> new {x.departmentId,x.departmentName});
            //ViewBag.select_department = ViewBag.departments[0];

            return View();
        }//end function

        // POST: OTrate/Add
        [HttpPost]
        public async Task<IActionResult> Add(OTrate oTrate)
        {
               try{
                _context.Add(oTrate);
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

        // GET: OTrate/Edit/1
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

            var oTrate = await _context.OTrates.FindAsync(id);
            if (oTrate == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var departments = _context.departments.Select(x=> new {x.departmentId,x.departmentName});
            ViewBag.departments = departments;
            ViewBag.select_department = await departments.FirstOrDefaultAsync(x=>x.departmentId == oTrate.departmentId);
            
           

             ViewBag.oTrate = oTrate;
            return View();
        }//end function

        // POST: OTrate/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(OTrate oTrate)
        {
             try{
                _context.OTrates.Update(oTrate);
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

        // GET: OTrate/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oTrate = await _context.OTrates
                .FirstOrDefaultAsync(m => m.oTrateId == id);
            if (oTrate == null)
            {
                return NotFound();
            }

            return View(oTrate);
        }//end function

        // POST: OTrate/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oTrate = await _context.OTrates.FindAsync(id);
            _context.OTrates.Remove(oTrate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool OTrateExists(int id)
        {
            return _context.OTrates.Any(e => e.oTrateId == id);
        }//end function
    }//end class
}//end namespace
