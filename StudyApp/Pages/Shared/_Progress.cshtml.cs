using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudyApp.Pages
{
  public class ProgressTrackerModel : PageModel
  {
    public string Background { get; set; }
    public string Foreground { get; set; }
    public double PercentProgress { get; set; }
    public double DisplayNumber { get; set; }
    public double MinutesTarget { get; set;}
    public string Unit { get; set; }
    public string IconUrl { get; set; }
  }
}