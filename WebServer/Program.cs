using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    class Program
    {
        static void Main(string[] args)
        {   
            IPAddress iPAddress = IPAddress.Loopback;
            IPEndPoint endPoint = new IPEndPoint(iPAddress, 49155);

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            socket.Bind(endPoint);
            socket.Listen(10);

            while (true)
            {
                Console.WriteLine("Wait an connect Request...");
                Socket clientSocket = socket.Accept();

                Console.WriteLine("Client Address is:{0}",clientSocket.RemoteEndPoint);
                byte[] buffer = new byte[2048];

                int receiveLength = clientSocket.Receive(buffer, 2048, SocketFlags.None);
                string requestString = Encoding.UTF8.GetString(buffer, 0, receiveLength);

                Console.WriteLine("request: " + requestString);

                string statusLine = "HTTP/1.1 200 OK\r\n";
                byte[] responseStatusLineBytes = Encoding.UTF8.GetBytes(statusLine);
                string responseBody = "<html><head><title>Default Page</title></head><body><p style='font:bold;font-size:24pt'>Welcome you!</p></body></html>";
                string responseHeader = string.Format("Content-Type:text/html;charset=UTF-8\r\nContent-Length:{0}\r\n", responseBody.Length);

                byte[] responseHeaderBytes = Encoding.UTF8.GetBytes(responseHeader);
                byte[] responseBodyBytes = Encoding.UTF8.GetBytes(responseBody);

                clientSocket.Send(responseStatusLineBytes);
                clientSocket.Send(responseHeaderBytes);
                clientSocket.Send(new byte[] { 13, 10 });
                clientSocket.Send(responseBodyBytes);

                clientSocket.Close();
                Console.ReadKey();
                break;
            }

            socket.Close();

        }
    }
}
