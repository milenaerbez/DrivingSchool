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
    public partial class FrmIzmenaKandidata : Form
    {
        KandidatController controller;

        public FrmIzmenaKandidata()
        {
            InitializeComponent();
            controller = new KandidatController(this);
        }
    }
}
