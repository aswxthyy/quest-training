﻿using System;
using System.Collections.Generic;

namespace OOPSEcho.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;
            
            var client = new TcpClient();
            client.Connect(ip, port);
            Console WriteLine("Connected to server.");

            while (true)
            {
                Console Write("Client : ");
                var message = Console.ReadLine();
                
                byte[] data = Encoding.ASCII.GetBytes(message) ;
                client.GetStream().Write(data, 0, data.Length);
                
                byte[] response = new byte[1024];
                var dataLength = client.GetStream().Read(response, 0, response.Length);
                
                var responseText = Encoding.ASCII.GetString (response, 0, dataLength);
                Console.WriteLine(responseText);
            }
                
        }
      
    }
}
   
