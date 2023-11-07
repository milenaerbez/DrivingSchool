using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
            button1.Enabled = true;
            button2.Enabled = false;
        }
        Server s;
        private void button1_Click(object sender, EventArgs e)
        {
            s = new Server();
            MessageBox.Show("Server je pokrenut!");
            button1.Enabled = false;
            button2.Enabled = true;
            Thread nit = new Thread(s.Listen);
            nit.IsBackground = true;
            nit.Start();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            s.CloseAll();
            MessageBox.Show("Server je zaustavljen");
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
