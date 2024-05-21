using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace APIE_WPF.csvclasses
{
    public class CsvImporter
    {
        public static List<CsvMapAnimals> ImportSomeRecords(string fileName)
        {
            var myRecords = new List<CsvMapAnimals>();
            using (var reader = new StreamReader(fileName))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<CsvMapper>();

                    int currentID;
                    string name;
                    string gender;
                    string animalType;
                    int age;

                    //Start Reading Csv File
                    csv.Read();
                    //Skip Header
                    csv.ReadHeader();

                    while (csv.Read())
                    {
                        currentID = csv.GetField<int>(0);
                        name = csv.GetField<string>(1);
                        gender = csv.GetField<string>(2);
                        animalType = csv.GetField<string>(3);
                        age = csv.GetField<int>(4);
                        myRecords.Add(CreateRecord(currentID, name, gender, animalType, age));
                    }

                }

            }
            return myRecords;
        }

        public static CsvMapAnimals CreateRecord(int id, string name, string gender, string animalType, int age)
        {
            CsvMapAnimals record = new CsvMapAnimals();

            record.id = id;
            record.name = name;
            record.gender = gender;
            record.animalType = animalType;
            record.age = age;

            return record;
        }
    }
}
