using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule3 : NumberRule
    {
        protected override void Nominative(string gender)
        {
            Add("три");
        }
        protected override void Genitive(string gender)
        {
            Add("трёх");
        }
        protected override void Dative(string gender)
        {
            Add("трём");
        }
        protected override void Accusative(string gender)
        {
            Add("три");
        }
        protected override void Instrumental(string gender)
        {
            Add("тремя");
        }
        protected override void Prepositional(string gender)
        {
            Add("трёх");
        }
    }
}
