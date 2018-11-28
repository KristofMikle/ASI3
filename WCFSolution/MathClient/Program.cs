using System;
using System.ServiceModel;
using MathTypes;
namespace MathClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IMath mathChannel = new ChannelFactory<IMath>(new BasicHttpBinding(), new EndpointAddress("http://localhost:8080/math")).CreateChannel();
            double sum = mathChannel.Add(1, 2);
            Console.WriteLine("Call via BasicHttpBinding: {0}", sum); Console.WriteLine("Prjess Enter to exit."); Console.ReadLine();
        }
    }
}