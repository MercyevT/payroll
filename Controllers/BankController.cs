//Author Anan Osothsilp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using projectpayroll.Data;
using projectpayroll.Models;

namespace projectpayroll.Controllers
{
    public class BankController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public BankController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: Bank
        public async Task<IActionResult> Index()
        {
            var result = await _context.banks
                              .Select(x=>x)
                               .ToListAsync();
            ViewBag.banks = result;                                              
            return View();
        }//end function
 
        // GET: Bank/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table

            return View();
        }//end function

        // POST: Bank/Add
        [HttpPost]
        public async Task<IActionResult> Add(bank bank)
        {
               try{
                _context.Add(bank);
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

        // GET: Bank/Edit/1
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

            var bank = await _context.banks.FindAsync(id);
            if (bank == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }

             ViewBag.bank = bank;
            return View();
        }//end function

        // POST: Bank/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(bank bank)
        {
             try{
                _context.banks.Update(bank);
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

        // GET: Bank/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bank = await _context.banks
                .FirstOrDefaultAsync(m => m.bankId == id);
            if (bank == null)
            {
                return NotFound();
            }

            return View(bank);
        }//end function

        // POST: Bank/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bank = await _context.banks.FindAsync(id);
            _context.banks.Remove(bank);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool BankExists(int id)
        {
            return _context.banks.Any(e => e.bankId == id);
        }//end function

    }//end class
}//end namespace
