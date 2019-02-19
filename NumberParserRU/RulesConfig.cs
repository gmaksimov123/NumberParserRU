using Ninject.Modules;
using NumberParserRU.Rules.Abstract;
using NumberParserRU.Rules.Iterations;
using NumberParserRU.Rules.Numbers;

namespace NumberParserRU
{
    public class RulesConfig : NinjectModule
    {
        public override void Load()
        {
            Bind1_9();
            Bind10_19();
            Bind20_90();
            Bind100_900();
            BindIterations();
        }

        private void Bind1_9()
        {
            Bind<NumberRule>().To<Rule0>().Named("0");
            Bind<NumberRule>().To<Rule1>().Named("1");
            Bind<NumberRule>().To<Rule2>().Named("2");
            Bind<NumberRule>().To<Rule3>().Named("3");
            Bind<NumberRule>().To<Rule4>().Named("4");
            Bind<NumberRule>().To<Rule5_79__30>().Named("5").WithConstructorArgument("root", "пят");
            Bind<NumberRule>().To<Rule5_79__30>().Named("6").WithConstructorArgument("root", "шест");
            Bind<NumberRule>().To<Rule5_79__30>().Named("7").WithConstructorArgument("root", "сем");
            Bind<NumberRule>().To<Rule8>().Named("8").WithConstructorArgument("root", "восьм");
            Bind<NumberRule>().To<Rule5_79__30>().Named("9").WithConstructorArgument("root", "девят");
        }
        private void Bind20_90()
        {
            Bind<NumberRule>().To<Rule5_79__30>().Named("20").WithConstructorArgument("root", "двадцат");
            Bind<NumberRule>().To<Rule5_79__30>().Named("30").WithConstructorArgument("root", "тридцат");
            Bind<NumberRule>().To<Rule40_7090>().Named("40").WithConstructorArgument("root", "сорок");
            Bind<NumberRule>().To<Rule50_70>().Named("50").WithConstructorArgument("root", "пят");
            Bind<NumberRule>().To<Rule50_70>().Named("60").WithConstructorArgument("root", "шест");
            Bind<NumberRule>().To<Rule50_70>().Named("70").WithConstructorArgument("root", "сем");
            Bind<NumberRule>().To<Rule80>().Named("80").WithConstructorArgument("root", "восьм");
            Bind<NumberRule>().To<Rule40_7090>().Named("90").WithConstructorArgument("root", "девяност");
        }
        private void Bind10_19()
        {
            Bind<NumberRule>().To<Rule5_79__30>().Named("10").WithConstructorArgument("root", "десят");
            Bind<NumberRule>().To<Rule5_79__30>().Named("11").WithConstructorArgument("root", "одиннадцат");
            Bind<NumberRule>().To<Rule5_79__30>().Named("12").WithConstructorArgument("root", "двенадцат");
            Bind<NumberRule>().To<Rule5_79__30>().Named("13").WithConstructorArgument("root", "тринадцат");
            Bind<NumberRule>().To<Rule5_79__30>().Named("14").WithConstructorArgument("root", "четырнадцат");
            Bind<NumberRule>().To<Rule5_79__30>().Named("15").WithConstructorArgument("root", "пятнадцат");
            Bind<NumberRule>().To<Rule5_79__30>().Named("16").WithConstructorArgument("root", "шестнадцат");
            Bind<NumberRule>().To<Rule5_79__30>().Named("17").WithConstructorArgument("root", "семнадцат");
            Bind<NumberRule>().To<Rule5_79__30>().Named("18").WithConstructorArgument("root", "восемнадцат");
            Bind<NumberRule>().To<Rule5_79__30>().Named("19").WithConstructorArgument("root", "девятнадцат");
        }
        private void Bind100_900()
        {
            Bind<NumberRule>().To<Rule100>().Named("100").WithConstructorArgument("root", "ст");
            Bind<NumberRule>().To<Rule200>().Named("200");
            Bind<NumberRule>().To<Rule300>().Named("300");
            Bind<NumberRule>().To<Rule400>().Named("400");
            Bind<NumberRule>().To<Rule500_700900>().Named("500").WithConstructorArgument("root", "пят");
            Bind<NumberRule>().To<Rule500_700900>().Named("600").WithConstructorArgument("root", "шест");
            Bind<NumberRule>().To<Rule500_700900>().Named("700").WithConstructorArgument("root", "сем");
            Bind<NumberRule>().To<Rule800>().Named("800").WithConstructorArgument("root", "восьм");
            Bind<NumberRule>().To<Rule500_700900>().Named("900").WithConstructorArgument("root", "девят");
        }

        private void BindIterations()
        {
            Bind<IterationRule>().To<Rule1000>().Named("1000").WithConstructorArgument("gender", "Ж");
            Bind<IterationRule>().To<Rule1000000>().Named("1000000").WithConstructorArgument("gender", "М");
            Bind<IterationRule>().To<Rule1000000000>().Named("1000000000").WithConstructorArgument("gender", "М");
        }
    }
}
