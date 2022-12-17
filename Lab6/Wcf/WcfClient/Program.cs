using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServer;

namespace WcfClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ChannelFactory<IFileService> channel = new ChannelFactory<IFileService>("http://localhost:9999/FileService");
            //IFileService proxy = channel.CreateChannel();
            //proxy.CreateFile("test", "asdasdadasdasdasdasdasda");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Client started");
            BasicHttpBinding myBinding = new BasicHttpBinding();
            EndpointAddress myEndpoint = new EndpointAddress("http://localhost:9999/FileService");
            ChannelFactory<IFileService> myChannelFactory = new ChannelFactory<IFileService>(myBinding, myEndpoint);
            IFileService client = myChannelFactory.CreateChannel();
            var s =  client.CreateFile("FUCK.txt", "SUKA NAHUI");
            ((IClientChannel)client).Close();
            Console.WriteLine(s.ToString());
            Console.ReadLine();
        }
    }
}
