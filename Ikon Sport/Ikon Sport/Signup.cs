using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IKS_CL;

namespace Ikon_Sport
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void TilbageBTN_Click(object sender, EventArgs e)
        {
            var IkonSport = new IkonSportForm();
            IkonSport.Show();
            this.Hide();
        }

        private void OpretBrugerBTN_Click(object sender, EventArgs e)
        {

            IKS dtip = new IKS("(local)", "Ikon Sport");

            try
            {
                //Kontrolere de forskellige textboxe, hvis de er tomme gives der en fejl meddelelse, ellers sendes koden videre til næste tjek.
                if(BrugernavnTB.Text.Trim() == string.Empty || NavnTB.Text.Trim() == string.Empty || EfternavnTB.Text.Trim() == string.Empty || MailTB.Text.Trim() == string.Empty || KodeTB.Text.Trim() == string.Empty)
                {
                    messageLB.Text = "Fejl! Udfyld alle felter!";
                    messageLB.ForeColor = Color.Red;
                }
                else
                {
                    //Er kode ikke = gentag kode, så gives der en fejl, ellers oprettes bruger. 
                    if (KodeTB.Text != GentagKodeTB.Text)
                    {
                        messageLB.Text = "Fejl! De to koder passer ikke sammen!";
                        messageLB.ForeColor = Color.Red;
                    }
                    else
                    {
                        dtip.createUser(BrugernavnTB.Text, NavnTB.Text, EfternavnTB.Text, MailTB.Text, KodeTB.Text);
                        messageLB.Text = "bruger oprettet!";
                        messageLB.ForeColor = Color.Green;
                    }
                }

            }
            catch (Exception)
            {
                messageLB.Text = "Fejl!, Kontakt din IT-expert!";
            }
           
        }
    }
}
