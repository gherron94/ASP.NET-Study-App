using StudyApp.Models;
using System.Linq;
using System;

namespace StudyApp.Data
{
  public static class TestData
  {
    public static void Initialize(StudyContext context)
    {
      context.Database.EnsureCreated();


      if (context.Weeks.Any())
      {
        return;   
      }

      var Weeks = new Week[]
      {
        new Week{ID="1", TotalMinutesStudied="1231", TotalSubjectsStudied="30"},
        new Week{ID="2", TotalMinutesStudied="992", TotalSubjectsStudied="20"},
        new Week{ID="3", TotalMinutesStudied="1419", TotalSubjectsStudied="19"},
        new Week{ID="4", TotalMinutesStudied="889", TotalSubjectsStudied="12"},
        new Week{ID="5", TotalMinutesStudied="1191", TotalSubjectsStudied="35"},
        new Week{ID="6", TotalMinutesStudied="1200", TotalSubjectsStudied="29"},
        new Week{ID="7", TotalMinutesStudied="1020", TotalSubjectsStudied="23"},
      };
      foreach (Week w in Weeks)
      {
        context.Weeks.Add(w);
      }
      context.SaveChanges(); 

      var StudyData = new StudyData[]
      {
        new StudyData{ID="1",DayID="1", MinutesStudied=250, SubjectsStudied = 3},
        new StudyData{ID="2",DayID="2", MinutesStudied=150, SubjectsStudied = 2},
        new StudyData{ID="3",DayID="3", MinutesStudied=182, SubjectsStudied = 5},
        new StudyData{ID="4",DayID="4", MinutesStudied=201, SubjectsStudied = 1},
        new StudyData{ID="5",DayID="5", MinutesStudied=119, SubjectsStudied = 6},
        new StudyData{ID="6",DayID="6", MinutesStudied=89, SubjectsStudied = 4},
        new StudyData{ID="7",DayID="7", MinutesStudied=202, SubjectsStudied = 1}
      };
      foreach (StudyData s in StudyData)
      {
        context.StudyData.Add(s);
      }
      context.SaveChanges();
    }
  }
}