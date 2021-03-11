namespace EFM2_Ado
{
    partial class Gestion_Operation
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
            this.nombreDoperation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.specialite = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateSpecifier = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdOp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Libelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CodeOperation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.dataSetHotel = new EFM2_Ado.DataSetHotel();
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.operationTableAdapter = new EFM2_Ado.DataSetHotelTableAdapters.OperationTableAdapter();
            this.idOperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelleopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOperation = new System.Windows.Forms.DateTimePicker();
            this.prixOperation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.durreOperation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.operationLibelle = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CinMedecin = new System.Windows.Forms.ComboBox();
            this.NouveauLigne = new System.Windows.Forms.Button();
            this.Affecter = new System.Windows.Forms.Button();
            this.ligneMedecinOperationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligneMedecinOperationTableAdapter = new EFM2_Ado.DataSetHotelTableAdapters.LigneMedecinOperationTableAdapter();
            this.medecinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medecinTableAdapter = new EFM2_Ado.DataSetHotelTableAdapters.MedecinTableAdapter();
            this.dateOperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOperationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ligneMedecinOperationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreDoperation
            // 
            this.nombreDoperation.Location = new System.Drawing.Point(211, 86);
            this.nombreDoperation.Name = "nombreDoperation";
            this.nombreDoperation.Size = new System.Drawing.Size(100, 20);
            this.nombreDoperation.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Get Nombre d\'operation";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "specialite";
            // 
            // specialite
            // 
            this.specialite.DisplayMember = "libelle";
            this.specialite.FormattingEnabled = true;
            this.specialite.Location = new System.Drawing.Point(190, 44);
            this.specialite.Name = "specialite";
            this.specialite.Size = new System.Drawing.Size(121, 21);
            this.specialite.TabIndex = 48;
            this.specialite.ValueMember = "idSpecialite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Date";
            // 
            // dateSpecifier
            // 
            this.dateSpecifier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSpecifier.Location = new System.Drawing.Point(190, 18);
            this.dateSpecifier.Name = "dateSpecifier";
            this.dateSpecifier.Size = new System.Drawing.Size(121, 20);
            this.dateSpecifier.TabIndex = 46;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOperationDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.libelleopDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.operationBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(24, 283);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(347, 150);
            this.dataGridView2.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOperationDataGridViewTextBoxColumn,
            this.dureeDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn,
            this.idOperationDataGridViewTextBoxColumn1,
            this.idMedecinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ligneMedecinOperationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(377, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(399, 150);
            this.dataGridView1.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Ajouter);
            this.groupBox1.Controls.Add(this.Nouveau);
            this.groupBox1.Controls.Add(this.txtIdOp);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.Libelle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CodeOperation);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 131);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // txtIdOp
            // 
            this.txtIdOp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationBindingSource, "idOperation", true));
            this.txtIdOp.Location = new System.Drawing.Point(85, 17);
            this.txtIdOp.Name = "txtIdOp";
            this.txtIdOp.Size = new System.Drawing.Size(100, 20);
            this.txtIdOp.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "id Operation";
            // 
            // Libelle
            // 
            this.Libelle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationBindingSource, "libelle_op", true));
            this.Libelle.Location = new System.Drawing.Point(85, 84);
            this.Libelle.Name = "Libelle";
            this.Libelle.Size = new System.Drawing.Size(100, 20);
            this.Libelle.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Libelle";
            // 
            // CodeOperation
            // 
            this.CodeOperation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationBindingSource, "code", true));
            this.CodeOperation.Location = new System.Drawing.Point(85, 49);
            this.CodeOperation.Name = "CodeOperation";
            this.CodeOperation.Size = new System.Drawing.Size(100, 20);
            this.CodeOperation.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Code";
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(207, 66);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 61;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Nouveau
            // 
            this.Nouveau.Location = new System.Drawing.Point(207, 20);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(75, 23);
            this.Nouveau.TabIndex = 60;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // dataSetHotel
            // 
            this.dataSetHotel.DataSetName = "DataSetHotel";
            this.dataSetHotel.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operationBindingSource
            // 
            this.operationBindingSource.DataMember = "Operation";
            this.operationBindingSource.DataSource = this.dataSetHotel;
            // 
            // operationTableAdapter
            // 
            this.operationTableAdapter.ClearBeforeFill = true;
            // 
            // idOperationDataGridViewTextBoxColumn
            // 
            this.idOperationDataGridViewTextBoxColumn.DataPropertyName = "idOperation";
            this.idOperationDataGridViewTextBoxColumn.HeaderText = "idOperation";
            this.idOperationDataGridViewTextBoxColumn.Name = "idOperationDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // libelleopDataGridViewTextBoxColumn
            // 
            this.libelleopDataGridViewTextBoxColumn.DataPropertyName = "libelle_op";
            this.libelleopDataGridViewTextBoxColumn.HeaderText = "libelle_op";
            this.libelleopDataGridViewTextBoxColumn.Name = "libelleopDataGridViewTextBoxColumn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NouveauLigne);
            this.groupBox2.Controls.Add(this.Affecter);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateOperation);
            this.groupBox2.Controls.Add(this.prixOperation);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.durreOperation);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.operationLibelle);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CinMedecin);
            this.groupBox2.Location = new System.Drawing.Point(396, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 248);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affectation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Date d\'operation";
            // 
            // dateOperation
            // 
            this.dateOperation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligneMedecinOperationBindingSource, "dateOperation", true));
            this.dateOperation.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ligneMedecinOperationBindingSource, "dateOperation", true));
            this.dateOperation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOperation.Location = new System.Drawing.Point(120, 122);
            this.dateOperation.Name = "dateOperation";
            this.dateOperation.Size = new System.Drawing.Size(121, 20);
            this.dateOperation.TabIndex = 51;
            // 
            // prixOperation
            // 
            this.prixOperation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligneMedecinOperationBindingSource, "prix", true));
            this.prixOperation.Location = new System.Drawing.Point(120, 222);
            this.prixOperation.Name = "prixOperation";
            this.prixOperation.Size = new System.Drawing.Size(121, 20);
            this.prixOperation.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Prix";
            // 
            // durreOperation
            // 
            this.durreOperation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligneMedecinOperationBindingSource, "duree", true));
            this.durreOperation.Location = new System.Drawing.Point(120, 168);
            this.durreOperation.Name = "durreOperation";
            this.durreOperation.Size = new System.Drawing.Size(121, 20);
            this.durreOperation.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Durre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Operation";
            // 
            // operationLibelle
            // 
            this.operationLibelle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationBindingSource, "libelle_op", true));
            this.operationLibelle.DisplayMember = "libelle";
            this.operationLibelle.FormattingEnabled = true;
            this.operationLibelle.Location = new System.Drawing.Point(120, 60);
            this.operationLibelle.Name = "operationLibelle";
            this.operationLibelle.Size = new System.Drawing.Size(121, 21);
            this.operationLibelle.TabIndex = 45;
            this.operationLibelle.ValueMember = "idOperation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cin";
            // 
            // CinMedecin
            // 
            this.CinMedecin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medecinBindingSource, "CIN", true));
            this.CinMedecin.DisplayMember = "cin";
            this.CinMedecin.FormattingEnabled = true;
            this.CinMedecin.Location = new System.Drawing.Point(120, 21);
            this.CinMedecin.Name = "CinMedecin";
            this.CinMedecin.Size = new System.Drawing.Size(121, 21);
            this.CinMedecin.TabIndex = 43;
            this.CinMedecin.ValueMember = "idMedecin";
            // 
            // NouveauLigne
            // 
            this.NouveauLigne.Location = new System.Drawing.Point(259, 85);
            this.NouveauLigne.Name = "NouveauLigne";
            this.NouveauLigne.Size = new System.Drawing.Size(75, 23);
            this.NouveauLigne.TabIndex = 54;
            this.NouveauLigne.Text = "Nouveau";
            this.NouveauLigne.UseVisualStyleBackColor = true;
            this.NouveauLigne.Click += new System.EventHandler(this.NouveauLigne_Click);
            // 
            // Affecter
            // 
            this.Affecter.Location = new System.Drawing.Point(259, 146);
            this.Affecter.Name = "Affecter";
            this.Affecter.Size = new System.Drawing.Size(75, 23);
            this.Affecter.TabIndex = 53;
            this.Affecter.Text = "Affecter";
            this.Affecter.UseVisualStyleBackColor = true;
            this.Affecter.Click += new System.EventHandler(this.Affecter_Click);
            // 
            // ligneMedecinOperationBindingSource
            // 
            this.ligneMedecinOperationBindingSource.DataMember = "LigneMedecinOperation";
            this.ligneMedecinOperationBindingSource.DataSource = this.dataSetHotel;
            // 
            // ligneMedecinOperationTableAdapter
            // 
            this.ligneMedecinOperationTableAdapter.ClearBeforeFill = true;
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
            // dateOperationDataGridViewTextBoxColumn
            // 
            this.dateOperationDataGridViewTextBoxColumn.DataPropertyName = "dateOperation";
            this.dateOperationDataGridViewTextBoxColumn.HeaderText = "dateOperation";
            this.dateOperationDataGridViewTextBoxColumn.Name = "dateOperationDataGridViewTextBoxColumn";
            // 
            // dureeDataGridViewTextBoxColumn
            // 
            this.dureeDataGridViewTextBoxColumn.DataPropertyName = "duree";
            this.dureeDataGridViewTextBoxColumn.HeaderText = "duree";
            this.dureeDataGridViewTextBoxColumn.Name = "dureeDataGridViewTextBoxColumn";
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            // 
            // idOperationDataGridViewTextBoxColumn1
            // 
            this.idOperationDataGridViewTextBoxColumn1.DataPropertyName = "idOperation";
            this.idOperationDataGridViewTextBoxColumn1.HeaderText = "idOperation";
            this.idOperationDataGridViewTextBoxColumn1.Name = "idOperationDataGridViewTextBoxColumn1";
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            // 
            // Gestion_Operation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nombreDoperation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.specialite);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateSpecifier);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Gestion_Operation";
            this.Text = "Gestion_Operation";
            this.Load += new System.EventHandler(this.Gestion_Operation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ligneMedecinOperationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medecinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreDoperation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox specialite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateSpecifier;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.TextBox txtIdOp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Libelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodeOperation;
        private System.Windows.Forms.Label label1;
        private DataSetHotel dataSetHotel;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private DataSetHotelTableAdapters.OperationTableAdapter operationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelleopDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button NouveauLigne;
        private System.Windows.Forms.Button Affecter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateOperation;
        private System.Windows.Forms.TextBox prixOperation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox durreOperation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox operationLibelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CinMedecin;
        private System.Windows.Forms.BindingSource ligneMedecinOperationBindingSource;
        private DataSetHotelTableAdapters.LigneMedecinOperationTableAdapter ligneMedecinOperationTableAdapter;
        private System.Windows.Forms.BindingSource medecinBindingSource;
        private DataSetHotelTableAdapters.MedecinTableAdapter medecinTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOperationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
    }
}