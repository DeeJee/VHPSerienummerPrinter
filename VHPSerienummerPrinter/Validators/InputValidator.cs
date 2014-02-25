using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHPSerienummerPrinter.Validators
{
    class InputValidator : IValidator
    {
        string _van;
        string _tot;

        #region IValidator Members
        public InputValidator(string van, string tot)
        {
            _van = van;
            _tot = tot;
        }
        public bool Validate()
        {
            if(_van!=null && _tot !=null && _van.CompareTo(_tot)>0)
            {
                Messages.Add("'Van' moet voor 'tot en met' liggen");
                return false;
            }

            return true;
        }

        private List<string> _messages = new List<string>();
        public List<string> Messages
        {
            get { return _messages; }
            set { _messages = value; }
        }

        #endregion
    }
}
