using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule200 : NumberRule
    {
        protected override void Nominative(string gender)
        {
            Add("двести");
        }
        protected override void Genitive(string gender)
        {
            Add("двухсот");
        }
        protected override void Dative(string gender)
        {
            Add("двумстам");
        }
        protected override void Accusative(string gender)
        {
            Add("двести");
        }
        protected override void Instrumental(string gender)
        {
            Add("двумястами");
        }
        protected override void Prepositional(string gender)
        {
            Add("двухстах");
        }
    }
}
