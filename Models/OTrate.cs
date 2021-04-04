using System.ComponentModel.DataAnnotations;

namespace  projectpayroll.Models
{
    public class OTrate {
        [Key]
        public int oTrateId           {get;set;} //pk
        public int departmentId {get;set;} //fk=department show=departmentName
		public department department {get;set;} //np
   		public string position {get;set;} //label="Position"
		public int value     {get;set;} //label="value"

    }//ef
}//en