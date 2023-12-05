using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2._20_Getters_and_Setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Titanic", "Jim", "PG-13");
            Movie movie2 = new Movie("Unreleased", "Evens", "PG");

            Console.WriteLine(movie1.rating);
            Console.ReadKey();
        }
    }
}
