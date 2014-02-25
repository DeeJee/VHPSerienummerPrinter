using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VHPSerienummerPrinter.Validators
{
    interface IValidator
    {
        bool Validate();
        List<string> Messages { get; set; }
    }
}
