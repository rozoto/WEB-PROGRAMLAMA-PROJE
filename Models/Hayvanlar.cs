using System.ComponentModel.DataAnnotations;

namespace yeni.Models
{
    public class Hayvanlar
    {
        [Key]
        public int HayvanID { get; set; }
        public string HayvanName { get; set; }
        public string HayvanIrk { get; set; }
        public int HayvanYas { get; set; }
    }
}
