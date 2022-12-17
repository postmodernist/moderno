﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(FileService)))
            {
                host.Open();
                Console.WriteLine("Server started");
                Console.WriteLine("Press any key to stop");
                Console.ReadLine();
            }
        }
    }
}
