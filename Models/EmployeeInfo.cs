using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class EmployeeInfo {
        [Key]
        public int employeeInfoId           {get;set;} //pk
		public int employeeId 			{get;set;}//fk=Employee show=employeeId
		public employee employee 		{get;set;}//np
        public int InfoMasterId     {get;set;}//fk=InfoMaster show=InfoMasterId
		public InfoMaster InfoMaster 		{get;set;}//np
        

    }//ef
}//en