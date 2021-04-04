using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class EmployeeSalaryMaster {
        [Key]
        public int employeeSalaryMasterId {get;set;} //pk label="Employee Salary Master Id"
        public int departmentId {get;set;} //fk=department show=departmentName
		public department department {get;set;} //np
		public string position {get;set;} //label="Position"
		public string employeestatus {get;set;} //label="employeestatus"
		public double basicSalary {get;set;} //label="Basic Salary"
   		public double salaryRate {get;set;} //label ="Salary Rate"

    }//ef
}//en