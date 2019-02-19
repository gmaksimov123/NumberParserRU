using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule40_7090 : Rule5_79__30
    {
        public Rule40_7090(string root) : base(root) { }
        protected override void Nominative(string gender)
        {
            Add(_root);
        }
        protected override void Genitive(string gender)
        {
            Add(_root + "а");
        }
        protected override void Dative(string gender)
        {
            Add(_root + "и");
        }
        protected override void Accusative(string gender)
        {
            Add(_root);
        }
        protected override void Instrumental(string gender)
        {
            Add(_root + "а");
        }
        protected override void Prepositional(string gender)
        {
            Add(_root + "а");
        }
    }
}
