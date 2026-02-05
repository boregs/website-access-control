namespace WebsiteAccessControl.Models
{
  public class UserSignIn(){
    
        public string firstName { get; set; }

        public string lastName { get; set; }

        public DateOnly dateOfBirth { get; set; }

        public string username { get; set; }

        public string email { get; set; }
    
        public string password { get; set; }

        public string nationality { get; set; }
  }
}
