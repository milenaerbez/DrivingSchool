using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class PrijavaController
    {
        private FrmPrijava frmPrijava;

        public PrijavaController(FrmPrijava frmPrijava)
        {
          
            this.frmPrijava = frmPrijava;
            this.frmPrijava.TextBox1.Text = "petar.petrovic";
            this.frmPrijava.TextBox2.Text = "pp1234!";
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            frmPrijava.Button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Korisnik k=new Korisnik();
            string username = frmPrijava.TextBox1.Text;
            string password = frmPrijava.TextBox2.Text;



            k.KorisnickoIme = username;
            k.Lozinka = password;

            try
            {
                k = Communication.Instance.Prijava(k);
                if (k != null)
                {
                    // GlavniMeni form = new GlavniMeni(k);
                    // form.ShowDialog();
                    FrmController.Instance.korisnik = k;
                    System.Windows.Forms.MessageBox.Show("Uspesno ste se prijavili na sistem!");
                    FrmController.Instance.ShowFrm(new GlavniMeni(k));


                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Sistem ne moze da prijavi korisnika!");
                    return;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Greska kod prijavacontroller"+ex.Message+ex.StackTrace);
            }

        }
    }
}
