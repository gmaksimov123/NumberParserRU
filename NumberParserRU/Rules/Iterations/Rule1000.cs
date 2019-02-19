using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Iterations
{
    public class Rule1000 : IterationRule
    {
        public Rule1000(string gender) : base(gender) { }

        protected override void Nominative(string gender)
        {
            if (Multiple)
            {
                Add("тысячи");
            }
            else
            {
                Add("тысяча");
            }
        }
        protected override void Genitive(string gender)
        {
            if (Multiple)
            {
                Add("тысяч");
            }
            else
            {
                Add("тысячи");
            }
        }
        protected override void Dative(string gender)
        {
            if (Multiple)
            {
                Add("тысячам");
            }
            else
            {
                Add("тысяче");
            }
        }
        protected override void Accusative(string gender)
        {
            if (Multiple)
            {
                Add("тысячи");
            }
            else
            {
                Add("тысячу");
            }
        }
        protected override void Instrumental(string gender)
        {
            if (Multiple)
            {
                Add("тысячами");
            }
            else
            {
                Add("тысячей");
            }
        }
        protected override void Prepositional(string gender)
        {
            if (Multiple)
            {
                Add("тысячах");
            }
            else
            {
                Add("тысяче");
            }
        }
    }
}
