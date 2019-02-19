using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule800 : Rule500_700900
    {
        public Rule800(string root) : base(root) { }
        protected override void Nominative(string gender)
        {
            Add("восемьсот");
        }
        protected override void Accusative(string gender)
        {
            Add("восемьсот");
        }
        protected override void Instrumental(string gender)
        {
            Add("восемьюстами");
        }
    }
}
