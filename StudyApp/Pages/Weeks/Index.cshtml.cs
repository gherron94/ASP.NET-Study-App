using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudyApp.Models;
using StudyApp.Data;

namespace StudyApp.Pages.Weeks
{
  public class IndexModel : PageModel
  {
    private readonly StudyContext _context;

    public IndexModel(StudyContext context)
    {
      _context = context;
    }
    
    public List<Week> Week { get; set; }
    
    public async Task OnGetAsync()
    {
      Week = await _context.Weeks.ToListAsync();
    }
  }
}