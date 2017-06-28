using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex.Regex
{
    interface IRegexExpression
    {
        RegexContext Match(RegexContext context);
    }


}
