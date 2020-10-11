using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Jay's Grade Book");
            var userInput = "";
            do
            {
                Console.Write("Please enter a grade (q to quit) >> ");
                userInput = Console.ReadLine();
                if (userInput != "q")
                    try
                    {
                        book.AddGrade(Convert.ToDouble(userInput));
                    }
                    catch(ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch(FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("");
                    }
            } while (userInput != "q");
            

            var stats = book.GetStatistics();

            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"Highest grade: {stats.Low}");
            Console.WriteLine($"Lowest grade: {stats.High}");
            Console.WriteLine($"Average grade: {stats.Average:N1}");
            Console.WriteLine($"The letter is {stats.Letter}");
        }
    }
}
