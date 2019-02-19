using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule300 : NumberRule
    {
        protected override void Nominative(string gender)
        {
            Add("триста");
        }
        protected override void Genitive(string gender)
        {
            Add("трёхсот");
        }
        protected override void Dative(string gender)
        {
            Add("трёхстам");
        }
        protected override void Accusative(string gender)
        {
            Add("триста");
        }
        protected override void Instrumental(string gender)
        {
            Add("тремястами");
        }
        protected override void Prepositional(string gender)
        {
            Add("трёхстах");
        }
    }
}
