using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudyApp.Models;
using StudyApp.Data;

namespace StudyApp.Pages.StudyDay
{
  public class IndexModel : PageModel
  {
    private readonly StudyContext _context;

    public IndexModel(StudyContext context)
    {
      _context = context;
    }
    
    public List<StudyData> StudyData { get; set; }
    
    public async Task OnGetAsync()
    {
      StudyData = await _context.StudyData.ToListAsync();
    }

    public async Task<IActionResult> OnPostAsync(string id)
    {
      if (id == null)
      {
        return NotFound();
      }

      StudyData StudyData = await _context.StudyData.FindAsync(id);

      if (StudyData != null)
      {
        _context.StudyData.Remove(StudyData);
      }

      await _context.SaveChangesAsync();

      return RedirectToPage("./Index");
    }
  }
}