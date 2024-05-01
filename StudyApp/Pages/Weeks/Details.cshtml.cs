using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudyApp.Models;
using StudyApp.Data;

namespace StudyApp.Pages.Weeks
{
  public class DetailModel : PageModel
  {
    private readonly StudyContext _context;

    public DetailModel(StudyContext context)
    {
      _context = context;
    }

    public Week Week { get; set; }

    public async Task<IActionResult> OnGetAsync(string id)
    {
      Week = await _context.Weeks.FindAsync(id);

      if (Week == null)
      {
        return NotFound();
      }

      return Page();
    }
  }
}