using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class slipMaster {
        [Key]
        public int slipMasterId           {get;set;} //pk
        public string slipMasterName     {get;set;} //label="slipmaster"
		public int slipMasterType     {get;set;} //label="slipMasterType"
   

    }//ef
}//en