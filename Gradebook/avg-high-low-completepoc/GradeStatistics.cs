using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades1
{
    class GradeBook
    {

       public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AvgGrade = sum / grades.Count;
  
            return stats;
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);     
        }

    
    List<float> grades = new List<float>();
    }
}