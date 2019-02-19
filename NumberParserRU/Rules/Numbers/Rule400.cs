using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule400 : NumberRule
    {
        protected override void Nominative(string gender)
        {
            Add("четыреста");
        }
        protected override void Genitive(string gender)
        {
            Add("четырёхсот");
        }
        protected override void Dative(string gender)
        {
            Add("четырёхстам");
        }
        protected override void Accusative(string gender)
        {
            Add("четыреста");
        }
        protected override void Instrumental(string gender)
        {
            Add("четырьмястами");
        }
        protected override void Prepositional(string gender)
        {
            Add("четырёхстах");
        }
    }
}
