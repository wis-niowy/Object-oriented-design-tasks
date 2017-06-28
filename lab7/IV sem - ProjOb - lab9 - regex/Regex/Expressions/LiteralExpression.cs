using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex.Regex.Expressions
{
    class LiteralExpression : IRegexExpression
    {
        string myString;        // pattern to check with context (if context begins with 'myString')
        public LiteralExpression(string s)
        {
            myString = s;
        }

        RegexContext IRegexExpression.Match(RegexContext context)
        {
            RegexContext toReturn = new RegexContext();
            foreach (var element in context)
            {
                if (element.Length < myString.Length) continue;
                string beginning = element.Substring(0, myString.Length);
                if (beginning == myString)
                    toReturn.Add(element.Substring(myString.Length));
            }
            return toReturn;
        }

        public override string ToString()
        {
            return myString;
        }
    }
}