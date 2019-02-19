using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule80 : Rule50_70
    {
        public Rule80(string root) : base(root) { }
        protected override void Nominative(string gender)
        {
            Add("восемьдесят");
        }
        protected override void Accusative(string gender)
        {
            Add("восемьдесят");
        }
    }
}
