using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
public class UserSearchViewModel
{
    public string SearchTerm { get; set; }
    public List<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
}
public class SearchController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;

    public SearchController(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> Index(UserSearchViewModel model)
    {
        var users = _userManager.Users.AsQueryable();

        if (!string.IsNullOrEmpty(model.SearchTerm))
        {
            var searchTerm = model.SearchTerm.Trim().ToLower();

            users = users.Where(u =>
                u.FirstName.ToLower().Contains(searchTerm) ||
                u.LastName.ToLower().Contains(searchTerm) ||
                u.UserName.ToLower().Contains(searchTerm) ||
                u.Email.ToLower().Contains(searchTerm)
            );
        }

        model.Users = await users.OrderBy(u => u.LastName)
                                .ThenBy(u => u.FirstName)
                                .ToListAsync();

        return View(model);
    }
}