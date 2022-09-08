using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Xeynergy_App.Models
{
    public class Admin : Person
    {
        [Required]
        [Column("Privileges")]
        [Display(Name = "Privilege")]
        public string Privilege { get; set; }
    }
}
