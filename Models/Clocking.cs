using System.ComponentModel.DataAnnotations;


namespace  projectpayroll.Models
{
    public class clocking {
        [Key]
		
        public int clockingId           {get;set;} //pk
		
        public int employeeId 			{get;set;}//fk=Employee show=employeeId
		public employee employee 		{get;set;}//np
		
		public string  clockingIn		{get;set;}//label="clockingIn"
		
		public string  breakIn			{get;set;}//label="breakIn"
		
		public string  breakOut			{get;set;}//label="breakOut"
		
		public string  clockingOut		{get;set;}//label="clockingOut"
		
		public string  Date				{get;set;}//label="Date"
		
   

    }//ef
}//en