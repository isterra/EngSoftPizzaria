using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DataBaseModels
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("full_name")]
        public string FullName { get; set; }
        
        [Column("cpf")]
        public string Cpf { get; set; }
        
        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("phone")]
        public string Phone { get; set; }

        [Column("zip_code")]
        public string ZipCode { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("number")]
        public string Number { get; set; }

        [Column("complement")]
        public string Complement { get; set; }

        [Column("neighborhood")]
        public string Neighborhood { get; set; }

        [Column("role")]
        public string Role{ get; set; }

    }

}
