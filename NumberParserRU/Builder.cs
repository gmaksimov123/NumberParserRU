using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberParserRU
{
    public static class Builder
    {
        private static List<string> storage = new List<string>();

        public static void Add(string part)
        {
            storage.Add(part);
        }
        public static string Build()
        {
            return string.Join(" ", storage);
        }
        public static void Reset()
        {
            storage.Clear();
        }
    }
}
