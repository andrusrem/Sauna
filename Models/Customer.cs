namespace Sauna.Models
{
    public class Customer
    {
        public string Id { get; set;}
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string Email { get; set;}
        public string? PhoneNumber { get; set;}
        public string Country { get; set;}
        public string City { get; set;}
        public string Street { get; set;}
        public int HomeNumber { get; set;}
        public int? AppartmentNumber { get; set;}
    }
}