using BulkyWebRazor_Temp.Data;
using CategoryDbModel = BulkyWebRazor_Temp.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWebRazor_Temp.Pages.Category;

[BindProperties]
public class EditModel : PageModel
{
    private readonly ApplicationDbContext _db;
    //[BindProperty]
    public CategoryDbModel Category {get; set;}
    public EditModel(ApplicationDbContext db)
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

    public IActionResult OnPost() {//Category obj
       if (ModelState.IsValid){
            _db.Categories.Update(Category);
            _db.SaveChanges();
            TempData["success"] =  "Category update successfully";
            return RedirectToPage("Index");
        }
        return Page();
    }
}
