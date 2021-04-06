using System.ComponentModel.DataAnnotations;

namespace WebCoreTemplate.Models.Databases.MGS
{
    public class leveluser
    {
        [Key]
        public int id { get; set; }

        public string level_desc { get; set; }

    }

}
