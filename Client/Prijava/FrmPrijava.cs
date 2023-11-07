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
    public partial class FrmPrijava : Form
    {
        private PrijavaController controller;
        public FrmPrijava()
        {
            InitializeComponent();
            controller = new PrijavaController(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
