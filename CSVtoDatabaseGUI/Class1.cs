using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVtoDatabaseGUI
{
    public enum Class1
    {
        tab, comma, pipe
    }
    public static class Something
    {
        private static Dictionary<Class1, char> dicktionary = new Dictionary<Class1, char>()
        {
            {Class1.tab, "/t"[0]}
        };
        public static char gimmeChar(this Class1 c)
        {
            char t = dicktionary[c];

            return t;
        }
    }
}
