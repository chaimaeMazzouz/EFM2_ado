using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFM2_Ado
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        void Changer_Form(Form NewForm)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            NewForm.MdiParent = this;
            NewForm.Dock = DockStyle.Fill;
            NewForm.Show();
        }
        private void gestionDesMédecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new gestion_des_médecins());

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Changer_Form(new recherche_médecin());

        }
    }
}
