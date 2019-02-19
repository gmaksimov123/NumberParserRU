using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule8 : Rule5_79__30
    {
        public Rule8(string root) : base(root) { }
        protected override void Nominative(string gender)
        {
            Add("восемь");
        }
        protected override void Accusative(string gender)
        {
            Add("восемь");
        }
    }
}
