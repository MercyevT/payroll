using Microsoft.AspNetCore.Identity;

namespace projectpayroll.Data{

    public class AppUser:IdentityUser{

        public string first_name {get;set;}
        public string last_name {get;set;}
        public string department {get;set;}
        
        
    }
}