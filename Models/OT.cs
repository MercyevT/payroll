using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class OT {
        [Key]
        public int oTId           	{get;set;} //pk
		public int employeeId 		{get;set;}//fk=Employee show=employeeId
		public employee employee 	{get;set;}//np 
        public string oTStart    	{get;set;} //label="OT Start"
		public string oTFinish     	{get;set;} //label="OT Finish"
		public string oTDate     	{get;set;} //label="OT Date"
		public int TotalHour     	{get;set;} //label="Total Hours"
		public string oStatus     	{get;set;} //label="OT status"
   

    }//ef
}//en