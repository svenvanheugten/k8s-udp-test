using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new UdpClient(new IPEndPoint(IPAddress.Any, 1234));

            Console.WriteLine("Waiting for a client...");

            while(true)
            {
                var sender = new IPEndPoint(IPAddress.Any, 0);
                var data = client.Receive(ref sender);
                Console.WriteLine(DateTimeOffset.Now + " - " + Encoding.ASCII.GetString(data, 0, data.Length));
            }
        }
    }
}
