using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IndoCybreShop.Models.TestCandidate
{
    [Table("Order Details")]
    public class OrderDetails
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 Quantity { get; set; }
        public int Discount { get; set; }
    }
}