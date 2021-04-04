using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class InfoMaster {
        [Key]
        public int InfoMasterId         {get;set;} //pk
        public string information     {get;set;} //label="information"
		public double value				{get;set;} //label="value"
		public int year				{get;set;} //label="year"
		
   

    }//ef
}//en