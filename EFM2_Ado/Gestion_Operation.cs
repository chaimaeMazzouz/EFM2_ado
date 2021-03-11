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
    public partial class Gestion_Operation : Form
    {
        public Gestion_Operation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gestion_Operation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetHotel.Medecin' table. You can move, or remove it, as needed.
            this.medecinTableAdapter.Fill(this.dataSetHotel.Medecin);
            // TODO: This line of code loads data into the 'dataSetHotel.LigneMedecinOperation' table. You can move, or remove it, as needed.
            this.ligneMedecinOperationTableAdapter.Fill(this.dataSetHotel.LigneMedecinOperation);
            // TODO: This line of code loads data into the 'dataSetHotel.Operation' table. You can move, or remove it, as needed.
            this.operationTableAdapter.Fill(this.dataSetHotel.Operation);

        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            this.operationBindingSource.AddNew();

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (txtIdOp.Text !="" && CodeOperation.Text !="" && Libelle.Text !="" )
            {
                try
                {
                    this.operationBindingSource.EndEdit();
                    this.operationTableAdapter.Update(this.dataSetHotel.Operation);
                    MessageBox.Show("Ajouter", "termine");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Remplir les champs");

            }

        }

        private void NouveauLigne_Click(object sender, EventArgs e)
        {
            this.ligneMedecinOperationBindingSource.AddNew();

        }

        private void Affecter_Click(object sender, EventArgs e)
        {
            //DataRelation dr = new DataRelation("rr",this.dataSetHotel.Medecin.idMedecinColumn,this.dataSetHotel.LigneMedecinOperation.idMedecinColumn);
            //this.dataSetHotel.Relations.Add(dr);
            if (durreOperation.Text != "" && prixOperation.Text != "" )
            {
                try
                {
                    this.ligneMedecinOperationBindingSource.EndEdit();
                    this.ligneMedecinOperationTableAdapter.Update(this.dataSetHotel.LigneMedecinOperation);
                    MessageBox.Show("Affecter", "termine");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
            {
                MessageBox.Show("Remplir les champs");

            }
        }
    }
}
