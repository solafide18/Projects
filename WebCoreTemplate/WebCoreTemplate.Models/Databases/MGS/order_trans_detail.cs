using System.ComponentModel.DataAnnotations;

namespace WebCoreTemplate.Models.Databases.MGS
{
    public class order_trans_detail
    {
        [Key]
        public int id { get; set; }

        public int? id_order_trans { get; set; }

        public int? tipe { get; set; }

        public int? id_barang { get; set; }

        public int? id_stock { get; set; }

        public int? qty { get; set; }

        public int? debet { get; set; }

        public int? kredit { get; set; }

        public int? total { get; set; }

        public string keterangan { get; set; }

        public int? sts { get; set; }

    }

}
