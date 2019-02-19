using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule2 : NumberRule
    {
        protected override void Nominative(string gender)
        {
            switch (gender)
            {
                case "c":
                case "м":
                    Add("два");
                    break;
                case "ж":
                    Add("две");
                    break;
            }
        }
        protected override void Genitive(string gender)
        {
            Add("двух");
        }
        protected override void Dative(string gender)
        {
            Add("двум");
        }
        protected override void Accusative(string gender)
        {
            switch (gender)
            {
                case "c":
                case "м":
                    Add("два");
                    break;
                case "ж":
                    Add("две");
                    break;
            }
        }
        protected override void Instrumental(string gender)
        {
            Add("двумя");
        }


        protected override void Prepositional(string gender)
        {
            Add("двух");
        }
    }
}
