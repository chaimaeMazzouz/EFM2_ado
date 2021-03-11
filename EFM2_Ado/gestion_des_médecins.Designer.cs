namespace EFM2_Ado
{
    partial class gestion_des_médecins
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
            this.dgvListeMedecins = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textIdMedcin = new System.Windows.Forms.TextBox();
            this.textCIN = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.cmbSpecialite = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuppression = new System.Windows.Forms.Button();
            this.btnModification = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnSauvgarder = new System.Windows.Forms.Button();
            this.btnNouveu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeMedecins)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListeMedecins
            // 
            this.dgvListeMedecins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeMedecins.Location = new System.Drawing.Point(29, 324);
            this.dgvListeMedecins.Name = "dgvListeMedecins";
            this.dgvListeMedecins.Size = new System.Drawing.Size(868, 150);
            this.dgvListeMedecins.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion des médecins";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Medecin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "CIN ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Id Specialite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telephone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Prenom";
            // 
            // textIdMedcin
            // 
            this.textIdMedcin.Location = new System.Drawing.Point(123, 64);
            this.textIdMedcin.Name = "textIdMedcin";
            this.textIdMedcin.Size = new System.Drawing.Size(137, 20);
            this.textIdMedcin.TabIndex = 8;
            // 
            // textCIN
            // 
            this.textCIN.Location = new System.Drawing.Point(123, 103);
            this.textCIN.Name = "textCIN";
            this.textCIN.Size = new System.Drawing.Size(137, 20);
            this.textCIN.TabIndex = 9;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(123, 178);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(137, 20);
            this.textPrenom.TabIndex = 11;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(123, 139);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(137, 20);
            this.textNom.TabIndex = 10;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(123, 211);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(137, 20);
            this.textTel.TabIndex = 12;
            // 
            // cmbSpecialite
            // 
            this.cmbSpecialite.FormattingEnabled = true;
            this.cmbSpecialite.Location = new System.Drawing.Point(123, 254);
            this.cmbSpecialite.Name = "cmbSpecialite";
            this.cmbSpecialite.Size = new System.Drawing.Size(137, 21);
            this.cmbSpecialite.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDernier);
            this.groupBox1.Controls.Add(this.btnPrecedent);
            this.groupBox1.Controls.Add(this.btnSuivant);
            this.groupBox1.Controls.Add(this.btnPremier);
            this.groupBox1.Location = new System.Drawing.Point(321, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 72);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navigation";
            // 
            // btnPremier
            // 
            this.btnPremier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPremier.Location = new System.Drawing.Point(30, 23);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(95, 36);
            this.btnPremier.TabIndex = 0;
            this.btnPremier.Text = "Premier";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuivant.Location = new System.Drawing.Point(152, 23);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(95, 36);
            this.btnSuivant.TabIndex = 1;
            this.btnSuivant.Text = "Suivant";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDernier.Location = new System.Drawing.Point(435, 23);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(95, 36);
            this.btnDernier.TabIndex = 3;
            this.btnDernier.Text = "Dernier";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.Location = new System.Drawing.Point(313, 23);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(95, 36);
            this.btnPrecedent.TabIndex = 2;
            this.btnPrecedent.Text = "précédent";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNouveu);
            this.groupBox2.Controls.Add(this.btnSauvgarder);
            this.groupBox2.Controls.Add(this.btnSuppression);
            this.groupBox2.Controls.Add(this.btnModification);
            this.groupBox2.Controls.Add(this.btnAjout);
            this.groupBox2.Location = new System.Drawing.Point(321, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 72);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opération";
            // 
            // btnSuppression
            // 
            this.btnSuppression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppression.Location = new System.Drawing.Point(347, 20);
            this.btnSuppression.Name = "btnSuppression";
            this.btnSuppression.Size = new System.Drawing.Size(108, 36);
            this.btnSuppression.TabIndex = 2;
            this.btnSuppression.Text = "Suppression";
            this.btnSuppression.UseVisualStyleBackColor = true;
            this.btnSuppression.Click += new System.EventHandler(this.btnSuppression_Click);
            // 
            // btnModification
            // 
            this.btnModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModification.Location = new System.Drawing.Point(229, 20);
            this.btnModification.Name = "btnModification";
            this.btnModification.Size = new System.Drawing.Size(112, 36);
            this.btnModification.TabIndex = 1;
            this.btnModification.Text = "Modification";
            this.btnModification.UseVisualStyleBackColor = true;
            this.btnModification.Click += new System.EventHandler(this.btnModification_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(118, 20);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(105, 36);
            this.btnAjout.TabIndex = 0;
            this.btnAjout.Text = "Ajout";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnSauvgarder
            // 
            this.btnSauvgarder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSauvgarder.Location = new System.Drawing.Point(461, 20);
            this.btnSauvgarder.Name = "btnSauvgarder";
            this.btnSauvgarder.Size = new System.Drawing.Size(109, 36);
            this.btnSauvgarder.TabIndex = 3;
            this.btnSauvgarder.Text = "Sauvgarder";
            this.btnSauvgarder.UseVisualStyleBackColor = true;
            this.btnSauvgarder.Click += new System.EventHandler(this.btnSauvgarder_Click);
            // 
            // btnNouveu
            // 
            this.btnNouveu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveu.Location = new System.Drawing.Point(7, 19);
            this.btnNouveu.Name = "btnNouveu";
            this.btnNouveu.Size = new System.Drawing.Size(105, 36);
            this.btnNouveu.TabIndex = 4;
            this.btnNouveu.Text = "Nouveu";
            this.btnNouveu.UseVisualStyleBackColor = true;
            this.btnNouveu.Click += new System.EventHandler(this.btnNouveu_Click);
            // 
            // gestion_des_médecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbSpecialite);
            this.Controls.Add(this.textTel);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textCIN);
            this.Controls.Add(this.textIdMedcin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListeMedecins);
            this.Name = "gestion_des_médecins";
            this.Text = "gestion_des_médecins";
            this.Load += new System.EventHandler(this.gestion_des_médecins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeMedecins)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListeMedecins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textIdMedcin;
        private System.Windows.Forms.TextBox textCIN;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.ComboBox cmbSpecialite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSuppression;
        private System.Windows.Forms.Button btnModification;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnSauvgarder;
        private System.Windows.Forms.Button btnNouveu;
    }
}