using System;
using System.Collections.Generic;
using System.Text;

namespace NumberParserRU.Rules.Abstract
{
    public abstract class NumberRule
    {
        protected void Add(string s)
        {
            Builder.Add(s);
        }

        public void BuildString(string sGender, string sCase)
        {
           sGender = sGender.ToLower();
           switch (sCase.ToLower())
            {
                case "и":
                    Nominative(sGender);
                    break;
                case "р":
                    Genitive(sGender);
                    break;
                case "д":
                    Dative(sGender);
                    break;
                case "в":
                    Accusative(sGender);
                    break;
                case "т":
                    Instrumental(sGender);
                    break;
                case "п":
                    Prepositional(sGender);
                    break;
                default:
                    throw new Exception("Unsupported case");
            }
        }

        /// <summary>
        /// Преобразует число в текст в именительном падеже
        /// </summary>
        /// <param name="number"></param>
        protected abstract void Nominative(string gender);
        /// <summary>
        /// Преобразует число в текст в родительном падеже
        /// </summary>
        /// <param name="number"></param>
        protected abstract void Genitive(string gender);
        /// <summary>
        /// Преобразует число в текст в дательном падеже
        /// </summary>
        /// <param name="number"></param>
        protected abstract void Dative(string gender);
        /// <summary>
        /// Преобразует число в текст в винительном падеже
        /// </summary>
        /// <param name="number"></param>
        protected abstract void Accusative(string gender);
        /// <summary>
        /// Преобразует число в текст в творительном падеже
        /// </summary>
        /// <param name="number"></param>
        protected abstract void Instrumental(string gender);
        /// <summary>
        /// Преобразует число в текст в предложном падеже
        /// </summary>
        /// <param name="number"></param>
        protected abstract void Prepositional(string gender);

        //private object ConvertCase(string sCase)
        //{
        //    switch (sCase.ToLower())
        //    {
        //        case "и":
        //            return NumberCase.Nominative;
        //        case "р":
        //            return NumberCase.Genitive;
        //        case "д":
        //            return NumberCase.Dative;
        //        case "в":
        //            return NumberCase.Accusative;
        //        case "т":
        //            return NumberCase.Instrumental;
        //        case "п":
        //            return NumberCase.Prepositional;
        //        default:
        //            throw new Exception("Unsupported case");
        //    }
        //}
        //private Gender ConvertGender(string sGender)
        //{
        //    switch (sGender.ToLower())
        //    {
        //        case "м":
        //            return Gender.Male;
        //        case "ж":
        //            return Gender.Female;
        //        case "c":
        //            return Gender.Neuter;
        //        default:
        //            throw new Exception("Unsupported gender");
        //    }
        //}
    }
}
