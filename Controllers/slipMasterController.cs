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
    public class slipMasterController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public slipMasterController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: slipMaster
        public async Task<IActionResult> Index()
        {
            var result = await _context.slipMasters
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.slipMasters = result;                                              
            return View();
        }//end function
 
        // GET: slipMaster/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table

            return View();
        }//end function

        // POST: slipMaster/Add
        [HttpPost]
        public async Task<IActionResult> Add(slipMaster slipMaster)
        {
               try{
                _context.Add(slipMaster);
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

        // GET: slipMaster/Edit/1
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

            var slipMaster = await _context.slipMasters.FindAsync(id);
            if (slipMaster == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }

             ViewBag.slipMaster = slipMaster;
            return View();
        }//end function

        // POST: slipMaster/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(slipMaster slipMaster)
        {
             try{
                _context.slipMasters.Update(slipMaster);
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

        // GET: slipMaster/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slipMaster = await _context.slipMasters
                .FirstOrDefaultAsync(m => m.slipMasterId == id);
            if (slipMaster == null)
            {
                return NotFound();
            }

            return View(slipMaster);
        }//end function

        // POST: slipMaster/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slipMaster = await _context.slipMasters.FindAsync(id);
            _context.slipMasters.Remove(slipMaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool slipMasterExists(int id)
        {
            return _context.slipMasters.Any(e => e.slipMasterId == id);
        }//end function
    }//end class
}//end namespace
