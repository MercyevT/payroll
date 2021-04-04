using projectpayroll.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
 
namespace projectpayroll.Data
{
     public class projectpayrollDbContext : IdentityDbContext<AppUser,AppRole,string>{
         public projectpayrollDbContext(DbContextOptions<projectpayrollDbContext> options):base(options){
            
         }//ef
         protected override void OnModelCreating(ModelBuilder builder)
        {
 
            base.OnModelCreating(builder);
        }
        public DbSet<AppUser> AppUsers {get;set;}
        public DbSet<employee> employees {get;set;}
        public DbSet<clocking> clockings {get;set;}
        public DbSet<bank> banks {get;set;}
        public DbSet<department> departments {get;set;}
        public DbSet<EmployeeInfo> EmployeeInfos {get;set;}
        public DbSet<CurrentSalary> CurrentSalarys {get;set;}
        public DbSet<EmployeeSalaryMaster> EmployeeSalaryMasters {get;set;}
        public DbSet<workingTime> workingTimes {get;set;}
        public DbSet<tax> taxs {get;set;}
        public DbSet<ssfund> ssfunds {get;set;}
        public DbSet<slipMaster> slipMasters {get;set;}
        public DbSet<slipSalary> slipSalarys {get;set;}
        public DbSet<OT> OTs {get;set;}
        public DbSet<OTC> OTCs {get;set;}
        public DbSet<InfoMaster> InfoMasters {get;set;}
        public DbSet<ManagerInfo> ManagerInfos {get;set;}
        public DbSet<OTrate> OTrates {get;set;}
    
     }//ec
}//en