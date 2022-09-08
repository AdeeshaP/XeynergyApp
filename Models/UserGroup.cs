using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Xeynergy_App.Models
{
    public class UserGroup
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Column("GroupName")]
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
