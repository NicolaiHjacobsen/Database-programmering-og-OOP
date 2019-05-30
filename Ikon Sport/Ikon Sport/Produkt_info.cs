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
    public partial class Produkt_info : Form
    {

        public DataTable dtbl = new DataTable();

        private void Ordre_Load(object sender, EventArgs e)
        {
            //opretter et objekt fra min Connection class
            Connection cn = new Connection();

            //bruger overstående objekt til display dens indhold i "prodkut_info" DataViewgrid
            cn.produkt_Display(out dtbl);
            ProduktDGV.DataSource = dtbl;
        }

        public Produkt_info()
        {
            InitializeComponent();
        }

        private void LogudBTN_Click(object sender, EventArgs e)
        {
            var IKS = new IkonSportForm();
            this.Close();
            IKS.Show();
        }

        private void MedlemBTN_Click(object sender, EventArgs e)
        {
            var MK = new medlemmer();
            this.Hide();
            MK.Show();
        }
    }
}
