using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class workingTime {
        [Key]
        public int workingTimeId           {get;set;} //pk
		public int departmentId 	{get;set;}//fk=department show=departmentName
		public department department {get;set;}//np
        public string start     {get;set;} //label="start"
		public string finish     {get;set;} //label="start"
   

    }//ef
}//en