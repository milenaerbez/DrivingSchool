using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Communication
    {
        private static Communication instance;
        public static Communication Instance
        {
            get
            {
                if (instance == null) instance = new Communication();
                return instance;
            }
        }

        private Socket soket;
        Sender sender;
        Receiver receiver;


       public void Connect()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soket.Connect("localhost", 9000);
                sender = new Sender(soket);
                receiver = new Receiver(soket);
                System.Windows.Forms.MessageBox.Show("Klijent je povezan");
            }
            catch (Exception ex)
            {

                Console.WriteLine("Greska kod klijenta"+ex.Message);
            }
        }

        public void ExceptionHandler(Response response)
        {
            if (response.Message != null)
            {
                System.Windows.Forms.MessageBox.Show("Sistem nije uspeo da izvrsi operaciju!"+response.Message);
            }
        }

        internal Korisnik Prijava(Korisnik k)
        {
            Request request = new Request();
            request.Operation = Operation.Prijava;
            request.RequestObj = k;
            sender.Send(request);


            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
            return (Korisnik)response.ResponseObj;
            

        }

        internal void DodajKandidata(Domain.Kandidat kandidat)
        {
            Request request = new Request();
            request.Operation = Operation.DodajKandidata;
            request.RequestObj = kandidat;

            sender.Send(request);


            // _ = (Response)receiver.Receive();
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }

        internal void SacuvajGrupu(Grupa grupa)
        {
            Request request = new Request();
            request.Operation = Operation.SacuvajGrupu;
            request.RequestObj = grupa;
            sender.Send(request);
            // _ = (Response)receiver.Receive();
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }

        internal List<Grupa> VratiSveGrupe()
        {
            Request req = new Request();
            req.Operation = Operation.VratiSveGrupe;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Grupa>)res.ResponseObj;
        }

        internal List<Domain.Kandidat> Pretrazi(Domain.Kandidat k)
        {

            Request req = new Request();
            req.Operation = Operation.PretraziKandidate;
            req.RequestObj = k;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Domain.Kandidat>)res.ResponseObj;
        }

        internal void ObrisiKandidata(Domain.Kandidat k)
        {
            Request req = new Request();
            req.Operation = Operation.ObrisiKandidata;
            req.RequestObj = k;

            sender.Send(req);
            //_ = (Response)receiver.Receive();
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }

        internal void SacuvajTermine(BindingList<Termin> dodatniTermini)
        {
            Request req = new Request();
            req.Operation = Operation.SacuvajTermine;
            req.RequestObj = dodatniTermini;
            sender.Send(req);
            // _ = (Response)receiver.Receive();
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);

        }

        internal void ObrisiGrupu(Grupa g)
        {
            Request req = new Request();
            req.Operation = Operation.ObrisiGrupu;
            req.RequestObj = g;
            sender.Send(req);
            //_ = (Response)receiver.Receive();
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);

        }

        internal List<Termin> UcitajTermine(Termin t)
        {
            Request req = new Request();
            req.Operation = Operation.UcitajTermineZaGrupu;
            req.RequestObj = t;
            sender.Send(req);
            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            if (res.ResponseObj == null)
            {
                System.Windows.Forms.MessageBox.Show("Sistem ne moze da ucita objekte!");
                
            }
            return (List<Termin>)res.ResponseObj;
        }

        internal List<Domain.Kandidat> UcitajKandidate(Domain.Kandidat k)
        {
            Request req = new Request();
            req.Operation = Operation.UcitajKandidate;
            req.RequestObj = k;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            
            return (List<Domain.Kandidat>)res.ResponseObj;


        }

        internal void SacuvajPrisustva(BindingList<Prisustvo> prisustva)
        {
            Request req = new Request();
            req.Operation = Operation.SacuvajPrisustva;
            req.RequestObj = prisustva;
            sender.Send(req);
            // _ = (Response)receiver.Receive();
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }

        internal object UcitajSveKandidate()
        {
            Request req = new Request();
            req.Operation = Operation.UcivajSveKandidate;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Domain.Kandidat>)res.ResponseObj;

        }

        internal void IzmeniGrupu(Grupa g)
        {
            Request req = new Request();
            req.Operation = Operation.IzmenaGrupe;
            req.RequestObj = g;

            sender.Send(req);
            //_ = (Response)receiver.Receive();
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }

        internal void IzmeniKandidata(Domain.Kandidat zaIzmenu)
        {
            Request req = new Request();
            req.Operation = Operation.IzmenaKandidata;
            req.RequestObj = zaIzmenu;

            sender.Send(req);
            //_ = (Response)receiver.Receive();
            Response response = (Response)receiver.Receive();
            ExceptionHandler(response);
        }

        internal List<Grupa> PretraziGrupe(Grupa g)
        {
            Request req = new Request();
            req.Operation = Operation.PretraziGrupe;
            req.RequestObj = g;

            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Grupa>)res.ResponseObj;

        }

        internal List<Prisustvo> VratiSvaPrisustva()
        {
            Request req = new Request();
            req.Operation = Operation.VratiPrisustva;
            sender.Send(req);

            Response res = (Response)receiver.Receive();
            ExceptionHandler(res);
            return (List<Prisustvo>)res.ResponseObj;
        }
    }
}
