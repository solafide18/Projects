using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IndoCybreShop.Models.TestCandidate
{
    public class RunningNumber
    {
        public int Year { get; set; }
        public int RunningMonth { get; set; }
        public string Prefix { get; set; }
        public int? CurrentNo { get; set; }
    }
}