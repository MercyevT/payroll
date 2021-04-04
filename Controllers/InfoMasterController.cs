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
    public class InfoMasterController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public InfoMasterController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: InfoMaster
        public async Task<IActionResult> Index()
        {
            var result = await _context.InfoMasters
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.infoMasters = result;                                              
            return View();
        }//end function
 
        // GET: InfoMaster/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table

            return View();
        }//end function

        // POST: InfoMaster/Add
        [HttpPost]
        public async Task<IActionResult> Add(InfoMaster infoMaster)
        {
               try{
                _context.Add(infoMaster);
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

        // GET: InfoMaster/Edit/1
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

            var infoMaster = await _context.InfoMasters.FindAsync(id);
            if (infoMaster == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }

             ViewBag.infoMaster = infoMaster;
            return View();
        }//end function

        // POST: InfoMaster/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(InfoMaster infoMaster)
        {
             try{
                _context.InfoMasters.Update(infoMaster);
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

        // GET: InfoMaster/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoMaster = await _context.InfoMasters
                .FirstOrDefaultAsync(m => m.InfoMasterId == id);
            if (infoMaster == null)
            {
                return NotFound();
            }

            return View(infoMaster);
        }//end function

        // POST: InfoMaster/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var infoMaster = await _context.InfoMasters.FindAsync(id);
            _context.InfoMasters.Remove(infoMaster);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool InfoMasterExists(int id)
        {
            return _context.InfoMasters.Any(e => e.InfoMasterId == id);
        }//end function
    }//end class
}//end namespace
