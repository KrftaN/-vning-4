using System;

namespace Övning_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Malte";
            person.LastName = "Elwhagen";
            person.BirthDate = new DateTime(2006, 1, 18);
            person.Height = 1.91; // meter
            person.Weight = 73; // kilogram

            Console.WriteLine($"Namn: {person.FullName}");
            Console.WriteLine($"Vuxen: {person.IsAdult}");
            Console.WriteLine($"BMI: {person.BMI}");
        }
    }
}