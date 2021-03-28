using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace week3b
{
    class Client
    {
        private Socket sender;
        private IPAddress iPAddress;
        private IPEndPoint remoteEP;

        public Client()
        {

            iPAddress = IPAddress.Parse("192.168.1.28");
            remoteEP = new IPEndPoint(iPAddress, 8000);

        }

        public bool OpenConnection()
        {
            sender = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            IAsyncResult result = sender.BeginConnect(iPAddress, 8000, null, null);

            bool success = result.AsyncWaitHandle.WaitOne(5000, true);

            if (sender.Connected)
            {
                return true;
            }
            else
            {
                sender.Close();
                return false;
            }
        }
        public void CloseConnection()
        {
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
        public void Send(string msg)
        {
            byte[] m = Encoding.ASCII.GetBytes(msg);
            try
            {
                sender.Send(m);

            }
            catch
            {
                throw new Exception("ERROR SENDING");
            }

        }
        public string Receive()
        {
            byte[] bytes = new byte[1024];
            try
            {
                int bytesRec = sender.Receive(bytes);

                return Encoding.ASCII.GetString(bytes, 0, bytesRec).Split('>')[1] + " c";
            }
            catch
            {
                throw new Exception("ERROR RECEIVING");
            }
        }
    }
}
