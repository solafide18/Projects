using System.ComponentModel.DataAnnotations;

namespace WebCoreTemplate.Models.Databases.MGS
{
    public class user_login
    {
        [Key]
        public int id { get; set; }

        public string username { get; set; }

        public string pasword { get; set; }

        public string userfullname { get; set; }

        public int? leveluser { get; set; }

    }

}
