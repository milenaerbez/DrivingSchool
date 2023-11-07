using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    internal class FrmController
    {
        private static FrmController instance;
        public static FrmController Instance
        {
            get
            {
                if (instance == null) instance = new FrmController();
                return instance;
            }
        }

        public FrmPrijava frmPrijava;
        public Korisnik korisnik;

        public void ShowFrmPrijava()
        {
            Communication.Instance.Connect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmPrijava = new FrmPrijava();
            frmPrijava.ShowDialog();
            frmPrijava.AutoSize = true;
            Application.Run(frmPrijava);
        }

        internal void ShowFrm(Form form)
        {
            form.ShowDialog();
            
        }
    }
}
