using System;
namespace StudyApp.Models
{
  public class Day
  {

    public int Minutes
    {get; set;}
    public int Subjects
    {get; set;}

    public Day(int minutes, int subjects)
    {
      Minutes = minutes;
      Subjects = subjects;
    }

  }
}
