using OOD_5A1.Regex.Exceptions;
using Regex.Regex;
using Regex.Regex.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_5A1.Regex
{
    class PrefixRegexParser
    {
        public IRegexExpression Parse(string prefix_regex)
        {
            // Your Code here
            List<string> parsedList = prefix_regex.Split(new[] {' ' }).ToList();
            IRegexExpression root = recursiveParse(parsedList);

            return root;

            //throw new NotImplementedException();
        }

        private IRegexExpression recursiveParse(List<string> parsedList)
        {
            if (parsedList.Count == 2)
            {
                if (parsedList[0] == "|" || parsedList[0] == "&" || parsedList[0] == "*" ||
                    parsedList[1] == "|" || parsedList[1] == "&" || parsedList[1] == "*")
            }
            string currPiece = parsedList[0];
            parsedList.RemoveAt(0);
            switch (currPiece)
            {
                case "|":
                    return new AlternationExpression(recursiveParse(parsedList), recursiveParse(parsedList));
                    //break;
                case "&":
                    return new SequenceExpression(recursiveParse(parsedList), recursiveParse(parsedList));
                    //break;
                case "*":
                    return new RepetitionExpression(recursiveParse(parsedList));
                //break;
                default:
                    return new LiteralExpression(currPiece);
                    //break;
            }
        }
    }
}
