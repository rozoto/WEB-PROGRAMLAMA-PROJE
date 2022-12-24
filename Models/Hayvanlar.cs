using System.ComponentModel.DataAnnotations;

namespace odevvv.Models
{
    public class Hayvanlar
    {
        [Key]
        public int HayvanID { get; set; }
        public string HayvanName { get; set; }
        public string HayvanIrk { get; set; }
        public int HayvanAgirlik { get; set; }
        public string HayvanCinsiyet { get; set; }
        public int HayvanYas { get; set; }
        public string HayvanCins { get; set; }
        public string Hayvanİmage { get; set; }
    }
}
