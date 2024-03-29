namespace OracleGroupAssignment.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public bool IsHidde {  get; set; }
        public int MenuTypeId { get; set; }
        public string? MenuName { get; set; }
        public string? ItemDescription { get; set;}
        public float SalePrice { get; set; }

    }
}
