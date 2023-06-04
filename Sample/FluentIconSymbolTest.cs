using FluntIcon;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class FluentIconSymbolTest
    {
        public string Name { get; set; }
        public string Glyph { get; set; }
        public FluentIconSymbol Symbol { get; set; }
        public FluentIconSymbolTest(FluentIconSymbol symbol)
        {
            this.Symbol = symbol;
            this.Name = symbol.ToString();
            this.Glyph = ((char)symbol).ToString();
        }
    }
}
