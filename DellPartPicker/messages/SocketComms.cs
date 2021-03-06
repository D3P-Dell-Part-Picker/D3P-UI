﻿using System;
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

        
        public static void sendMessage(String message, String ip, int port, Destination d)
        {

            try
            {
                if(d == Destination.localServer)
                {
                    ip = Constants.LOCAL_SERVER;
                }else if(d == Destination.remoteServer)
                {
                    ip = Constants.REMOTE_SERVER;
                }else if(d == Destination.inputted)
                {

                }
                else
                {
                    throw new System.ArgumentException("incorrectly entered option for field");
                }
                // Establish the remote endpoint  
                // for the socket. This example  
                // uses port 11111 on the local  
                // computer. 
                
                IPAddress ipAddr = IPAddress.Parse(ip);
                IPEndPoint localEndPoint = new IPEndPoint(ipAddr, port);

                // Creation TCP/IP Socket using  
                // Socket Class Costructor 
                Socket sender = new Socket(ipAddr.AddressFamily,
                           SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    sender.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, 1);
                    // Connect Socket to the remote  
                    // endpoint using method Connect() 
                    sender.Connect(localEndPoint);
                    
                    // We print EndPoint information  
                    // that we are connected 
                    Console.WriteLine("Socket connected to -> {0} ",
                                  sender.RemoteEndPoint.ToString());

                    // Creation of messagge that 
                    // we will send to Server 
                    Console.WriteLine(message);
                    
                    byte[] messageSent = Encoding.ASCII.GetBytes(message);

                    byte[] newValues = new byte[messageSent.Length + 3];
                    newValues[0] = 0x00;
                    newValues[1] = 0x00;
                    newValues[2] = 0x00;
                    
                    // set the prepended value
                    Array.Copy(messageSent, 0, newValues, 3, messageSent.Length);

                    int byteSent = sender.Send(newValues);

                    // Data buffer 

                    // Close Socket using  
                    // the method Close() 
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }

                // Manage of Socket's Exceptions 
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
            }

            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
            }
        }
    }
}
