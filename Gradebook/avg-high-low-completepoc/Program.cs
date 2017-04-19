using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades1
{
    class Program
    {
        static void Main(string[] args)
        {

            //constructer
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(53);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("the avg grade is: " + stats.AvgGrade);
            Console.WriteLine("the highest grade is: " + stats.HighestGrade);
            Console.WriteLine("the lowest grade is: " + stats.LowestGrade);
            Console.ReadLine();


        }

    }
    

}
