using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odevvv.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [Column(TypeName = "VarChar(20)")]
        public string? Kullanici { get; set; }
        [Column(TypeName = "VarChar(10)")]
        public string? Sifre { get; set; }
    }
}
