using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule5_79__30 : NumberRule
    {
        protected string _root;
        public Rule5_79__30(string root)
        {
            _root = root;
        }

        protected override void Nominative(string gender)
        {
            Add(_root + "ь");
        }
        protected override void Genitive(string gender)
        {
            Add(_root + "и");
        }
        protected override void Dative(string gender)
        {
            Add(_root + "и");
        }
        protected override void Accusative(string gender)
        {
            Add(_root + "ь");
        }
        protected override void Instrumental(string gender)
        {
            Add(_root + "ью");
        }
        protected override void Prepositional(string gender)
        {
            Add(_root + "и");
        }
    }
}
