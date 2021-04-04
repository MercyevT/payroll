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
    public class EmployeeInfoController : Controller
    {
        private readonly projectpayrollDbContext _context;

        public EmployeeInfoController(projectpayrollDbContext context)
        {
            _context = context;
        }//end function

        // GET: EmployeeInfo
        public async Task<IActionResult> Index()
        {
            var result = await _context.EmployeeInfos
                              .Select(x=>new{
                                  employeeId    =   x.employee.employeeId,
                                  employeeName  =   x.employee.FirstName+" "+x.employee.LastName,
                                  InfoMasterId  =   x.InfoMaster.InfoMasterId,
                                  InfoMasterName    =   x.InfoMaster.information
                              })
                               .ToListAsync();
            ViewBag.employeeInfos = result;                                              
            return View();
        }//end function
 
        // GET: EmployeeInfo/Create
        public IActionResult Add()
        {
        	//custom queries from FK data table
            ViewBag.employees = _context.employees.Select(x=> new {x.employeeId});
            //ViewBag.select_employee = ViewBag.employees[0];
            ViewBag.InfoMasters = _context.InfoMasters.Select(x=> new {x.InfoMasterId,x.information});
            //ViewBag.select_InfoMaster = ViewBag.InfoMasters[0];

            return View();
        }//end function

        // POST: EmployeeInfo/Add
        [HttpPost]
        public async Task<IActionResult> Add(EmployeeInfo employeeInfo)
        {
               try{
                _context.Add(employeeInfo);
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

        // GET: EmployeeInfo/Edit/1
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

            var employeeInfo = await _context.EmployeeInfos.FindAsync(id);
            if (employeeInfo == null)
            {
                 return Json( new {
                              error=1,
                              message = "no",
                              exception= id.ToString() + " not found"
                    });
            }
            var employees = _context.employees.Select(x=> new {x.employeeId});
            ViewBag.employees = employees;
            ViewBag.select_employee = await employees.FirstOrDefaultAsync(x=>x.employeeId == employeeInfo.employeeId);
            
           
            var InfoMasters = _context.InfoMasters.Select(x=> new {x.InfoMasterId,x.information});
            ViewBag.InfoMasters = InfoMasters;
            ViewBag.select_InfoMaster = await InfoMasters.FirstOrDefaultAsync(x=>x.InfoMasterId == employeeInfo.InfoMasterId);
            
           

             ViewBag.employeeInfo = employeeInfo;
            return View();
        }//end function

        // POST: EmployeeInfo/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(EmployeeInfo employeeInfo)
        {
             try{
                _context.EmployeeInfos.Update(employeeInfo);
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

        // GET: EmployeeInfo/Delete/1
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeInfo = await _context.EmployeeInfos
                .FirstOrDefaultAsync(m => m.employeeInfoId == id);
            if (employeeInfo == null)
            {
                return NotFound();
            }

            return View(employeeInfo);
        }//end function

        // POST: EmployeeInfo/Delete/5
        [HttpPost, ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeInfo = await _context.EmployeeInfos.FindAsync(id);
            _context.EmployeeInfos.Remove(employeeInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }//end function

        private bool EmployeeInfoExists(int id)
        {
            return _context.EmployeeInfos.Any(e => e.employeeInfoId == id);
        }//end function
    }//end class
}//end namespace
