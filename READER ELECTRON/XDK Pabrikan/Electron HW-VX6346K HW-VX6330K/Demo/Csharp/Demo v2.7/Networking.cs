using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace HwVx6330K
{
    class Networking
    {
        public Socket socket;
        
        public IPEndPoint ipEndPoint;
        public EndPoint endPoint;

        private void Init(IPAddress ipAddress)
        {
            socket = new Socket(AddressFamily.InterNetwork,
                SocketType.Dgram,
                ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket,
                SocketOptionName.Broadcast,
                1);
            socket.ReceiveTimeout = 1000;

            ipEndPoint = new IPEndPoint(ipAddress, 65535);
            endPoint = ipEndPoint;
        }
        public Networking(IPAddress ipAddress)
        {
            Init(ipAddress);
        }

        public Networking(string ipString)
        {
            var ipAddress = IPAddress.Parse(ipString);
            Init(ipAddress);
        }

        public class SearchResult
        {
            public string macAddress;
            public string portNumber;
            public string ipAddress;
            public string username;
            public string deviceName;
        }

        public void sendRequest(string command)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(command);
            socket.SendTo(buffer, ipEndPoint);
        }

        public string receive()
        {
            string receivedUdpString;
            byte[] buffer1 = new byte[1000];

            try
            {
                int receivedCount = socket.ReceiveFrom(buffer1,
                       ref endPoint);
                receivedUdpString = Encoding.ASCII.GetString(buffer1, 0, receivedCount);
            }
            catch (Exception ex)
            {
                Console.Write("Ex: " + ex);
                receivedUdpString = "";
            }
            return receivedUdpString;
        }

        public string requestSingle(string command, string check)
        {
            var reply = request(command + "|" + check, 5)
                .Split('|');
            if (reply.Length == 2 && reply[1] == check)
            {
                return reply[0];
            }
            throw new Exception("[" + command + "] ~> " + reply);
        }

        public string request(string request, int retry)
        {
            for (int i=0; i<retry; ++i)
            {
                sendRequest(request);
                string reply = receive();
                if (reply.Length > 0 && reply[0] == 'A')
                {
                    reply = reply.Substring(1);
                    Console.WriteLine(request + "-> " + reply);
                    return reply;
                }
            }
            throw new Exception("Request: " + request);
        }

        public List<SearchResult> SearchForReaders()
        {
            sendRequest("X");
            
            var searchResults = new List<SearchResult>();

            for (int i = 0; i < 255; i++)
            {
                string receivedUdpString = receive();
                if (receivedUdpString.Length==0
                    || receivedUdpString.Substring(0, 1) != "A")
                {
                    break;
                }
                var result = new SearchResult();
                char[] separator = { '/' };
                string[] splitString = receivedUdpString.Split(separator,
                    StringSplitOptions.RemoveEmptyEntries);

                result.macAddress = splitString[0].Substring(1);
                result.portNumber = splitString[1];
                result.ipAddress = endPoint.ToString()
                    .Substring(0, endPoint.ToString().IndexOf(':'));

                if (4 < splitString.Length)
                {
                    result.username = splitString[4];
                    result.deviceName = splitString[5];
                }
                searchResults.Add(result);
            }

            return searchResults;
        }
    }
}
