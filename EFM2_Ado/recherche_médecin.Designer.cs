namespace EFM2_Ado
{
    partial class recherche_médecin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textCIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListeMedecins = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataSetHotel = new EFM2_Ado.DataSetHotel();
            this.medecinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinTableAdapter = new EFM2_Ado.DataSetHotelTableAdapters.MedecinTableAdapter();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSpecialiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeMedecins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textNom
            // 
            this.textNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinBindingSource, "Nom", true));
            this.textNom.Location = new System.Drawing.Point(599, 107);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(137, 20);
            this.textNom.TabIndex = 16;
            // 
            // textCIN
            // 
            this.textCIN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinBindingSource, "CIN", true));
            this.textCIN.Location = new System.Drawing.Point(351, 104);
            this.textCIN.Name = "textCIN";
            this.textCIN.Size = new System.Drawing.Size(137, 20);
            this.textCIN.TabIndex = 15;
            this.textCIN.TextChanged += new System.EventHandler(this.textCIN_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "CIN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Medecin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Recherche d’un médecin";
            // 
            // dgvListeMedecins
            // 
            this.dgvListeMedecins.AutoGenerateColumns = false;
            this.dgvListeMedecins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeMedecins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedecinDataGridViewTextBoxColumn,
            this.cINDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.idSpecialiteDataGridViewTextBoxColumn});
            this.dgvListeMedecins.DataSource = this.medecinBindingSource;
            this.dgvListeMedecins.Location = new System.Drawing.Point(26, 173);
            this.dgvListeMedecins.Name = "dgvListeMedecins";
            this.dgvListeMedecins.Size = new System.Drawing.Size(724, 150);
            this.dgvListeMedecins.TabIndex = 18;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.medecinBindingSource;
            this.comboBox1.DisplayMember = "idMedecin";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "idMedecin";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataSetHotel
            // 
            this.dataSetHotel.DataSetName = "DataSetHotel";
            this.dataSetHotel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medecinBindingSource
            // 
            this.medecinBindingSource.DataMember = "Medecin";
            this.medecinBindingSource.DataSource = this.dataSetHotel;
            // 
            // medecinTableAdapter
            // 
            this.medecinTableAdapter.ClearBeforeFill = true;
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            // 
            // cINDataGridViewTextBoxColumn
            // 
            this.cINDataGridViewTextBoxColumn.DataPropertyName = "CIN";
            this.cINDataGridViewTextBoxColumn.HeaderText = "CIN";
            this.cINDataGridViewTextBoxColumn.Name = "cINDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // idSpecialiteDataGridViewTextBoxColumn
            // 
            this.idSpecialiteDataGridViewTextBoxColumn.DataPropertyName = "idSpecialite";
            this.idSpecialiteDataGridViewTextBoxColumn.HeaderText = "idSpecialite";
            this.idSpecialiteDataGridViewTextBoxColumn.Name = "idSpecialiteDataGridViewTextBoxColumn";
            // 
            // recherche_médecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 351);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvListeMedecins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textCIN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "recherche_médecin";
            this.Text = "recherche_médecin";
            this.Load += new System.EventHandler(this.recherche_médecin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeMedecins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textCIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListeMedecins;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSetHotel dataSetHotel;
        private System.Windows.Forms.BindingSource medecinBindingSource;
        private DataSetHotelTableAdapters.MedecinTableAdapter medecinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSpecialiteDataGridViewTextBoxColumn;
    }
}