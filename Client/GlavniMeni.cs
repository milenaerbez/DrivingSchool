using Client.Kandidat;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class GlavniMeni : Form
    {
        private Korisnik k;

        public GlavniMeni()
        {
           
        }

        public GlavniMeni(Korisnik k)
        {
            InitializeComponent();
            this.k = k;
            //this.Text = k.ToString();
            label1.Text = k.ToString();
        }

        private void dodajKandidataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new DodajKandidata());
        }

        private void napraviGrupuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new NapraviGrupu());
        }

        private void obrišiKandidataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmObrisiKandidata());
        }

        private void dodajTermineZaGrupuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmIzmenaGrupe());
        }

        private void obrišiGrupuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmObrisiGrupu());
        }

        private void pretražiGrupeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmPretraziGrupe());
        }

        private void dodajPrisustvoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmPrisustva());
        }

        private void izmeniKandidataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmIzmenaKandidata());
        }

        private void prikazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmController.Instance.ShowFrm(new FrmPrikaz());
        }
    }
}
