using System;

namespace StudyApp
{

  public interface IStudyData
  {
    string ID {get;}
    string DayID {get;}
    int MinutesStudied {get;}
    int SubjectsStudied {get; }
  }
}