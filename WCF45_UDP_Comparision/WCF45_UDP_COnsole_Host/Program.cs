using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF45_UDP_COnsole_Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost Host = new ServiceHost(typeof(WCF45_UPD_Binding_Service.Service));
            Host.Open();
            Console.WriteLine("Service STarted...");
            Console.ReadLine();
            Host.Close();    
            Console.ReadLine();

        }
    }
}
