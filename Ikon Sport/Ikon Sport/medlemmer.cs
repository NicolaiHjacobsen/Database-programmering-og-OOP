using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using IKS_CL;

namespace Ikon_Sport
{
    public partial class medlemmer : Form
    {
        public DataTable MKData = new DataTable();

        public medlemmer()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            cn.medlemskort_Display(out MKData);

            MedlemmerDGV.DataSource = MKData;
        }

        private void TilbageBTN_Click(object sender, EventArgs e)
        {
            Produkt_info PI = new Produkt_info();
            this.Hide();
            PI.Show();
        }

        private void OpretNyBTN_Click(object sender, EventArgs e)
        {
            OpretNyBTN.Visible = false;
            OpretMedlemPAN.Visible = true;
        }

        private void OpretBTN_Click(object sender, EventArgs e)
        {
            IKS dtip = new IKS("(local)", "Ikon Sport");

            try
            {
                int Postnummer;

                if (int.TryParse(PostnummerTB.Text, out Postnummer))
                { 
                    //Pasing gennemført 
                }
                else
                {
                    messageLB.Text = "Fejl!, Kontakt din IT-expert!";
                }

                dtip.opretAdresse(Postnummer, ByTB.Text, VejTB.Text, HusnummerTB.Text);
                dtip.opretMedlemskort(NavnTB.Text, EfternavnTB.Text, MailTB.Text, TelefonTB.Text);
                messageLB.Text = "Fejl!";

            }
            catch (Exception)
            {
                messageLB.Text = "Fejl!, Kontakt din IT-expert!";
            }
        }
    }
}
