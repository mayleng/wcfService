using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using Contracts;
using Services;
using System.Threading;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            //{
            //    host.Opened += delegate
            //    {
            //        Console.WriteLine("CalculaorService已经启动，按任意键终止服务！");
            //    };

            //    host.Open();
            //    Console.Read();
            //}

            using (ServiceHost host = new ServiceHost(typeof(PersonService)))
            {
                host.Opened += delegate
                {
                    Thread.Sleep(20);
                    Console.WriteLine("PersonService已经启动，按任意键终止服务！**");
                };

                host.Open();
                Console.Read();
            }
        }
    }
}