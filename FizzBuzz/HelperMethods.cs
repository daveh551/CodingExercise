using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web;
using System.Web.UI;

namespace FizzBuzz
{
    public static class HelperMethods
    {
        public static void WebOutput(HttpResponse outPage, int m, int n)
        {
            WebOutput(new HttpResponseWrapper(outPage), m, n );
        }
        public static void WebOutput(HttpResponseBase outPage, int m, int n)
        {

            outPage.Write(StringOutput(m,n, "<br>"));
        }

        public static void ConsoleOut(TextWriter outSream, int m, int n)
        {
            outSream.Write(StringOutput(m,n, Environment.NewLine));
        }

        public static string StringOutput( int m, int n, string separator)
        {
            StringBuilder sb = new StringBuilder(100);
              for (int ix = m; ix <= n; ix++)
            {
               sb.Append(string.Format("{0}{1}", Fizzer(ix), separator)); 
            }
            return sb.ToString();
        }
        public static string Fizzer(int input)
        {
            if (input % 15 == 0) return "FizzBuzz";  // if divisible by 3 AND 5 then it's divisible by 15
            if (input % 5 == 0) return "Buzz";
            if (input % 3 == 0) return "Fizz";
            return input.ToString();
        }
    }
}
