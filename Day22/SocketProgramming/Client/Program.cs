using System;
using System.Net;
using System.Net.Sockets;

namespace SocketProgramming.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;

            var client = new TcpClient();
            client.Connect(ip, port);
            System.Console.WriteLine("Connected to server");

            string message = "A";
            byte data = Encoding.ASCII.GetBytes(message);

            client.GetStream().Write(data, 0, data.Length);
            System.Console.WriteLine("Message sent");
        }
    }
}