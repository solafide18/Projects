using System;
using System.ComponentModel.DataAnnotations;

namespace WebCoreTemplate.Models.Databases.MGS
{
    public class order_trans
    {
        [Key]
        public int id { get; set; }

        public string no_trans { get; set; }

        public DateTime? tanggal { get; set; }

        public int? tipe { get; set; }

        public string customer { get; set; }

        public string cust_phone { get; set; }

        public string alamat { get; set; }

        public string keterangan { get; set; }

        public int? created_by { get; set; }

        public DateTime? created_date { get; set; }

    }

}
