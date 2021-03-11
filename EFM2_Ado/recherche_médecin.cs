using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFM2_Ado
{
    public partial class recherche_médecin : Form
    {
        public recherche_médecin()
        {
            InitializeComponent();
        }

        private void recherche_médecin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetHotel.Medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter.Fill(this.dataSetHotel.Medecin);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textCIN_TextChanged(object sender, EventArgs e)
        {
           // this.medecinBindingSource.DataSource = $"subString(CIN,1,1)='{textCIN.Text}'";

        }
    }
}
