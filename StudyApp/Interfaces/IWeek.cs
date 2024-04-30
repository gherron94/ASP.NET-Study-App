using System;

namespace StudyApp
{

  public interface IWeek
  {
    string ID {get; set;}
    string WeekID {get; set;}
    int TotalMinutesStudied {get; set;}
    int TotalSubjectsStudied {get; set;}
  }
}