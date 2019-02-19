using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule0 : NumberRule
    {
        protected override void Nominative(string gender)
        {
            Add("ноль");
        }
        protected override void Genitive(string gender)
        {
            Add("ноля");
        }
        protected override void Dative(string gender)
        {
            Add("нолю");
        }
        protected override void Accusative(string gender)
        {
            Add("ноль");
        }

        protected override void Instrumental(string gender)
        {
            Add("нолём");
        }
        
        protected override void Prepositional(string gender)
        {
            Add("ноле");
        }
    }
}
