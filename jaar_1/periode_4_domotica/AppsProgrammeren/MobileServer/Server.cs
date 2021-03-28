﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MobileServer
{
    public class Server
    {
        public static Random temperatureGenerator = new Random();
        public static string data = null;
        public static void StartListening()
        {
            byte[] bytes = new byte[1024];
            IPAddress ipAddress = IPAddress.Parse("141.252.209.92");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10); 
                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");
                    Socket handler = listener.Accept();
                    data = null;
                    while (true)
                    {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        Console.WriteLine("Data " + data);
                        if (data.IndexOf("<TEMP>") > -1)
                        {
                            break;
                        }
                    }
                    Console.WriteLine("Text received : {0}", data);
                    byte[] msg = Encoding.ASCII.GetBytes("<TEMP>" + temperatureGenerator.Next(19, 26));
                    handler.Send(msg);
                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("\nPress ENTER to continue...");
            Console.Read();
        }
    }
}
