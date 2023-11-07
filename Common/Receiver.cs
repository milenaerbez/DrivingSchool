using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace Common
{
    [Serializable]
    public class Receiver
    {
        Socket soket;
        NetworkStream tok;
        BinaryFormatter formater;

        public Receiver(Socket soket)
        {
            this.soket = soket; 
          
            tok = new NetworkStream(soket);
            formater = new BinaryFormatter();
        }

        public object Receive()
        {
            return formater.Deserialize(tok);
        }
    }
}
