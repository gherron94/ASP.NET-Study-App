using System;

namespace StudyApp.Models
{
  public class Week : IWeek
  {

    public string ID
    {get; set;}
    public string WeekID
    {get; set;}
    public int TotalMinutesStudied
    {get; set;}
    public int TotalSubjectsStudied
    {get; set;}

  }
}
