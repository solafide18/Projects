using System;
using System.ComponentModel.DataAnnotations;

namespace WebCoreTemplate.Models.Databases.TestCandidate
{
    public class Categories
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int? UpperCategory { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Active { get; set; }
    }
}
