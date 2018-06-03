using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods {
    public static class ExtensionString {

        public static string FirstToUpper(this String str) {

            string FirstLetter = str.Substring(0, 1);
            string SecondLetter = str.Substring(1);

            return FirstLetter.ToUpper() + SecondLetter;
        }
    }
}
