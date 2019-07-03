
using System.ComponentModel.DataAnnotations;

namespace GraniteHouse_MySQL.Models
{
    public class SpecialTags
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
