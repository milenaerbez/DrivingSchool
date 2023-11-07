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
    public partial class FrmPrisustva : Form
    {

        PrisustvaController controller;
        public FrmPrisustva()
        {
            InitializeComponent();
            controller = new PrisustvaController(this);
        }

     
    }
}
