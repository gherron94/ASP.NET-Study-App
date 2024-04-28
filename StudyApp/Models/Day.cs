﻿using System;
using System.Collections.Generic;

namespace StudyApp.Models
{
  public class Day : IDay
  {

    public int Minutes
    {get; set;}
    public int Subjects
    {get; set;}

    public Day(int minutes = 0, int subjects = 0)
    {
      this.Minutes = minutes;
      this.Subjects = subjects;
    }

  }
}
