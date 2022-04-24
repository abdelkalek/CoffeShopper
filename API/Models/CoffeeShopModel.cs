using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class CoffeeShopModel
    {
        [Key, Column("id")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string OpeningHours { get; set; }
        public string Address { get; set; }
    }
}
