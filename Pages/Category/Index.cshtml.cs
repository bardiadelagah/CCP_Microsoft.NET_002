using BulkyWebRazor_Temp.Data;
using CategoryDbModel = BulkyWebRazor_Temp.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Category;

public class IndexModel : PageModel
{
    private readonly ApplicationDbContext _db;

    public List<CategoryDbModel> CattegoryList {get; set;}
    public IndexModel(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet()
    {
        CattegoryList = _db.Categories.ToList();
    }
}
