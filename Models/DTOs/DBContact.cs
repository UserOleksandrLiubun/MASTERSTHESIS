using System.ComponentModel.DataAnnotations;

namespace CHOICE.Models.DTOs
{
    public class DBContact
    {
        [Key]
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ContactUserId { get; set; }
        public bool IsAccepted { get; set; }
    }
}
