using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace yeni.Models
{
    public class Admin
    {
        public int AdminID { get; set; }

        [Column(TypeName = "VarChar(20)")]
        public string? Kullanici { get; set; }
        [Column(TypeName = "VarChar(10)")]
        public string? Sifre { get; set; }
    }
}
