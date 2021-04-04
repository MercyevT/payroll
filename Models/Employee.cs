using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class employee {
        [Key]
        public int employeeId           {get;set;} //pk
        public string FirstName     {get;set;} //label="FirstName"
		public string LastName     {get;set;} //label="LastName"
		public string Position     {get;set;} //label="Position"
		public int departmentId 	{get;set;}//fk=department show=departmentName
		public department department {get;set;}//np
		public string Address     {get;set;} //label="Address"
		public string Phone     {get;set;} //label="Phone"
		public string Email     {get;set;} //label="Email"
		public int bankId     {get;set;} //fk=bank show=bankName
		public bank bank {get;set;}//np
		public string BankAccount     {get;set;} //label="BankAccount"
		public string CitizenID     {get;set;} //label="CitizenID"
		public string PassportNo     {get;set;} //label="PassportNo"
		
   

    }//ef
}//en