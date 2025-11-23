using System.ComponentModel.DataAnnotations;

namespace CHOICE.Models.DTOs
{
    public class DBVoteAlternative
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DBVoteId { get; set; }
        public string Title { get; set; }
    }
}
