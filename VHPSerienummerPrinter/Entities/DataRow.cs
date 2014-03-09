
namespace VHPSerienummerPrinter.Entities
{
    public class DataRow
    {
        public string Jaar { get; set; }
        public string Batch { get; set; }
        public string VolgNummer { get; set; }
        public string  Item1{ get; set; }
        public string  Item2{ get; set; }
        public string  Item3{ get; set; }
        public string  Item4{ get; set; }

      

        public DataRow(string jaar, string batch, string volgnummer, string item1, string item2, string item3, string item4)
        {
            Jaar = jaar;
            Batch = batch;
            VolgNummer = volgnummer;
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
        }
    }
}
