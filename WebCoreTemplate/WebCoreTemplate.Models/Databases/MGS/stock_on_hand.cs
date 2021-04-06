using System;
using System.ComponentModel.DataAnnotations;

namespace WebCoreTemplate.Models.Databases.MGS
{
    public class stock_on_hand
    {
        [Key]
        public int id { get; set; }

        public int? userid { get; set; }

        public int? id_barang { get; set; }

        public int? qty { get; set; }

        public int? created_by { get; set; }

        public DateTime? created_date { get; set; }

    }

}
