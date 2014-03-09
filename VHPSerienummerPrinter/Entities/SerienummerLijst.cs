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

        public int? StartIndex { get; set; }
        public int? EindIndex { get; set; }

        public string Item1Label { get; set; }
        public string Item2Label { get; set; }
        public string Item3Label { get; set; }
        public string Item4Label { get; set; }

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
            //er is geen selectie gemaakt voor het eerste label dat moet worden geprint: neem het eerste label in de lijst
            if (!StartIndex.HasValue  )
                StartIndex = 0;

            //er is geen selectie gemaakt voor het laatste label dat moet worden geprint: neem het laatste label in de lijst
            if (!EindIndex.HasValue)
                EindIndex = _labels.Count - 1;

            List<SerienummerInfo> list = new List<SerienummerInfo>();
            for (int index = StartIndex.GetValueOrDefault(); index <= EindIndex.GetValueOrDefault(); index++)
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

        public void AddSerienummer(string jaar, string batch, string volgNummer, string item1, string item2, string item3, string item4)
        {
            _labels.Add(new SerienummerInfo(jaar, batch, volgNummer, item1, item2, item3, item4));
        }
    }
}
