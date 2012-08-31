using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF45_UDP_Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost Host = new ServiceHost(typeof(WCF45_UDPBinding_Service.Service1));
            Host.Open();
            Console.WriteLine("The Service Started...");
            Console.ReadLine();
            Host.Close();
            Console.ReadLine(); 
        }
    }
}
