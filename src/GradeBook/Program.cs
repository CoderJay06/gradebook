using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Jay's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.GetStatistics();
            Console.WriteLine($"Highest grade: {stats.Low}");
            Console.WriteLine($"Lowest grade: {stats.High}");
            Console.WriteLine($"Average grade: {stats.Average:N1}");
        }
    }
}
