namespace App.Models.Entities
{
    public class UserAddress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string City { get; set; } = null!;
        public string District { get; set; } = null!;
        public string Ward { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string? Note { get; set; }
        public string? Phone { get; set; }
        public string? Name { get; set; }
        public User? User { get; set; } = null!;
    }
}