using System;

namespace StudyApp
{

  public interface IWeek
  {
    string ID {get;}
    string WeekID {get;}
    int TotalMinutesStudied {get;}
    int TotalSubjectsStudied {get;}
  }
}