using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models {
    [Table("Stadiums")]
    public class Stadium {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Location { get; set; }
        [MaxLength(50)]
        public string ImageUrl { get; set; }
        public DateTime DateOfFound { get; set; }
        public string Desc { get; set; }
        public string Histoty { get; set; }
    }
}
