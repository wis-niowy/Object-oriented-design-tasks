using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex.Regex.Expressions
{
    class SequenceExpression: IRegexExpression
    {
        private IRegexExpression leftChild;
        private IRegexExpression rightChild;

        public SequenceExpression(IRegexExpression lC, IRegexExpression rC)
        {
            leftChild = lC; rightChild = rC;
        }

        RegexContext IRegexExpression.Match(RegexContext context)
        {
            var leftChildResult = leftChild.Match(context);
            var rightChildResult = rightChild.Match(leftChildResult);
            return rightChildResult;
        }

        public override string ToString()
        {
            return leftChild.ToString() + " & " + rightChild.ToString();
        }
    }
}