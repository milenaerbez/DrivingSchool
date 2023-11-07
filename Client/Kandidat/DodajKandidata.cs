using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Kandidat
{
    public partial class DodajKandidata : Form
    {
        KandidatController controller;
        public DodajKandidata()
        {
            InitializeComponent();
            controller=new KandidatController(this);
        }


        private void DodajKandidata_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
