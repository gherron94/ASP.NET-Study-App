using System;

namespace StudyApp.Models
{
  public class StudyData : IStudyData
  {
    public string ID
    {get; set;}
    public string DayID
    {get; set;}
    public int MinutesStudied
    {get; set;}
    public int SubjectsStudied
    {get; set;}
  }
}
