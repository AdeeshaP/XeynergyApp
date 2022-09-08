using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Xeynergy_App.Models
{
    public class AccessRule
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        [Column("RuleName")]
        [Display(Name = "Rule Name")]
        public string RuleName { get; set; }

        [Required]
        [Column("Permission")]
        [Display(Name = "Permission")]
        public bool Permission { get; set; }

        public List<User> GetUserNameList(bool permission)
        {
            List<User> userList = new List<User>();

            if (permission)
            {
                User user = new User();
                userList.Add(user);
                return userList;
            }

            return userList;
        }
        public virtual ICollection<UserGroup> UserGroups { get; set; }

    }
}
