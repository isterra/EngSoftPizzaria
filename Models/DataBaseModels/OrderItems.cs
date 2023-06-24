using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DataBaseModels
{
    [Table("order_items")]
    public class OrderItems
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("menu_id")]
        [ForeignKey(nameof(Menu))]
        public int MenuId { get; set; }

        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
