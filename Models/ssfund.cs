using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class ssfund {
        [Key]
        public int ssfundId           {get;set;} //pk
        public int employeeId 			{get;set;}//fk=Employee show=employeeId
		public employee employee 		{get;set;}//np
		public int amountE 				{get;set;}//label="value"
        public int amountM 				{get;set;}//label="value"
		public double ssfundER			{get;set;}//label="ssfundR"
        public double ssfundMR			{get;set;}//label="ssfundR"
		public string month				{get;set;}//label="month"
		public int year 				{get;set;}//label="year"
   

    }//ef
}//en