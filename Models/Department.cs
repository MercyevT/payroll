using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class department {
        [Key]
        public int departmentId           {get;set;} //pk
        public string departmentName     {get;set;} //label="department"
   

    }//ef
}//en