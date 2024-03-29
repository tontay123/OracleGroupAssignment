namespace OracleGroupAssignment.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }  
        public bool IsHidden { get; set; }
        public int CustomerId { get; set; }

        public DateTime OderDate { get; set; }
        public float VAT {  get; set; }
        public string? Memo { get; set; }
        public bool IsPaid { get; set; }
    }
}
