using System.IO;

namespace collections
{
    class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string csvFilePath)
        {
            this._csvFilePath = csvFilePath;
        }

        public People[] GetPeople(int numberOfPeople)
        {
            People[] people = new People[numberOfPeople];

            using (StreamReader sr = new StreamReader(_csvFilePath))
            {
                sr.ReadLine();

               for (int i = 0; i < numberOfPeople; i++)
                {
                    people[i] = ReadPeopleFromCsvLine(sr.ReadLine());
                }
            }
            
            return people;
        }

        public People ReadPeopleFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(new char[] { ',' });

            int id = int.Parse(parts[0]);
            string firstName = parts[1];
            string lastName = parts[2];
            string email = parts[3];
            string gender = parts[4];
            string ipAdress = parts[5];

            return new People(id, firstName, lastName, email, gender, ipAdress);
            
        }
    }
}