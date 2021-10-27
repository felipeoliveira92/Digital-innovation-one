using System.ComponentModel.DataAnnotations;

namespace src.Entities
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
    }
}