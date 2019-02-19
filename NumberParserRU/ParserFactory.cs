namespace NumberParserRU
{
    public static class ParserFactory
    {
        public static Parser CreateDefault()
        {
            return new Parser(
                new RulesConfig()
                );
        }

    }
}
