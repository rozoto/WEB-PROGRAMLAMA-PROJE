using System.ComponentModel.DataAnnotations;

namespace odevvv.Models
{
    public class AdminRole
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
