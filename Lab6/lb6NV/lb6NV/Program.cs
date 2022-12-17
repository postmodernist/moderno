using System;
using System.ServiceModel;

namespace lb6NV
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(NumbService)))
            {
                host.Open();
                Console.WriteLine("Server started");
                Console.WriteLine("Press any button to stop");
                Console.ReadLine();
            }
        }
    }
}
