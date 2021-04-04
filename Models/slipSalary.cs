using System;
using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class slipSalary {
        [Key]
        public int slipSalaryId             {get;set;} //pk
        public int employeeId 			    {get;set;}//fk=Employee show=employeeId
		public employee employee 		    {get;set;}//np
		public double Totalearning			{get;set;}//label="Totalearning"
		public double Totaldeducttion		{get;set;}//label="Totaldeducttion"
        public double NetSalary             {get;set;}//label="NetSalary"
		public string Month			        {get;set;}//label="Month"
        public string Year			        {get;set;}//label="Year"
    }//ef
}//en