using OOD_5A1.Regex;
using OOD_5A1.Regex.Exceptions;
using Regex.Regex;
using Regex.Regex.Expressions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            RegexTests();
            ExceptionTests();

            Console.WriteLine("All test cases passed");
        }

        static void RegexTests()
        {
            var parser = new PrefixRegexParser();

            foreach (var test_prefix_expression in ExampleRegexExpression.TestExpressions)
            {
                var regex = parser.Parse(test_prefix_expression.Item1);
                
                var input_context = new RegexContext(test_prefix_expression.Item2);
                var out_context = regex.Match(input_context);

                Console.WriteLine("Regex: {0}", regex.ToString());
                Console.WriteLine("Input: {0}", test_prefix_expression.Item2);
                var match_info = out_context.Matches() ? "Matched!" : "Not Matched!";
                Console.WriteLine(match_info);
                Console.WriteLine("");

                Debug.Assert(out_context.Matches() == test_prefix_expression.Item3);
            }

        }

        static void ExceptionTests()
        {
            var parser = new PrefixRegexParser();

            foreach (var test_prefix_expression in ExampleRegexExpression.TestExceptionExpression)
            {
                bool exception_thrown = false;
                try
                {
                    var expression = parser.Parse(test_prefix_expression);
                }
                catch (SyntaxErrorException)
                {
                    exception_thrown = true;
                    Console.WriteLine("Corrently detected invalid format: {0}", test_prefix_expression);
                }

                Debug.Assert(exception_thrown);
            }
        }
    }
}

