using BulkyWebRazor_Temp.Data;
using CategoryDbModel = BulkyWebRazor_Temp.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Category;

[BindProperties]
public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _db;
    //[BindProperty]
    public CategoryDbModel Category {get; set;}
    public CreateModel(ApplicationDbContext db)
    {
        _db = db; //
    }

    public void OnGet()
    {
    }

    public IActionResult OnPost() {//Category obj
        _db.Categories.Add(Category);//obj
        _db.SaveChanges();
        TempData["success"] =  "Category Create successfully";
        return RedirectToPage("Index");
    }
}
