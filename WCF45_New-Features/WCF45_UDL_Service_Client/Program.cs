using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF45_UDL_Service_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any Key when Service Start");
            Console.ReadLine();
            MyRef.Service1Client Proxy = new MyRef.Service1Client();
            var Res = Proxy.GetData(100);
            Console.WriteLine("Result " + Res);
            Console.ReadLine(); 

        }
    }
}
