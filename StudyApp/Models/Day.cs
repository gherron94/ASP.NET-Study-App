using System;
using System.Collections.Generic;

namespace StudyApp.Models
{
  public class Day
  {

    public int Minutes
    {get; set;}
    public int Subjects
    {get; set;}

    public Day(int minutes = 0, int subjects = 0)
    {
      Minutes = minutes;
      Subjects = subjects;
    }

  }
}
