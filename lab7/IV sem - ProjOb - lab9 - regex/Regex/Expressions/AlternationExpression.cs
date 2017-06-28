using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex.Regex.Expressions
{
    class AlternationExpression: IRegexExpression
    {
        private IRegexExpression leftChild;
        private IRegexExpression rightChild;

        public AlternationExpression(IRegexExpression lC, IRegexExpression rC)
        {
            leftChild = lC; rightChild = rC;
        }

        RegexContext IRegexExpression.Match(RegexContext context)
        {
            RegexContext toRetutn = new RegexContext();
            RegexContext leftChildResult = leftChild.Match(context);
            foreach (var el in leftChildResult)
            {
                toRetutn.Add(el);
            }
            RegexContext rightCildResult = rightChild.Match(context);
            foreach (var el in rightCildResult)
            {
                toRetutn.Add(el);
            }
            return toRetutn;
        }

        public override string ToString()
        {
            return leftChild.ToString() + " | " + rightChild.ToString();
        }
    }
}
