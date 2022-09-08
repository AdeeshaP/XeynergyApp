using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Xeynergy_App.Models
{
    public class Person
    {
        public int PersonID { get; set; }

        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Column("LastName")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required]
        [Column("Email")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        public string GetFullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
