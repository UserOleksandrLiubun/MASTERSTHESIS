using CHOICE.Models.DTOs;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<DBTask> Tasks { get; set; }
    public DbSet<DBContact> Contacts { get; set; }
    public DbSet<DBVote> DBVotes { get; set; }
    public DbSet<DBVoteItemSettings> DBVoteItemSettings { get; set; }
    public DbSet<DBVoteItem> DBVoteItems { get; set; }
    public DbSet<DBVoteAlternative> DBVoteAlternative { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
}