using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class OTC {
        [Key]
        public int oTCId           {get;set;} //pk
		public int oTId 			{get;set;}//fk=OT show=oTId
		public OT OT 		{get;set;}//np
        public int value     {get;set;} //label="value"
		public string month				{get;set;}//label="month"
		public int years 				{get;set;}//label="years"
   

    }//ef
}//en