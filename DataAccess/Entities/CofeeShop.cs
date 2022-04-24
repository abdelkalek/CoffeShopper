using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DataAccess.Entities
{
    public class CofeeShop
    {
        [Key, Column("id")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string OpeningHours { get; set; }
        public string Address { get; set; }
    }
}
