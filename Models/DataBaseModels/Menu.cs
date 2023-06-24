using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DataBaseModels
{
    [Table("menu")]
    public class Menu
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("image")]
        public string Image { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("price")]
        public double Price { get; set; }

        [Column("is_combo")]
        public bool IsCombo { get; set; }

    }
}
