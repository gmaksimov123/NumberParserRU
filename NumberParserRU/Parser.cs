using Ninject;
using System;
using Ninject.Parameters;
using Ninject.Modules;
using NumberParserRU.Rules.Abstract;
using System.Collections.Generic;
using NumberParserRU.Rules.Iterations;

namespace NumberParserRU
{
    public class Parser : IDisposable
    {
        private readonly IKernel _kernel;

        public Parser(params INinjectModule[] modules)
        {
            _kernel = new StandardKernel(modules);
        }
        public string SumProp(long nSum, string sGender, string sCase)
        {
            Builder.Reset();
            if (nSum < 0)
            {
                Builder.Add("минус");
            }
            if (nSum == 0)
            {
                GetRule(0).BuildString(sGender, sCase);
            }

            nSum = Math.Abs(nSum);
            int[] numberParts = PrepareNumber(nSum);
            var iterations = numberParts.Length - 1;

            for (var part = iterations; part >= 0; part--)
            {
                DoIteration(numberParts[part], part, sGender, sCase);
            }

            return Builder.Build();
        }

        protected int[] PrepareNumber(long number)
        {
            var list = new List<int>();
            while (number != 0)
            {
                var part = number % 1000;
                number = number / 1000;
                list.Add((int)part);
            }
            return list.ToArray();
        }
        protected void DoIteration(int number, int part, string sGender, string sCase)
        {
            if (number == 0)
            {
                return;
            }
            var iterationRule = GetIteration((long) Math.Pow(1000, part));
            if (part > 0 && iterationRule != null)
            {
                iterationRule.Multiple = number > 1;
                sGender = iterationRule.Gender;
            }
            var power = 0;
            while (number != 0)
            {
                var rule = GetRule(number);
                if (rule == null)
                {
                    var iteration = (int)Math.Pow(10, 2 - power);
                    var currentNumber = (number / iteration) * iteration;
                    if(currentNumber != 0)
                    {
                        rule = GetRule(currentNumber);
                    }
                    power++;
                    number = number % iteration;
                }
                else
                {
                    number = 0;
                }
                rule?.BuildString(sGender, sCase);
            }
            iterationRule?.BuildString(sGender, sCase);
        }
        protected NumberRule GetRule(int item)
        {
            var mImpl = _kernel.TryGet<NumberRule>(item.ToString());
            
            return mImpl;
        }
        protected IterationRule GetIteration(long item)
        {
            var mImpl = _kernel.TryGet<IterationRule>(item.ToString());
            
            return mImpl;
        }
        public void Dispose()
        {
            _kernel.Dispose();
        }
    }

}