using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new UdpClient("udp-test-server", 1234);
            
            while (true)
            {
                var bytes = Encoding.ASCII.GetBytes("Hello from " + Dns.GetHostName());

                try
                {
                    client.Send(bytes, bytes.Length);
                }
                catch (Exception)
                {
                    Console.WriteLine(DateTimeOffset.Now + " - Failed to send");
                }

                Thread.Sleep(1000);
            }
        }
    }
}
