using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class CurrentSalary {
        [Key]
        public int currentSalaryId  {get;set;} //pk
		public int employeeId {get;set;} //fk=employee show=employeeId
		public employee employee {get;set;}//np
		public int employeeSalaryMasterId {get;set;} //fk=EmployeeSalaryMaster show=employeeSalaryMasterId
		public EmployeeSalaryMaster employeesalarymaster {get;set;} //np
        public double currentSalaryAmount  {get;set;} //label="currentSalaryAmount"
		
		public int year {get;set;}//label="year"
   

    }//ef
}//en