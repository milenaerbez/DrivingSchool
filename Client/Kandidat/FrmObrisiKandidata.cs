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
    public partial class FrmObrisiKandidata : Form
    {
        private KandidatController controller;
        public FrmObrisiKandidata()
        {
            InitializeComponent();
            controller = new KandidatController(this);
        }
    }
}
