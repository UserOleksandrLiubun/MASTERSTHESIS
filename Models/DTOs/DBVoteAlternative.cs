using System.ComponentModel.DataAnnotations;

public class DBVoteAlternative
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = SharedResource.RequireMessage)]
    public int DBVoteId { get; set; }
    public string Title { get; set; }
}