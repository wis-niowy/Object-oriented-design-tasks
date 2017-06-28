using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex.Regex.Expressions
{
    class RepetitionExpression : IRegexExpression
    {
        private IRegexExpression child;

        public RepetitionExpression(IRegexExpression c)
        {
            child = c;
        }

        RegexContext IRegexExpression.Match(RegexContext context)
        {
            var toReturn = new RegexContext();
            var prev = new RegexContext();
            foreach (var el in context)
            {
                toReturn.Add(el);
            }
            while (!toReturn.IsEmpty())
            {
                
                foreach (var el in toReturn)
                {
                    prev.Add(el);
                }
                toReturn = child.Match(toReturn);
            }

            return prev;
        }

        public override string ToString()
        {
            return child.ToString() + "*";
        }
    }
}