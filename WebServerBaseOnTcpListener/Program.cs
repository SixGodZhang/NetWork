using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WebServerBaseOnTcpListener
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ipAddress = IPAddress.Loopback;

            IPEndPoint endPoint = new IPEndPoint(ipAddress, 49155);

            TcpListener tcpListener = new TcpListener(endPoint);

            tcpListener.Start();
            Console.WriteLine("Wait an connect Request...");

            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();
                if (tcpClient.Connected == true)
                {
                    Console.WriteLine("Created connection...");
                }

                NetworkStream networkStream = tcpClient.GetStream();
                byte[] buffer = new byte[2048];

                int receiveLength = networkStream.Read(buffer,0,2048);
                string requestString = Encoding.UTF8.GetString(buffer, 0, receiveLength);

                Console.WriteLine("request: " + requestString);

                string statusLine = "HTTP/1.1 200 OK\r\n";
                byte[] responseStatusLineBytes = Encoding.UTF8.GetBytes(statusLine);
                string responseBody = "<html><head><title>Default Page</title></head><body><p style='font:bold;font-size:24pt'>Welcome you! Base On TcpListener</p></body></html>";
                string responseHeader = string.Format("Content-Type:text/html;charset=UTF-8\r\nContent-Length:{0}\r\n", responseBody.Length);

                byte[] responseHeaderBytes = Encoding.UTF8.GetBytes(responseHeader);
                byte[] responseBodyBytes = Encoding.UTF8.GetBytes(responseBody);


                networkStream.Write(responseStatusLineBytes, 0, responseStatusLineBytes.Length);
                networkStream.Write(responseHeaderBytes, 0, responseHeaderBytes.Length);
                networkStream.Write(new byte[] { 13, 10 }, 0, 2);

                networkStream.Write(responseBodyBytes, 0, responseBodyBytes.Length);

                tcpClient.Close();
                Console.ReadKey();
                break;
            }

            tcpListener.Stop();
        }
    }
}
