using BulkyWebRazor_Temp.Data;
using CategoryDbModel = BulkyWebRazor_Temp.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Category;

[BindProperties]
public class DeleteModel : PageModel
{
    private readonly ApplicationDbContext _db;
    //[BindProperty]
    public CategoryDbModel Category {get; set;}
    public DeleteModel(ApplicationDbContext db)
    {
        _db = db;
    }

    public void OnGet(int? id)
    {
        if(id !=null && id != 0)
        {
            Category = _db.Categories.Find(id);
        }
    }

    public IActionResult OnPost()
    {
          
        CategoryDbModel? obj  = _db.Categories.Find(Category.Id);
        if (obj == null)
        {
            return NotFound();
        }
        _db.Categories.Remove(obj);
        _db.SaveChanges();
        TempData["success"] =  "Category Delete successfully";
        return RedirectToPage("Index");
    }
}
