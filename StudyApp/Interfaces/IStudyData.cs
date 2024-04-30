using System;

namespace StudyApp
{

  public interface IStudyData
  {
    string ID
    {get; set;}
    string DayID
    {get; set;}
    int MinutesStudied
    {get; set;}
    int SubjectsStudied
    {get; set;}
  }
}