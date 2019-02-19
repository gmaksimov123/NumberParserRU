using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Abstract
{
    public abstract class IterationRule : NumberRule
    {
        public string Gender { get; set; }
        public bool Multiple { get; set; }
        public IterationRule(string gender)
        {
            Gender = gender;
        }
    }
}
