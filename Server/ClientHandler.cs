using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ClientHandler
    {
        private Socket klijentskiSoket;
        NetworkStream tok;
        BinaryFormatter formatter;

        public ClientHandler(Socket klijentskiSoket)
        {
            this.klijentskiSoket = klijentskiSoket;
            tok = new NetworkStream(this.klijentskiSoket);
            formatter = new BinaryFormatter();
        }



        internal void Close()
        {
         klijentskiSoket.Close();
        }

        internal void Communication()
        {
            try
            {
                while (true)
                {
                    Request request = (Request)formatter.Deserialize(tok);
                    Response response = new Response();
                    try
                    {
                        //ovde dobijam response
                        response = HandleRequest(request);
                    }
                    catch (Exception ex)
                    {
                        response.Message = ex.Message;
                        Console.WriteLine("greska je kod response handle req" + ex.Message);
                    }
                   
                    formatter.Serialize(tok, response);
                }
            }
            catch (IOException IOex)
            {
                Debug.WriteLine("Klijent je napustio komunikaciju.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private Response HandleRequest(Request request)
        {
            Response response = new Response();
            try
            {
                switch (request.Operation)
                {

                    case Operation.Prijava:
                        response.ResponseObj = Controller.Instance.Prijava((Korisnik)request.RequestObj);
                        break;

                    case Operation.SacuvajGrupu:
                        Controller.Instance.KreirajGrupu((Grupa)request.RequestObj);
                        break;
                    case Operation.VratiSveGrupe:
                        response.ResponseObj = Controller.Instance.VratiSveGrupe();
                        break;
                    case Operation.DodajKandidata:
                        Controller.Instance.KreirajKandidata((Kandidat)request.RequestObj);
                        break;
                    case Operation.PretraziKandidate:
                        Kandidat k = (Kandidat)request.RequestObj;
                        string criteria = $"Prezime= '{k.Prezime}'";
                        response.ResponseObj = Controller.Instance.PretraziKandidate(k,criteria);
                        break;
                    case Operation.ObrisiKandidata:
                        Controller.Instance.ObrisiKandidata((Kandidat)request.RequestObj);
                        break;
                    case Operation.SacuvajTermine:
                        Controller.Instance.SacuvajTermine((BindingList<Termin>)request.RequestObj);
                        break;
                    case Operation.ObrisiGrupu:
                        Controller.Instance.ObrisiGrupu((Grupa)request.RequestObj);
                        break;
                    case Operation.UcitajTermineZaGrupu:
                        Termin t = (Termin)request.RequestObj;
                        string kriterijum = $"GrupaID={t.Grupa.ID}";
                        response.ResponseObj = Controller.Instance.UcitajTermineZaGrupu(t, kriterijum);
                        break;

                    case Operation.UcitajKandidate:
                        Kandidat kandidat = (Kandidat)request.RequestObj;
                        string text = $"GrupaID={kandidat.Grupa.ID}";
                        response.ResponseObj = Controller.Instance.UcitajKandidate(kandidat, text);
                        break;
                    case Operation.SacuvajPrisustva:
                        Controller.Instance.SacuvajPrisustva((BindingList<Prisustvo>)request.RequestObj);
                        break;
                    case Operation.UcivajSveKandidate:
                        response.ResponseObj = Controller.Instance.UcitajSveKandidate();
                        break;
                        case Operation.IzmenaGrupe:
                        Controller.Instance.IzmeniGrupu((Grupa)request.RequestObj);
                        break;
                    case Operation.IzmenaKandidata:
                        Controller.Instance.IzmeniKandidata((Kandidat)request.RequestObj);
                        break;
                    case Operation.PretraziGrupe:
                        Grupa g = (Grupa)request.RequestObj;
                        string krit = $"YEAR(DatumPolaska) = {g.DatumPocetka.Year}";
                        response.ResponseObj = Controller.Instance.PretraziGrupe(g,krit);
                        break;
                    case Operation.VratiPrisustva:
                        response.ResponseObj = Controller.Instance.VratiPrisustva();
                        break;


                }
              
            }
           
            catch (Exception ex)
            {

                Console.WriteLine("greska je u handle req"+ex.Message+ex.StackTrace);
            }
            return response;
        }
    }
}
