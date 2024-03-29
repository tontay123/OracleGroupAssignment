namespace OracleGroupAssignment.Models
{
    public class InvoiceDetail
    {
        public int InvoiceDetailId {  get; set; }
        public int Invoiceid { get; set;}
        public int MenuId { get; set; }
        public float OrderQuantity {  get; set; }

        public float OrderPrice { get; set; }
        public float Discount { get; set; }
    }
}
