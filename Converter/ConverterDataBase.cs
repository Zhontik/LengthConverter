using System;
using System.Collections.Generic;
using System.Text;

namespace Converter
{
    public class ConverterDataBase
    {
        public Dictionary<string, double> fromMetresTo = new Dictionary<string, double>(8);

        public ConverterDataBase()
        {
            fromMetresTo.Add("km", 0.001d);
            fromMetresTo.Add("m", 1);
            fromMetresTo.Add("dm", 10);
            fromMetresTo.Add("cm", 100);
            fromMetresTo.Add("mm", 1000);

            fromMetresTo.Add("inch", (1d/0.0254d));
            fromMetresTo.Add("foot", fromMetresTo["inch"] * 12 );
            fromMetresTo.Add("yard", fromMetresTo["foot"] * 3 );

        }
    }
}
