namespace IndoCybreShop.Models.ViewModels
{
    public class OrderDetailViews
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public long UnitPrice { get; set; }
        public long TotalPrice { get; set; }
        public short Quantity { get; set; }
        public int Discount { get; set; }
    }
}