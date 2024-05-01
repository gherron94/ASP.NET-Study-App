using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudyApp.Models;
using StudyApp.Data;

namespace StudyApp.Pages.Weeks
{
  public class EditModel : PageModel
  {
    private readonly StudyContext _context;
 
    public EditModel(StudyContext context)
    {
      _context = context;
    }
    
    [BindProperty]
    public Week Week { get; set; }
    
    public async Task<IActionResult> OnGetAsync(string id)
    {
      if (id == null)
      {
        Week = new Week();
      }
      else
      {
        Week = await _context.Weeks.FindAsync(id);

        if (Week == null)
        {
          return NotFound();
        }
      }
      return Page();
    }
    
    public async Task<IActionResult> OnPostAsync(string id)
    {
      if (!ModelState.IsValid)
      {
        return Page();
      }
      
            if (id == null)
      {
        _context.Weeks.Add(Week);
      }
      else
      {
        _context.Attach(Week).State = EntityState.Modified;
      }

      await _context.SaveChangesAsync();
      
      return RedirectToPage("./Index");
    }
  }
}