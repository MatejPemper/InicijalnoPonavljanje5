using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje5._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string uriName ;

            uriName = Console.ReadLine();


            Uri uriResult;
            bool result = Uri.TryCreate(uriName, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            Console.WriteLine("This Url is valid {0}", result);

            Console.ReadKey();

        }
    }
}
