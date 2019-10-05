using System;
namespace collections
{
    public class ArrayExample
    {
        public ArrayExample()
        {
            #region Basic Array
            // Array statment
            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            
            // Iterate
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            var indexOfTheDay = 0;
            // Show one element
            Console.WriteLine($"First day of the week is {daysOfWeek[indexOfTheDay]}");

            // Modifiy an array
            // - Replace 
            var mondayInSwedish = daysOfWeek[indexOfTheDay] = "Måndag";
            Console.Write($"Monday in swedish: ${mondayInSwedish}");
            #endregion

            Console.WriteLine("-- NEW REGION --");

            #region CSV
            string filePath = @"/Users/hajarrashidi/repos/goldbank/csharp/collections/collections/MOCK_DATA.csv";

            CsvReader reader = new CsvReader(filePath);

            People[] people = reader.GetPeople(1000);

            foreach(People p in people)
            {
                Console.WriteLine(p.FirstName);
            }


            #endregion
        }
    }
}
