using BulkyWebRazor_Temp.Data;
using BulkyWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Category_Page;

[BindProperties]
public class CreateModel : PageModel
{
    private readonly ApplicationDbContext _db;
    //[BindProperty]
    public Category Category {get; set;}
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
