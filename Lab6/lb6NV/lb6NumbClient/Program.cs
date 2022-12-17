using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using NumbInterfaces;
namespace lb6NumbClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Enter number to convert");
            num = Convert.ToInt32(Console.ReadLine());
            ChannelFactory<INumbService> channel = new ChannelFactory<INumbService>("NumbServiceEndpoint");
            INumbService proxy = channel.CreateChannel();
            //Console.ReadLine();
            string res = proxy.Convert(num);
            Console.WriteLine("Res = " + res);
            Console.ReadLine();
        }
    }
}
