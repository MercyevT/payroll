using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class ManagerInfo {
        [Key]
        public int managerInfoId           {get;set;} //pk
        public string managerInfoFname     {get;set;} //label="managerInfoFname"
		public string managerInfoLname     {get;set;} //label="managerInfoLname"
		public string managerCZId	       {get;set;} //label="managerCZId"
		public string managerAddress	   {get;set;} //label="managerAddress"
		public string managerCode		   {get;set;} //label="managerCode"
		
		
		

    }//ef
}//en