namespace backend.Models
{
    public class UserModel()
    {    
        public int Id { get; set; }
        public required string FirstName { get; set; }
    
        public required string LastName { get; set; }
    
        public DateOnly DateOfBirth { get; set; }
    
        public required string Username { get; set; }
    
        public required string Email { get; set; }
        
        public required string Password { get; set; }
    
        public string? Nationality { get; set; }
    }
}
