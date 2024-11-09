namespace LAB7_8.Models
{
    public class UserModel
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public int Age { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public required string City { get; set; }
        public required string Country { get; set; }
        public DateTime? BirthDate { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
