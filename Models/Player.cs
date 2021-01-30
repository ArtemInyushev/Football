using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models {
    [Table("Players")]
    public class Player {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Position { get; set; }
        [Required]
        public DateTime Age { get; set; }
        [MaxLength(50)]
        public string Biography { get; set; }
        [MaxLength(50)]
        public string ImageUrl { get; set; }
        public int TeamId { get; set; }
    }
}
