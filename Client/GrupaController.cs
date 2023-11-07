using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class GrupaController
    {
        private NapraviGrupu form;
        //public List<string> kategorije = new List<string>()
        //{
        //    "A1","A2","B","BE"
        //};
        //public List<string> TematskaJedinica = new List<string>()
        //{
        //    "Bezbednost saobraćaja",
        //    "Učesnici u saobraćaju",
        //    "Vozačka dozvola",
        //    "Saobraćajni znakovi"
        //};
        BindingList<Termin> termini = new BindingList<Termin>();
        Grupa grupa = new Grupa();
        private FrmIzmenaGrupe frmIzmenaGrupe;

        public GrupaController(NapraviGrupu napraviGrupu)
        {
            this.form = napraviGrupu;
            form.ComboBox1.DataSource = Domain.Kategorija.kategorije;
            form.ComboBox2.DataSource= Domain.TematskaJedinica.tematskeJedinice;
            form.DataGridView1.DataSource = termini;
            form.DataGridView1.AllowUserToAddRows = false;
            EventsFrmNapraviGrupu();
        }

        public BindingList<Termin> dodatniTermini = new BindingList<Termin>();
        public BindingList<Grupa> sveGrupe = new BindingList<Grupa>();
        private FrmObrisiGrupu frmObrisiGrupu;

        public GrupaController(FrmIzmenaGrupe frmIzmenaGrupe)
        {
            this.frmIzmenaGrupe = frmIzmenaGrupe;
            frmIzmenaGrupe.ComboBox1.DataSource = Domain.TematskaJedinica.tematskeJedinice;
            frmIzmenaGrupe.DataGridView1.AllowUserToAddRows = false;
           
            //sveGrupe = Communication.Instance.VratiSveGrupe();
            frmIzmenaGrupe.DataGridView2.DataSource = dodatniTermini;
           // frmIzmenaGrupe.DataGridView1.DataSource =sveGrupe;
            Events();

        }

        private void OsveziPrikaz()
        {
            //sveGrupe = Communication.Instance.VratiSveGrupe();
            frmIzmenaGrupe.DataGridView1.DataSource = Communication.Instance.VratiSveGrupe();
            frmIzmenaGrupe.DataGridView1.Refresh();


        }

        public List<Grupa> grupeBrisanje = new List<Grupa>();
        private FrmPretraziGrupe frmPretraziGrupe;

        public GrupaController(FrmObrisiGrupu frmObrisiGrupu)
        {
            this.frmObrisiGrupu = frmObrisiGrupu;
            //grupeBrisanje = Communication.Instance.VratiSveGrupe();
            

            HandleEvents();
        }

        public List<Grupa> pretragaGrupa = new List<Grupa>();

        public GrupaController(FrmPretraziGrupe frmPretraziGrupe)
        {
            //this.frmPretraziGrupe = frmPretraziGrupe;
            //frmPretraziGrupe.DgvGrupe.DataSource = pretragaGrupa;
            //int godina = int.Parse(frmPretraziGrupe.TextBox1.Text);
            //Grupa g = new Grupa();

            //Communication.Instance.PretraziGrupe()

            this.frmPretraziGrupe = frmPretraziGrupe;
            PretraziGrupePoGodini();
           
            
        }

        private void PretraziGrupePoGodini()
        {
          

            frmPretraziGrupe.BtnGodina.Click += BtnGodina_Click;
         //   frmPretraziGrupe.DgvGrupe.SelectedRows += Ucitaj;

        }
        Grupa g = new Grupa();

        private void BtnGodina_Click(object sender, EventArgs e)
        {
            try
            {
                int godina = int.Parse(frmPretraziGrupe.TextBox1.Text);
                g.DatumPocetka = new DateTime(godina, g.DatumPocetka.Month, g.DatumPocetka.Day);
                if (Communication.Instance.PretraziGrupe(g).Count == 0)
                {
                    MessageBox.Show("Sistem ne moze da nadje grupe po zadatom kriterijumu");
                    return;
                }
                frmPretraziGrupe.DgvGrupe.DataSource = Communication.Instance.PretraziGrupe(g);
                MessageBox.Show("Sistem je pronasao grupe po zadatom kriterijumu");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nevalidan unos");
                return;
            }
            


        }

        private void HandleEvents()
        {

            frmObrisiGrupu.BtnVratiGrupe.Click += BtnVratiGrupe_Click;
            frmObrisiGrupu.Button1.Click += Button1_Click2;
        }
        Grupa zaBrisanje = new Grupa();

        private void BtnVratiGrupe_Click(object sender, EventArgs e)
        {
            // OsveziPrikaGrupa();
            try
            {
                int godina = int.Parse(frmObrisiGrupu.TxtBrisanjeGod.Text);
                zaBrisanje.DatumPocetka = new DateTime(godina, g.DatumPocetka.Month, g.DatumPocetka.Day);
                if (Communication.Instance.PretraziGrupe(zaBrisanje).Count == 0)
                {
                    MessageBox.Show("Sistem ne moze da nadje grupe po zadatoj vrednosti");
                    return;
                }
                frmObrisiGrupu.DataGridView1.DataSource = Communication.Instance.PretraziGrupe(zaBrisanje);
                MessageBox.Show("Sistem je nasao grupe po zadatoj vrednosti");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nevalidan unos godine");
                return;
            }


        }

        private void OsveziPrikaGrupa()
        {

            frmObrisiGrupu.DataGridView1.DataSource = Communication.Instance.VratiSveGrupe();
            frmObrisiGrupu.DataGridView1.Refresh();
        }

        private void Button1_Click2(object sender, EventArgs e)
        {
            if (frmObrisiGrupu.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = frmObrisiGrupu.DataGridView1.SelectedRows[0];
                if(row.DataBoundItem is Grupa g)
                {
                    Communication.Instance.ObrisiGrupu(g);
                    MessageBox.Show("Sistem je obirisao grupu!");
                }
            }
            else
            {
                MessageBox.Show("Sistem ne moze da ucita grupu");
                return;
            }
            frmObrisiGrupu.DataGridView1.Refresh();
        }

        private void Events()
        {
            frmIzmenaGrupe.Button1.Click += DodavanjeTermina;
            frmIzmenaGrupe.Button2.Click += SacuvajIzmene;
            frmIzmenaGrupe.Button3.Click += UcitavanjeGrupa;
        }

        Grupa grupazaIzmenu = new Grupa();
        Grupa grupaIzmena = new Grupa();
        private void UcitavanjeGrupa(object sender, EventArgs e)
        {
            //OsveziPrikaz();
            try
            {
                int godina = int.Parse(frmIzmenaGrupe.TxtGodina.Text);
                grupaIzmena.DatumPocetka = new DateTime(godina, g.DatumPocetka.Month, g.DatumPocetka.Day);
                if (Communication.Instance.PretraziGrupe(grupaIzmena).Count == 0)
                {
                    MessageBox.Show("Sistem ne moze da nadje grupe po zadatoj vrednosti");
                    return;
                }
                frmIzmenaGrupe.DataGridView1.DataSource = Communication.Instance.PretraziGrupe(grupaIzmena);
                MessageBox.Show("Sistem je nasao grupe po zadatoj vrednosti");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Nevalidan unos godine");
                return;
            }
          


        }

        private void SacuvajIzmene(object sender, EventArgs e)
        {
            //Communication.Instance.SacuvajTermine(dodatniTermini);

            if (frmIzmenaGrupe.DataGridView1.Rows.Count > 0)
            {
                DataGridViewRow obj = frmIzmenaGrupe.DataGridView1.SelectedRows[0];
                if(obj.DataBoundItem is Grupa g)
                {
                    grupazaIzmenu = g;
                    if (DateTime.TryParse(frmIzmenaGrupe.TxtIzmena.Text, out DateTime parsedDate))
                    {
                        grupazaIzmenu.DatumPocetka = parsedDate;
                    }
                    else
                    {
                        
                        grupazaIzmenu.DatumPocetka = g.DatumPocetka;
                    }
                    foreach (Termin t in dodatniTermini)
                    {
                        grupazaIzmenu.Termini.Add(t);
                    }

                    Communication.Instance.IzmeniGrupu(g);
                    MessageBox.Show("Sistem je sacuvao izmene");
                }
            }


        }

        private void DodavanjeTermina(object sender, EventArgs e)
        {
            Termin t = new Termin();
            t.Datum = DateTime.Parse(frmIzmenaGrupe.TextBox1.Text);
            try
            {
                string input = frmIzmenaGrupe.TextBox2.Text;
                TimeSpan parsedTime;
                if(TimeSpan.TryParse(input, out parsedTime))
                {
                    t.Vreme = parsedTime;
                    Console.WriteLine(t.Vreme);
                }
                else
                {
                    Console.WriteLine("Pogresno vreme");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            try
            {
                if (frmIzmenaGrupe.DataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow obj=frmIzmenaGrupe.DataGridView1.SelectedRows[0];
                    if(obj.DataBoundItem is Grupa g)
                    {
                        t.Grupa = g;
                        //g.Termini.Add(t);
                    }

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Greska kod dgv grupa");

            }
            t.TematskaJedinica = frmIzmenaGrupe.ComboBox1.SelectedItem.ToString();
            dodatniTermini.Add(t);
            
            frmIzmenaGrupe.DataGridView2.Refresh();

            

        }

        private void EventsFrmNapraviGrupu
            ()
        {
            form.Button2.Click += SacuvajGrupu;
            form.Button1.Click += DodajTermin;
            form.BtnObrisiTermin.Click += ObrisiTermin;
        }

        private void ObrisiTermin(object sender, EventArgs e)
        {
            if (form.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow obj=form.DataGridView1.SelectedRows[0];
                if(obj.DataBoundItem is Termin t)
                {
                    termini.Remove(t);
                    form.DataGridView1.Refresh();
                }
            }
        }

        private void DodajTermin(object sender, EventArgs e)
        {

            Termin termin = new Termin();
            termin.TematskaJedinica = form.ComboBox2.SelectedItem.ToString();
            termin.Datum = DateTime.Parse(form.TextBox2.Text);
            try
            {
                string input = form.TextBox3.Text;
                TimeSpan parsedTime;
                if (TimeSpan.TryParse(input, out parsedTime))
                {
                    termin.Vreme = parsedTime;
                    Console.WriteLine(termin.Vreme); 
                }
                else
                {
                    Console.WriteLine("Invalid time format");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Greska kod vremena u terminu"+ex.Message);
            }

          
           

          
            termini.Add(termin);
            form.DataGridView1.Refresh();

            
        }

        private void SacuvajGrupu(object sender, EventArgs e)
        {

            string kategorija = form.ComboBox1.SelectedItem as string;

            if (string.IsNullOrEmpty(kategorija))
            {
                MessageBox.Show("Izaberite kategoriju!");
                return; 
            }

            DateTime datum;

            if (!DateTime.TryParse(form.TextBox1.Text, out datum))
            {
                MessageBox.Show("Neispravan format datuma!Molim unesite datum u formatu: YYYY-MM-DD");
                return; 
            }
            grupa.Kategorija = kategorija;
            grupa.DatumPocetka = datum;
            grupa.Predavac = FrmController.Instance.korisnik;

           foreach(Termin t in termini)
            {
                if (t.Datum >= grupa.DatumPocetka)
                {
                    grupa.Termini.Add(t);
                }
                else
                {
                    MessageBox.Show("Ne moze termin sa tim datumom!");
                    return ;
                    
                }
            }

            if (grupa.Termini.Count == 0)
            {
                MessageBox.Show("Izaberite termine!");
                return;
            }
  
            Communication.Instance.SacuvajGrupu(grupa);
            MessageBox.Show("Grupa je kreirana!");

        }
    }
}
