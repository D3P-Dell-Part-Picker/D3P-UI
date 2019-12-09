using System;
using System.Collections.Generic;
using System.Linq;

using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DellPartPicker
{
    class SocketComms
    {

        /*static void Main(string[] args)
        {
            sendMessage("test");
        }*/

        public static void sendMessage(String message, String addr, int port)
        {
            try
            {

                IPAddress ipAddr = IPAddress.Parse(addr);
                IPEndPoint iPEndPoint = new IPEndPoint(ipAddr, port);

                Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.Connect(iPEndPoint);
                    
                    Console.WriteLine("Socket connected to -> {0} ", sender.RemoteEndPoint.ToString());

                    byte[] messageSent = Encoding.ASCII.GetBytes(message);
                    int byteSent = sender.Send(messageSent);


                    sender.Shutdown(SocketShutdown.Both);

                    


                    

                    

                    sender.Close();

                }

                catch(ArgumentNullException ane)
                {
                    Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
                }

                catch(SocketException se) {

                    Console.WriteLine("SocketException : {0}", se.ToString());
                }

                catch (Exception e)
                {
                    Console.WriteLine("Unexpected exception : {0}", e.ToString());
                }
            }

            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
        }
    }
}
