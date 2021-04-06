using System;
using System.ComponentModel.DataAnnotations;

namespace WebCoreTemplate.Models.Databases.MGS
{
    public class petty_cash
    {
        [Key]
        public int id { get; set; }

        public string no_trans { get; set; }

        public DateTime? tanggal { get; set; }

        public int? tipe { get; set; }

        public int? id_order_trans { get; set; }

        public int? debet { get; set; }

        public int? kredit { get; set; }

        public string keterangan { get; set; }

        public int? created_by { get; set; }

        public DateTime? created_date { get; set; }

    }

}
