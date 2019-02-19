using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule500_700900 : Rule5_79__30
    {
        public Rule500_700900(string root) : base(root) { }
        protected override void Nominative(string gender)
        {
            Add(_root + "ьсот");
        }
        protected override void Genitive(string gender)
        {
            Add(_root + "исот");
        }
        protected override void Dative(string gender)
        {
            Add(_root + "истам");
        }
        protected override void Accusative(string gender)
        {
            Add(_root + "ьсот");
        }
        protected override void Instrumental(string gender)
        {
            Add(_root + "ьюстами");
        }
        protected override void Prepositional(string gender)
        {
            Add(_root + "истах");
        }
    }
}
