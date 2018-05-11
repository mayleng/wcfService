using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Contracts;
using System.Threading;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (ChannelFactory<ICalculator> channelFactory = new ChannelFactory<ICalculator>("calculatorservice"))
            //{
            //    ICalculator proxy = channelFactory.CreateChannel();
            //    using (proxy as IDisposable)
            //    {
            //        Console.WriteLine("x + y = {2} when x = {0} and y = {1}", 1, 2, proxy.Add(1, 2));
            //        Console.WriteLine("x - y = {2} when x = {0} and y = {1}", 1, 2, proxy.Subtract(1, 2));
            //        Console.WriteLine("x * y = {2} when x = {0} and y = {1}", 1, 2, proxy.Multiply(1, 2));
            //        Console.WriteLine("x / y = {2} when x = {0} and y = {1}", 1, 2, proxy.Divide(1, 2));
            //    }
            //}

            GetName();
            GetNameAsync();

            Console.ReadLine();
        }

        private static void GetName()
        {
            using (ChannelFactory<PersonService.WcfService> channelFactory = new ChannelFactory<PersonService.WcfService>("WSHttpBinding_WcfService"))
            {
                PersonService.WcfService proxy = channelFactory.CreateChannel();
                using (proxy as IDisposable)
                {
                    Thread.Sleep(20);
                    Console.WriteLine(proxy.getName("myName by sync"));
                }
            }
        }

        private async static void GetNameAsync()
        {
            using (ChannelFactory<PersonService.WcfService> channelFactory = new ChannelFactory<PersonService.WcfService>("WSHttpBinding_WcfService"))
            {
                PersonService.WcfService proxy = channelFactory.CreateChannel();
                using (proxy as IDisposable)
                {
                    Thread.Sleep(20);
                    string res = await proxy.getNameAsync("myName by async Test");
                    Console.WriteLine(res);
                }
            }            
        }
    }
}
