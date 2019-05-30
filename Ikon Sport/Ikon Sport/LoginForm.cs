using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikon_Sport
{
    public partial class IkonSportForm : Form
    {
        public IkonSportForm()
        {
            InitializeComponent();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NytLogin_Click(object sender, EventArgs e)
        {
            var Signup = new Signup();
            Signup.Show();
            this.Hide();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            var Ordre = new Produkt_info();

            string str;
            try
            {
                str = Connection.loginCheck(brugernavnTB.Text, KodeTB.Text);
    
                if(Connection.LoginAccepteret == true)
                {
                    this.Hide();
                    Ordre.Show();
                }
                
            }
            catch (Exception ex)
            {
                str = ex.Message;
            }
            TestLabel.Text = str;
           
        }

        private void SnydBTN_Click(object sender, EventArgs e)
        {
            var Ordre = new Produkt_info();
            this.Hide();
            Ordre.Show();
        }
    }
}
