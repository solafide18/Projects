using System.ComponentModel.DataAnnotations;

namespace WebCoreTemplate.Models.Databases.MGS
{
    public class tipe_trans
    {
        [Key]
        public int id { get; set; }

        public string nama_tipe { get; set; }

    }

}
