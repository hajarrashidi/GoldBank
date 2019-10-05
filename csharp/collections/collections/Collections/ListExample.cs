using System;
using System.Collections.Generic;

namespace collections
{
    public class ListExample
    {
        public ListExample()
        {
            List<string> daysOfWeek = new List<string>
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            List<int> ints = new List<int>();
            
            string filePath = @"/Users/hajarrashidi/repos/goldbank/csharp/collections/collections/MOCK_DATA.csv";

            CsvReader reader = new CsvReader(filePath);

            List<People> people = reader.GetAllPeople();

            foreach(People p in people)
            {
                Console.WriteLine($"{p.FirstName} - {p.Email}");
            }
        }
    }
}