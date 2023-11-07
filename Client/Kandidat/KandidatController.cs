using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Client.Kandidat
{
    internal class KandidatController
    {
        private DodajKandidata forma;
        List<Grupa> grupe = new List<Grupa>();
        private FrmObrisiKandidata frmObrisiKandidata;

        public KandidatController(DodajKandidata dodajKandidata)
        {
            forma = dodajKandidata;
            OsveziPrikazGrupa();
            InitializeEventHandlers();
        }

        List<Domain.Kandidat> kandidati = new List<Domain.Kandidat>();
        List<Domain.Kandidat> kandidatiZaIzmenu = new List<Domain.Kandidat>();

        public KandidatController(FrmObrisiKandidata frmObrisiKandidata)
        {
            this.frmObrisiKandidata = frmObrisiKandidata;
            //frmObrisiKandidata.DataGridView1.DataSource = Communication.Instance.UcitajSveKandidate();

            RefreshDgv();
            InitializeEvents();
        }

        public KandidatController(FrmIzmenaKandidata frmIzmenaKandidata)
        {
            this.frmIzmenaKandidata = frmIzmenaKandidata;
            frmIzmenaKandidata.DataGridView2.DataSource = Communication.Instance.VratiSveGrupe();
            RefreshPrikaz();
            ObradiAkcije();
        }

        public KandidatController(FrmPrikaz frmPrikaz)
        {
            this.frmPrikaz = frmPrikaz;
            PrikazOperacija();
        }

        private void PrikazOperacija()
        {
            frmPrikaz.Button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<Domain.Kandidat> kandidati = new List<Domain.Kandidat>();
            kandidati = (List<Domain.Kandidat>)Communication.Instance.UcitajSveKandidate();
            frmPrikaz.DataGridView1.DataSource = kandidati;
        }

        private void RefreshPrikaz()
        {
            frmIzmenaKandidata.DataGridView1.DataSource = Communication.Instance.UcitajSveKandidate();
            frmIzmenaKandidata.DataGridView1.Refresh();
        }

        private void ObradiAkcije()
        {
            frmIzmenaKandidata.BtnPretraga.Click += BtnPretraga_Click;
            frmIzmenaKandidata.BtnSacuvaj.Click += BtnSacuvaj_Click;
        }

        public Domain.Kandidat zaIzmenu=new Domain.Kandidat();  
        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            if (frmIzmenaKandidata.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow obj=frmIzmenaKandidata.DataGridView1.SelectedRows[0];
                if(obj.DataBoundItem is Domain.Kandidat k)
                {
                    zaIzmenu = k;
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali kandidata!");
                return;
            }

            if (!string.IsNullOrWhiteSpace(frmIzmenaKandidata.TxtUnosIme.Text))
            {
                zaIzmenu.Ime = frmIzmenaKandidata.TxtUnosIme.Text;
                
            }

           


            if (!string.IsNullOrWhiteSpace(frmIzmenaKandidata.TxtUnosPrezime.Text))
            {
                zaIzmenu.Prezime = frmIzmenaKandidata.TxtUnosPrezime.Text;
            }

            if (frmIzmenaKandidata.DateTimePicker1.Value.Year > 2007)
            {
                MessageBox.Show("Sistem ne moze da zapamti kandidata. Nevalidan unos datuma");
                return;
            }
            zaIzmenu.DatumRodjenja = frmIzmenaKandidata.DateTimePicker1.Value;
            
            if (!string.IsNullOrWhiteSpace(frmIzmenaKandidata.TxtBrLicne.Text))
            {
                zaIzmenu.Prezime = frmIzmenaKandidata.TxtBrLicne.Text;
            }


            if (frmIzmenaKandidata.DataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow obj = frmIzmenaKandidata.DataGridView2.SelectedRows[0];
                if(obj.DataBoundItem is Grupa g)
                {
                    zaIzmenu.Grupa = g;
                }
            }


            Communication.Instance.IzmeniKandidata(zaIzmenu);
            MessageBox.Show("Kandidat je izmenjen!");
        }

        private void BtnPretraga_Click(object sender, EventArgs e)
        {
            Domain.Kandidat k = new Domain.Kandidat();

            string prezime = frmIzmenaKandidata.TxtPrezime.Text;
            k.Prezime = prezime;
            kandidatiZaIzmenu = Communication.Instance.Pretrazi(k);
            if (kandidatiZaIzmenu.Count == 0)
            {
                MessageBox.Show("Nema kandidata sa tim prezimenom!");
                return;
            }
            frmIzmenaKandidata.DataGridView1.DataSource = kandidatiZaIzmenu;
            MessageBox.Show("Sistem je pronasao kandidate po zadatom kriterijumu");


        }

        private void RefreshDgv()
        {
            frmObrisiKandidata.DataGridView1.DataSource = Communication.Instance.UcitajSveKandidate();
            frmObrisiKandidata.DataGridView1.Refresh();
        }

        private void InitializeEvents()
        {
            frmObrisiKandidata.Button1.Click += PretraziPoPrezimenu;
            frmObrisiKandidata.Button2.Click += ObrisiKandidata;

            
        }


     
        private void ObrisiKandidata(object sender, EventArgs e)
        {
            Domain.Kandidat k = new Domain.Kandidat();

            if (frmObrisiKandidata.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = frmObrisiKandidata.DataGridView1.SelectedRows[0];


                if (selectedRow.DataBoundItem is Domain.Kandidat selectedKandidat)
                {

                    k = selectedKandidat;
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali kandidata!");
                return;
            }

            Communication.Instance.ObrisiKandidata(k);
            MessageBox.Show("Kandidat je obrisan!");
            RefreshDgv();

           
        }

      

        Domain.Kandidat k = new Domain.Kandidat();
        private FrmIzmenaKandidata frmIzmenaKandidata;
        private FrmPrikaz frmPrikaz;

        private void PretraziPoPrezimenu(object sender, EventArgs e)
        {
            Pretrazi();

        }

        private void Pretrazi()
        {
            string text = frmObrisiKandidata.TextBox1.Text;

            k.Prezime = text;
            kandidati = Communication.Instance.Pretrazi(k);
            if (kandidati.Count==0)
            {
                MessageBox.Show("Nema kandidata pod tim prezimenom!");
                return;
            }
            frmObrisiKandidata.DataGridView1.DataSource = kandidati;
            MessageBox.Show("Sistem je ucitao kandidate po zadatom kriterijumu");
        }

        private void InitializeEventHandlers()
        {
           // forma.Load += Forma_Load;
            forma.Button1.Click += SacuvajKandidata;
            forma.BtnGrupe.Click += BtnGrupe_Click;
            
        }

        private void BtnGrupe_Click(object sender, EventArgs e)
        {
           OsveziPrikazGrupa();
        }

        private void Forma_Load(object sender, EventArgs e)
        {
            ////OsveziPrikazGrupa();
            //Thread nit = new Thread(OsveziPrikazGrupa);
            //nit.IsBackground = true;
            //nit.Start();
            
        }

        private void OsveziPrikazGrupa()
        {

            forma.DataGridView1.DataSource = Communication.Instance.VratiSveGrupe();
            forma.DataGridView1.Refresh();


        }

     

        private void SacuvajKandidata(object sender, EventArgs e)
        {
            Domain.Kandidat kandidat = new Domain.Kandidat();
            if (string.IsNullOrWhiteSpace(forma.TextBox1.Text))
            {
                MessageBox.Show("Unesite ime kandidata!");
                return; 
            }
            string inputText = forma.TextBox1.Text;
            if (!char.IsUpper(inputText, 0)) 
            {
                MessageBox.Show("Ime kandidata treba početi velikim slovom!");
                return;
            }
            kandidat.Ime = forma.TextBox1.Text;

            if (string.IsNullOrWhiteSpace(forma.TextBox2.Text))
            {
                MessageBox.Show("Unesite prezime kandidata!");
                return; 
            }
            string prezime = forma.TextBox2.Text;
            if (!char.IsUpper(prezime, 0)) 
            {
                MessageBox.Show("Prezime kandidata treba početi velikim slovom!");
                return;
            }

            kandidat.Prezime = forma.TextBox2.Text;

            if (string.IsNullOrWhiteSpace(forma.TextBox3.Text))
            {
                MessageBox.Show("Unesite licnu kartu kandidata!");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(forma.TextBox3.Text, @"^\d+$"))
            {
                MessageBox.Show("Broj lične karte treba da sadrži samo cifre!");
                return;
            }
            kandidat.BrojLicneKarte = forma.TextBox3.Text;

            DateTime selectedDate = forma.DateTimePicker1.Value;

            if (selectedDate.Year >= 2007)
            {
                MessageBox.Show("Izabrana godina rođenja mora biti manja od 2007.!");
                return; 
            }

            kandidat.DatumRodjenja = selectedDate;



            if (forma.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = forma.DataGridView1.SelectedRows[0];


                if (selectedRow.DataBoundItem is Grupa selectedGrupa)
                {
                   
                    kandidat.Grupa = selectedGrupa;
                }



            }
            else
            {
                MessageBox.Show("Izaberite grupu!");
                return;
            }
           


                Communication.Instance.DodajKandidata(kandidat);
            MessageBox.Show("Uspesno sacuvan kandidat!");


        }
    }
}
