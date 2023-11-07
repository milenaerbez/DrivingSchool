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
    public class PrisustvaController
    {
        private FrmPrisustva frmPrisustva;
        public List<Termin> termini = new List<Termin>();

        public PrisustvaController(FrmPrisustva frmPrisustva)
        {
            this.frmPrisustva = frmPrisustva;
           // frmPrisustva.DataGridView1.DataSource = termini;
           // frmPrisustva.DataGridView2.DataSource = Communication.Instance.UcitajSveKandidate();
            frmPrisustva.DataGridView3.DataSource = prisustva;
            // OsveziPrikaz();
            frmPrisustva.DgvGrupe.DataSource = Communication.Instance.VratiSveGrupe();
            ObradiOperacije();
          //  termini = Communication.Instance.UcitajTermine();

        }

        private void OsveziPrikaz()
        {
            Domain.Kandidat k = new Domain.Kandidat();
            k.Grupa = g;
            frmPrisustva.DataGridView2.DataSource = Communication.Instance.UcitajKandidate(k);
            if (Communication.Instance.UcitajKandidate(k).Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita kandidate");
                return;
            }
            frmPrisustva.DataGridView2.Refresh();


            //frmPrisustva.DataGridView2.DataSource = Communication.Instance.UcitajSveKandidate();
            ///frmPrisustva.DataGridView2.Refresh();
        }

        private void ObradiOperacije()
        {
            frmPrisustva.Button1.Click += IzaberiGrupu;
            frmPrisustva.Button2.Click += DodajPrisustva;
            frmPrisustva.Button3.Click += SacuvajPrisustva;
           // frmPrisustva.Button4.Click += UcitajKandidate;
        }

        private void UcitajKandidate
            (object sender, EventArgs e)
        {
            OsveziPrikaz();

        }

        private void SacuvajPrisustva(object sender, EventArgs e)
        {
            if (prisustva.Count == 0)
            {
                MessageBox.Show("Prisustva nisu izabrana!");
                return;
            }

            Communication.Instance.SacuvajPrisustva(prisustva);
            MessageBox.Show("Sistem je sacuvao prisustvo!");
            prisustva.Clear();
            frmPrisustva.DgvGrupe.Refresh();
        }

        public  BindingList<Prisustvo> prisustva = new BindingList<Prisustvo>();
        private void DodajPrisustva(object sender, EventArgs e)
        {
            Prisustvo p = new Prisustvo();
            p.Status = true;
            if (frmPrisustva.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row=frmPrisustva.DataGridView1.SelectedRows[0];
                if(row.DataBoundItem is Termin t)
                {
                    p.Termin = t;
                    p.Grupa = t.Grupa;
                    Console.WriteLine("Termin ID" + t.ID);
                    Console.WriteLine("Grupa ID" + t.Grupa.ID);

                }
                else
                {
                    Console.WriteLine("Nije selektovan termin");
                    return;
                }

            }

            if (frmPrisustva.DataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow row=frmPrisustva.DataGridView2.SelectedRows[0];
                if(row.DataBoundItem is Domain.Kandidat k)
                {
                    p.Kandidat = k;
                }
                else
                {
                    Console.WriteLine("Nije selektovan kandidat");
                    return;
                }
            }
            bool prisustvoExistsInDB = false;
            try
            {
                prisustvoExistsInDB= Communication.Instance.VratiSvaPrisustva().Any(existingPrisustvo =>
                 existingPrisustvo.Termin.ID == p.Termin.ID && existingPrisustvo.Kandidat.ID == p.Kandidat.ID);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            if (prisustvoExistsInDB)
            {
                MessageBox.Show("Izabrano Prisustvo već postoji u bazi podataka!");
                return;
            }

                bool prisustvoExists = prisustva.Any(existingPrisustvo => existingPrisustvo.Termin.ID == p.Termin.ID && existingPrisustvo.Kandidat.ID == p.Kandidat.ID);
            if (prisustvoExists)
            {
                MessageBox.Show("Izabrano Prisustvo već postoji u listi!");
                return;
            }


            prisustva.Add(p);
            frmPrisustva.DataGridView3.Refresh();

        }

        public List<Domain.Kandidat> kandidati = new List<Domain.Kandidat>();
        Grupa g = new Grupa();
        private void IzaberiGrupu(object sender, EventArgs e)
        {

            if (frmPrisustva.DgvGrupe.SelectedRows.Count > 0)
            {
                DataGridViewRow obj=frmPrisustva.DgvGrupe.SelectedRows[0];
                if(obj.DataBoundItem is Grupa selected)
                {
                    g = selected;
                }
            }
            else
            {
                MessageBox.Show("Izaberite grupu!");
                return;
            }

            PretraziTermine();
            PretraziKandidate();

        }

        private void PretraziKandidate()
        {
            OsveziPrikaz();
        }

        private void PretraziTermine()
        {

            Termin t = new Termin();
            t.Grupa = g;
            frmPrisustva.DataGridView1.DataSource = Communication.Instance.UcitajTermine(t);
            if (Communication.Instance.UcitajTermine(t).Count == 0)
            {
                MessageBox.Show("Sistem ne moze da ucita termine");
                return;
            }
            frmPrisustva.DataGridView1.Refresh();

        }
    }
}
