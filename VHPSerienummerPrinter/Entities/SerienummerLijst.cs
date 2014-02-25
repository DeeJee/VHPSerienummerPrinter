using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHPSerienummerPrinter
{
    public class SerienummerLijst
    {
        public bool PrintCeLogo { get; set; }
        public string LogoImage { get; set; }
     
        public string Product { get; set; }

        public int StartIndex { get; set; }
        public int EindIndex { get; set; }

        private List<SerienummerInfo> _labels;
        public List<SerienummerInfo> Labels
        {
            get
            {
                return _labels;
            }
            set { _labels = value; }
        }

        private List<SerienummerInfo> _selectie;
        public List<SerienummerInfo> SelectedLabels
        {
            get
            {
                //TODO: herschrijven. Deze code wordt veel te vaak uitgevoerd.
                //if (_selectie == null)
                    BepaalSelectie();

                return _selectie;
            }
        }

        private void BepaalSelectie()
        {
            //geen selectie gemaakt: alles uitprinten
            if (StartIndex == -1 && EindIndex == -1)
            {
                _selectie= _labels;
            }

            //er is geen selectie gemaakt voor het eerste label dat moet worden geprint: neem het eerste label in de lijst
            if (StartIndex == -1)
                StartIndex = 0;

            //er is geen selectie gemaakt voor het laatste label dat moet worden geprint: neem het laatste label in de lijst
            if (EindIndex == -1)
                EindIndex = _labels.Count - 1;

            List<SerienummerInfo> list = new List<SerienummerInfo>();
            for (int index = StartIndex; index <= EindIndex; index++)
            {
                SerienummerInfo info = _labels[index];
                list.Add(info);
            }
            _selectie = list; ;
        }

        public SerienummerLijst()
        {
            Labels = new List<SerienummerInfo>();
        }

        public void AddSerienummer(string jaar, string batch, string volgNummer, string serienummer, string Product, string firmware, string type)
        {
            _labels.Add(new SerienummerInfo(jaar, batch, volgNummer, serienummer, Product, firmware, type));
        }

        public void AddSerienummer(string jaar, string batch, string volgNummer, 
            string label1, string item1,
            string label2, string item2,
            string label3, string item3,
            string label4, string item4)
        {
            _labels.Add(new SerienummerInfo(jaar, batch, volgNummer, 
                        new KeyValuePair<string,string>(label1, item1),
                        new KeyValuePair<string, string>(label2, item2),
                        new KeyValuePair<string, string>(label3, item3),
                        new KeyValuePair<string, string>(label4, item4)));
        }
    }
}
