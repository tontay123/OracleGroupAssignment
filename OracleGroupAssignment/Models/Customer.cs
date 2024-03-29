namespace OracleGroupAssignment.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public bool IsHidden { get; set; }
        public bool IsDefault { get; set; }
        public string? CustomerName { get; set; }
        public string? CompanyName { get; set;}
        public string? Phone { get; set;}
        public string? Email { get; set; }
        public string? Address { get; set; }
    }
}
