using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class tax {
        [Key]
        public int taxId           {get;set;} //pk
        public int employeeId     {get;set;} //fk=Employee show=employeeId
		public employee employee	{get;set;}//np
		public double netSalary		{get;set;}//label="netSalary"
		public double taxY			{get;set;}//label="taxY"
		public string year			{get;set;}//label="year" 
   

    }//ef
}//en