using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule4 : NumberRule
    {
        protected override void Nominative(string gender)
        {
            Add("четыре");
        }
        protected override void Genitive(string gender)
        {
            Add("четырёх");
        }
        protected override void Dative(string gender)
        {
            Add("четырём");
        }
        protected override void Accusative(string gender)
        {
            Add("четыре");
        }
        protected override void Instrumental(string gender)
        {
            Add("четырьмя");
        }
        protected override void Prepositional(string gender)
        {
            Add("четырёх");
        }
    }
}
