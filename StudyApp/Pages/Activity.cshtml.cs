using System;
using System.Collections.Generic;
using System.Runtime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyApp.Models;

namespace StudyApp.Pages
{
    
  public class ActivityModel : PageModel
  {

    public List<Day> Days = new List<Day>
    {
      new Day(),
      new Day(200, 4),
      new Day(110, 3),
      new Day(195, 5),
      new Day(210, 2), 
      new Day(57, 1),
      new Day(350, 5),
      new Day(179, 3) 
    };


    public double Target { get; set;}
    public int CurrentDisplayDay { get; set; }
    public int DisplayMinutes { get; set; }
    public int DisplaySubjects { get; set; }
    public double DisplayWeeklyTarget {get; set;}
    public bool IsWeeklyDisplay { get; set; }


    public double PercentProgressMinutes { get; set; }

    public IActionResult OnGet(int? day)
    {
      Target = 200;
      if (day.HasValue)
      {
        CurrentDisplayDay = day.Value;
        DisplayMinutes = Days[0].Minutes;
        DisplaySubjects = Days[0].Subjects;
        if (day >= Days.Count || day < 0)
        {
          return NotFound();
        }
        else if (day == 0)
        {
          return Redirect("/Days/1");
        }
        else  
        {
          DisplayMinutes = Days[day.Value].Minutes;
          DisplaySubjects = Days[day.Value].Subjects;
          PercentProgressMinutes = PercentProgress(DisplayMinutes, Target);
        }
      }
      else
      {
        CurrentDisplayDay = 0;
        IsWeeklyDisplay = true;
        DisplayMinutes = Days.Sum(p => p.Minutes);
        DisplaySubjects = Days.Sum(p => p.Subjects);
        DisplayWeeklyTarget = Target * Days.Count - Target;
        PercentProgressMinutes = PercentProgress(DisplayMinutes, Target * Days.Count);
      }
        return Page();
    }
    
    private static double PercentProgress(double actual, double expected)
    {
      return Math.Clamp(actual / expected, 0, 1);
    }
  }
}
    
  

 