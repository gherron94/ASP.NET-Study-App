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


      if (context.Days.Any())
      {
        return;   
      }

      var Days = new DayTest[]
      {
        new DayTest{ID="1",Name="Day 1"},
        new DayTest{ID="2",Name="Day 2"},
        new DayTest{ID="3",Name="Day 3"},
        new DayTest{ID="4",Name="Day 4"},
        new DayTest{ID="5",Name="Day 5"},
        new DayTest{ID="6",Name="Day 6"},
        new DayTest{ID="7",Name="Day 7"},
      };
      foreach (DayTest d in Days)
      {
        context.Days.Add(d);
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