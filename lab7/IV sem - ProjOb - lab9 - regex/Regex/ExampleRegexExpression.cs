using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_5A1.Regex
{
    static class ExampleRegexExpression
    {
        // <Regex, Input, Is Matched>
        public static Tuple<string, string, bool>[] TestExpressions =
        {
            new Tuple<string, string, bool>("MiNI", "MiNI", true),
            new Tuple<string, string, bool>("MiNI", "PW", false),
            new Tuple<string, string, bool>("MiNI", "MiNI PW", false),

            new Tuple<string, string, bool>("| MiNI PW", "MiNI", true),
            new Tuple<string, string, bool>("| MiNI PW", "PW", true),
            new Tuple<string, string, bool>("| MiNI PW", "MiNI PW", false),

            new Tuple<string, string, bool>("& MiNI PW", "MiNI", false),
            new Tuple<string, string, bool>("& MiNI PW", "PW", false),
            new Tuple<string, string, bool>("& MiNI PW", "MiNIPW", true),

            new Tuple<string, string, bool>("* MiNI", "MiNI", true),
            new Tuple<string, string, bool>("* MiNI", "MiNIMiNIMiNI", true),
            new Tuple<string, string, bool>("* MiNI", "MiNIMiNIMiNIMiNIMiNIMiNI", true),
            new Tuple<string, string, bool>("* MiNI", "MiNIMiNIMiNIPW", false),

            new Tuple<string, string, bool>("& id: * | | 1 2 3", "id:1", true),
            new Tuple<string, string, bool>("& id: * | | 1 2 3", "id:2", true),
            new Tuple<string, string, bool>("& id: * | | 1 2 3", "id:3", true),
            new Tuple<string, string, bool>("& id: * | | 1 2 3", "id:1232", true),
            new Tuple<string, string, bool>("& id: * | | 1 2 3", "id:4", false),
            new Tuple<string, string, bool>("& id: * | | 1 2 3", "i:2", false),

        };

        public static List<string> TestExceptionExpression = new List<string>
        {
            "|",
            "&",
            "*",
            "& MiNI",
            "| MiNI",
            "| MiNI MiNI MiNI",
        };
    }
}
