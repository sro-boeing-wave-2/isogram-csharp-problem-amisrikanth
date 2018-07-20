using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace isogram_csharp_problem_amisrikanth
{
    public class Class1
    {
        public static bool Validate(string str)
        {
            string modifiedString = Regex.Replace(str, "[- ]","");
            IEnumerable<char> strNew = modifiedString.ToCharArray().Distinct();

            if (modifiedString.Length == strNew.Count())
            {
                return true;
            }
            return false;

        }
    }
}
