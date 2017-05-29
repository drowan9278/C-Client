using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;


namespace WindowsFormsApplication1
{
    class server
    {
        public bool connectServer(string Username,string Password)
        {
            Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPHostEntry dnsLook = Dns.Resolve("192.168.0.3");
            IPAddress ipadd = dnsLook.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipadd, 8888);
            Byte[] bytes = new Byte[1024];
            

            try
            {
                sender.Connect(remoteEP);
                Console.WriteLine("Socket Connect to {0}" + sender.RemoteEndPoint.ToString());
                byte[] msg = Encoding.ASCII.GetBytes("This is a test");
                int bytesSent = sender.Send(msg);
                int bytesReceive = sender.Receive(bytes);
                Console.WriteLine("Echoed Test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesReceive));
                sender.Shutdown(SocketShutdown.Both);
                sender.Disconnect(true);
               
                sender.Close();
                Console.WriteLine("Disconnected From Server");
                return true;
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
            return false;
        }
    }
}
