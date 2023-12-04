using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Category_Page;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _db;

    public List<Category> CattegoryList {get; set;}
    public IndexModel(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet()
    {
        CattegoryList = _db.Categories.ToList();
    }
}
