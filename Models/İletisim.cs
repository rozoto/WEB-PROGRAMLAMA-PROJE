using System.ComponentModel.DataAnnotations;

namespace webOdev.Models
{
    public class İletisim
    {
        [Key]
        public int mesajID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string country { get; set; }
        public string subject { get; set; }
    }
}
