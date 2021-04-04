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
    public class ManagerInfoController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public ManagerInfoController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: ManagerInfo
        public async Task<IActionResult> Index()
        {
            var result = await _context.ManagerInfos
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.managerInfos = result;                                              
            return View();
        }//end function
 
        // GET: ManagerInfo/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table

            return View();
        }//end function

        // POST: ManagerInfo/Add
        [HttpPost]
        public async Task<IActionResult> Add(ManagerInfo managerInfo)
        {
               try{
                _context.Add(managerInfo);
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

        // GET: ManagerInfo/Edit/1
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

            var managerInfo = await _context.ManagerInfos.FindAsync(id);
            if (managerInfo == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }

             ViewBag.managerInfo = managerInfo;
            return View();
        }//end function

        // POST: ManagerInfo/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(ManagerInfo managerInfo)
        {
             try{
                _context.ManagerInfos.Update(managerInfo);
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

        // GET: ManagerInfo/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managerInfo = await _context.ManagerInfos
                .FirstOrDefaultAsync(m => m.managerInfoId == id);
            if (managerInfo == null)
            {
                return NotFound();
            }

            return View(managerInfo);
        }//end function

        // POST: ManagerInfo/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var managerInfo = await _context.ManagerInfos.FindAsync(id);
            _context.ManagerInfos.Remove(managerInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool ManagerInfoExists(int id)
        {
            return _context.ManagerInfos.Any(e => e.managerInfoId == id);
        }//end function
    }//end class
}//end namespace
