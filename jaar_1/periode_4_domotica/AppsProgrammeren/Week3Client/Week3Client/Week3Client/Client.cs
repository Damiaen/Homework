using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Week3Client
{
    class Client
    {
        private Socket sender;

        public void OpenConnection()
        {
            try
            {
                IPAddress ipAddress = IPAddress.Parse("192.168.1.11");
                IPEndPoint endPoint = new IPEndPoint(ipAddress, 11000);

                sender = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                sender.Connect(endPoint);
                Console.WriteLine("Connection established");
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException ", e.Data);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception ", e.Data);
            }

        }
    
        public void CloseConnection()
        {
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }

        private void Send(string message)
        {

            int startTickCount = Environment.TickCount;

            if (Environment.TickCount > startTickCount + 1000)
                throw new Exception("Timeout.");
            try
            {
                byte[] msg = Encoding.ASCII.GetBytes(message);
                sender.Send(msg);
            }
            catch (SocketException ex)
            {
                if (ex.SocketErrorCode == SocketError.WouldBlock ||
                    ex.SocketErrorCode == SocketError.IOPending ||
                    ex.SocketErrorCode == SocketError.NoBufferSpaceAvailable)
                {
                    // socket buffer is probably full, wait and try again
                    Thread.Sleep(30);
                }
                else
                    Console.WriteLine(ex);  // any serious error occurr
            }
            
        }

        public string Recieve()
        {
            int startTickCount = Environment.TickCount;
            byte[] buffer = new byte[256];
            string msg = "<TEMP>";

            if (Environment.TickCount > startTickCount + 1000)
                throw new Exception("Timeout.");
            try
            {
                Send(msg);
                int bytesRec = sender.Receive(buffer);
                return Encoding.ASCII.GetString(buffer, 0, bytesRec).Split('>')[1] + " °C";
            }
            catch (SocketException ex)
            {
                if (ex.SocketErrorCode == SocketError.WouldBlock ||
                    ex.SocketErrorCode == SocketError.IOPending ||
                    ex.SocketErrorCode == SocketError.NoBufferSpaceAvailable)
                {
                    // socket buffer is probably empty, wait and try again
                    Thread.Sleep(30);
                }
                else
                    Console.WriteLine(ex);  // any serious error occurr
                    return null;
            }

        }
    }
}
