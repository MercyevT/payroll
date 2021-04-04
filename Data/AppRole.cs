using Microsoft.AspNetCore.Identity;

namespace projectpayroll.Data{

    public class AppRole:IdentityRole{
 
        public AppRole(string Name):base(Name){}
        
    }
}