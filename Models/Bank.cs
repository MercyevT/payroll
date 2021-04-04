using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class bank {
        [Key]
        public int bankId           {get;set;} //pk
        public string bankName     {get;set;} //label="Bank name"
		
   

    }//ef
}//en