using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    [Table("ShoppingCart")]

    public class ShoppingCart
    {
        public int Id { get; set; }


        [Required] public int CartId { get; set; }
        public string UserId { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}