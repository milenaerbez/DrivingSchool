using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    internal class Server
    {
        Socket serverSocket;
        List<ClientHandler> klijenti;

        public Server()
        {
            serverSocket= new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Any, 9000);
            serverSocket.Bind(ep);
            klijenti = new List<ClientHandler>();
        }

        public void Listen()
        {
            try
            {
                serverSocket.Listen(8);
                while (true)
                {
                    Socket klijentskiSoket=serverSocket.Accept();
                    ClientHandler klijent = new ClientHandler(klijentskiSoket);
                    klijenti.Add(klijent);

                    Thread nit = new Thread(klijent.Communication);
                    nit.IsBackground = true;
                    nit.Start();

                }
            }
            catch (Exception ex)
            {

                //throw;
            }


        }

        public void CloseAll()
        {
            serverSocket?.Close();
            foreach(ClientHandler cl in klijenti)
            {
                cl.Close();
            }
        }

    }
}
