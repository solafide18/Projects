using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCoreTemplate.Models.Databases.TestCandidate
{
    public class RunningNumber
    {
        public int Year { get; set; }
        public int RunningMonth { get; set; }
        public string Prefix { get; set; }
        public int? CurrentNo { get; set; }
    }
}
