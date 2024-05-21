using CsvHelper.Configuration;

namespace APIE_WPF.csvclasses
{
    public sealed class CsvMapper : ClassMap<CsvMapAnimals>
    {
        public CsvMapper()
        {
            Map(m => m.id).Index(0);
            Map(m => m.name).Index(1);
            Map(m => m.gender).Index(2);
            Map(m => m.animalType).Index(3);
            Map(m => m.age).Index(4);
        }
    }
}
