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
    public class OTCController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public OTCController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: OTC
        public async Task<IActionResult> Index()
        {
            var result = await _context.OTCs
                              .Select(x=>x)
                               .ToListAsync();
            var result2 = await _context.OTs
                              .Select(x=>new{
                                  employeeId    =   x.employee.employeeId,
                                  department    =   x.employee.department.departmentId,
                                  position      =   x.employee.Position,
                                  oStatus       =   x.oStatus,
                                  oTDate        =   x.oTDate,
                                  oTFinish      =   x.oTFinish,
                                  oTId          =   x.oTId,
                                  oTStart       =   x.oTStart,
                                  totalHour     =   x.TotalHour
                              })
                               .ToListAsync();
            var result3 = await _context.OTrates
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.oTCs    = result;        
            ViewBag.oTs     = result2;    
            ViewBag.OTrates = result3;                                       
            return View();
        }//end function
 
        // GET: OTC/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table
            ViewBag.oTs = _context.OTs.Select(x=> new {x.oTId});
            //ViewBag.select_oT = ViewBag.oTs[0];

            return View();
        }//end function

        // POST: OTC/Add
        [HttpPost]
        public async Task<IActionResult> Add(OTC oTC)
        {
               try{
                _context.Add(oTC);
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

        // GET: OTC/Edit/1
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

            var oTC = await _context.OTCs.FindAsync(id);
            if (oTC == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var oTs = _context.OTs.Select(x=> new {x.oTId});
            ViewBag.oTs = oTs;
            ViewBag.select_oT = await oTs.FirstOrDefaultAsync(x=>x.oTId == oTC.oTId);
            
           

             ViewBag.oTC = oTC;
            return View();
        }//end function

        // POST: OTC/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(OTC oTC)
        {
             try{
                _context.OTCs.Update(oTC);
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

        // GET: OTC/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var oTC = await _context.OTCs
                .FirstOrDefaultAsync(m => m.oTCId == id);
            if (oTC == null)
            {
                return NotFound();
            }

            return View(oTC);
        }//end function

        // POST: OTC/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var oTC = await _context.OTCs.FindAsync(id);
            _context.OTCs.Remove(oTC);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool OTCExists(int id)
        {
            return _context.OTCs.Any(e => e.oTCId == id);
        }//end function
    }//end class
}//end namespace
