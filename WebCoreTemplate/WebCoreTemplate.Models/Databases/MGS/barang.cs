using System;
using System.ComponentModel.DataAnnotations;

namespace WebCoreTemplate.Models.Databases.MGS
{
    public class barang
    {
        [Key]
        public int id { get; set; }

        public string kode_barang { get; set; }

        public string nama_barang { get; set; }

        public int? harga_beli { get; set; }

        public int? harga_jual { get; set; }

        public int? tipe { get; set; }

        public int? created_by { get; set; }

        public DateTime? created_date { get; set; }

    }

}
