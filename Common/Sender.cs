using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common
{
    [Serializable]
    public class Sender
    {
        Socket soket;
        NetworkStream tok;
        BinaryFormatter formater;

        public Sender(Socket soket)
        {
            this.soket = soket;
           
            tok=new NetworkStream(soket);
            formater = new BinaryFormatter();
        }

        public void Send(object obj)
        {
            formater.Serialize(tok, obj);
        }
    }
}
