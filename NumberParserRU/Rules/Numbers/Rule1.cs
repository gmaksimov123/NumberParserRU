using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberParserRU.Rules.Abstract;

namespace NumberParserRU.Rules.Numbers
{
    public class Rule1 : NumberRule
    {
        protected override void Nominative(string gender)
        {
            switch (gender)
            {
                case "м":
                    Add("один");
                    break;
                case "ж":
                    Add("одна");
                    break;
                case "c":
                    Add("одно");
                    break;
            }
        }
        protected override void Genitive(string gender)
        {
            switch (gender)
            {
                case "c":
                case "м":
                    Add("одного");
                    break;
                case "ж":
                    Add("одной");
                    break;
            }
        }
        protected override void Dative(string gender)
        {
            switch (gender)
            {
                case "c":
                case "м":
                    Add("одному");
                    break;
                case "ж":
                    Add("одной");
                    break;
            }
        }
        protected override void Accusative(string gender)
        {
            switch (gender)
            {
                case "м":
                    Add("один");
                    break;
                case "ж":
                    Add("одну");
                    break;
                case "c":
                    Add("одно");
                    break;
            }
        }



        protected override void Instrumental(string gender)
        {
            switch (gender)
            {
                case "c":
                case "м":
                    Add("одним");
                    break;
                case "ж":
                    Add("одной");
                    break;
            }
        }


        protected override void Prepositional(string gender)
        {
            switch (gender)
            {
                case "c":
                case "м":
                    Add("одном");
                    break;
                case "ж":
                    Add("одной");
                    break;
            }
        }
    }
}
