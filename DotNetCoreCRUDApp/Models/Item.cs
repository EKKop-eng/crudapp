
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreApp.Models
{
    public class Item
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}
