using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Xeynergy_App.Models
{
    public class User : Person
    {
        public virtual UserGroup UserGroup { get; set; }

    }
}
