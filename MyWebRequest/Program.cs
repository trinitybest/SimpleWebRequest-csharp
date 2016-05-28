using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyWebRequest myRequest = new MyWebRequest("http://seekingalpha.com/article/3978334-historic-race-investors-focusing-dividends-may-run-fuel", "GET");
            Console.WriteLine(myRequest.GetResponse());
            Console.ReadLine();
        }
    }
}
