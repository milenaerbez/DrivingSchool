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
    public partial class FrmIzmenaGrupe : Form
    {
        GrupaController controller; 
        public FrmIzmenaGrupe()
        {
            InitializeComponent();
            controller = new GrupaController(this);
        }

        private void FrmIzmenaGrupe_Load(object sender, EventArgs e)
        {

        }
    }
}
