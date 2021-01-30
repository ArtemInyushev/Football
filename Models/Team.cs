using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models {
    [Table("Teams")]
    public class Team {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public ushort Trophies { get; set; }
        public string Desc { get; set; }
        [MaxLength(50)]
        public string ImageUrl { get; set; }
        public int StadiumId { get; set; }
    }
}