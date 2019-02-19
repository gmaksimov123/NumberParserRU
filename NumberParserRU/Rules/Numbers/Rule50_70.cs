using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule50_70 : Rule5_79__30
    {
        public Rule50_70(string root) : base(root) { }
        protected override void Nominative(string gender)
        {
            Add(_root + "ьдесят");
        }
        protected override void Genitive(string gender)
        {
            Add(_root + "идесяти");
        }
        protected override void Dative(string gender)
        {
            Add(_root + "идесяти");
        }
        protected override void Accusative(string gender)
        {
            Add(_root + "ьдесят");
        }
        protected override void Instrumental(string gender)
        {
            Add(_root + "ьюдесятью");
        }
        protected override void Prepositional(string gender)
        {
            Add(_root + "идесяти");
        }
    }
}
