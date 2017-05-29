using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;


namespace ConsoleApplication1
{
    class tcpListen
    {
        public static string data;
        public void tcpListener()
        {
            Console.WriteLine("Starting Server...");
            byte[] bytes = new Byte[1024];

            IPHostEntry iphostInfo = Dns.Resolve(Dns.GetHostName());
            IPAddress ipAddress = iphostInfo.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 8888);
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                Console.WriteLine("Starting to listen");
                listener.Bind(localEndPoint);
                listener.Listen(10);
                Socket handler = listener.Accept();
                data = null;
                Console.WriteLine("start to recieve listen");
                while (true)
                {
                    Console.WriteLine("No connection currently");
                    System.Threading.Thread.Sleep(500);
                    bytes = new Byte[1024];
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("<EOF>") > -1)
                        break;
                }
                Console.WriteLine("Data Recieved: {0}", data);
                byte[] msg = Encoding.ASCII.GetBytes(data);

                handler.Send(msg);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
                 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.WriteLine("Done listening, press key to listen again");
            Console.Read();

        }
    }
}
