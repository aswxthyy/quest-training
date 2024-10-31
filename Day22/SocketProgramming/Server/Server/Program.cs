using System;
using System.Net;
using System.Net.Sockets;

namespace SocketProgramming.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;

            var listener = new TcpListener(ip, port);
            listener.Start();
            System.Console.WriteLine($"App is listening on {ip} : {port}");

            Socket socket = listener.AcceptSocket();
            System.Console.WriteLine("Client connected");

            var buffer = new byte[1024];
            var dataLength = socket.Receive(buffer);
            string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
            System.Console.WriteLine($"Message : {message}");

            socket.Close();
            listener.Stop();
        }
    }
}