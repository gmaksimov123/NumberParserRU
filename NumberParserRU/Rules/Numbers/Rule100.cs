using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule100 : Rule40_7090
    {
        public Rule100(string root) : base(root) { }
        protected override void Nominative(string gender)
        {
            Add("сто");
        }
    }
}
