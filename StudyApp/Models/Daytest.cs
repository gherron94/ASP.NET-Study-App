using System;

namespace StudyApp.Models
{
  public class DayTest
  {

    public string ID
    {get; set;}
    public string Name
    {get; set;}

    public Day(int minutes = 0, int subjects = 0)
    {
      this.Minutes = minutes;
      this.Subjects = subjects;
    }

  }
}
