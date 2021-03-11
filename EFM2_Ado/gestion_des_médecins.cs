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
    public partial class gestion_des_médecins : Form
    {
        static Global g1 = new Global();
        DataSet Ds_hopital = new DataSet();
        SqlDataAdapter Adp_Medecin = new SqlDataAdapter("select * from Medecin", g1.hopital_connexion);
        SqlDataAdapter Adp_Specialite = new SqlDataAdapter("select * from Specialite", g1.hopital_connexion);
        BindingManagerBase bmbMedecin;
        public gestion_des_médecins()
        {
            InitializeComponent();
        }

        private void gestion_des_médecins_Load(object sender, EventArgs e)
        {

            Adp_Medecin.Fill(Ds_hopital, "Medecins");
            Adp_Specialite.Fill(Ds_hopital, "Specialites");
            bmbMedecin = BindingContext[Ds_hopital.Tables["Medecins"]];

            textIdMedcin.DataBindings.Add("Text", Ds_hopital.Tables["Medecins"], "idMedecin");
            textCIN.DataBindings.Add("Text", Ds_hopital.Tables["Medecins"], "CIN");
            textNom.DataBindings.Add("Text", Ds_hopital.Tables["Medecins"], "Nom");
            textPrenom.DataBindings.Add("Text", Ds_hopital.Tables["Medecins"], "Prenom");
            textTel.DataBindings.Add("Text", Ds_hopital.Tables["Medecins"], "Telephone");
            cmbSpecialite.DataBindings.Add("Text", Ds_hopital.Tables["Medecins"], "idSpecialite");

            dgvListeMedecins.DataSource = Ds_hopital.Tables["Medecins"];
            cmbSpecialite.DataSource = Ds_hopital.Tables["Specialites"];
            cmbSpecialite.DisplayMember = "idSpecialite";
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            bmbMedecin.Position = 0;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            bmbMedecin.Position ++;

        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            bmbMedecin.Position --;

        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
           bmbMedecin.Position = bmbMedecin.Count -1;

        }
        Boolean BL = false;

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (textIdMedcin.Text != "" && textCIN.Text != "" && textNom.Text != "" && textPrenom.Text != "" && textTel.Text != "" )
            {
                try
                {
                    
                    bmbMedecin.EndCurrentEdit();
                    BL = true;
                    dgvListeMedecins.Refresh();
                    MessageBox.Show("Medecin inséré", "Ajout Medecin", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    bmbMedecin.AddNew();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur1 : " + ex.Message, "Erreur", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Remplir les champs");
            }
        }

        private void btnModification_Click(object sender, EventArgs e)
        {
            bmbMedecin.EndCurrentEdit();
            BL = true;
            MessageBox.Show("Medecin modifié", "Modification Medecin", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSuppression_Click(object sender, EventArgs e)
        {
            bmbMedecin.RemoveAt(bmbMedecin.Position);
            BL = true;
            MessageBox.Show("Medecin supprimé", "Suppression Medecin", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
           
        }

        private void btnSauvgarder_Click(object sender, EventArgs e)
        {
            if (BL)
            {
                try
                {
                    SqlCommandBuilder Bld = new SqlCommandBuilder(Adp_Medecin);
                    Adp_Medecin.Update(Ds_hopital.Tables["Medecins"]);
                    MessageBox.Show("Sauvgarder");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur2 : " + ex.Message, "Erreur", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnNouveu_Click(object sender, EventArgs e)
        {
            bmbMedecin.AddNew();

        }
    }
}
