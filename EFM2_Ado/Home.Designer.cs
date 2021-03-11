namespace EFM2_Ado
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesMédecinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheDunMédecinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesMédecinsToolStripMenuItem,
            this.rechercheDunMédecinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gestionDesMédecinsToolStripMenuItem
            // 
            this.gestionDesMédecinsToolStripMenuItem.Name = "gestionDesMédecinsToolStripMenuItem";
            this.gestionDesMédecinsToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.gestionDesMédecinsToolStripMenuItem.Text = "gestion des médecins";
            this.gestionDesMédecinsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesMédecinsToolStripMenuItem_Click);
            // 
            // rechercheDunMédecinToolStripMenuItem
            // 
            this.rechercheDunMédecinToolStripMenuItem.Name = "rechercheDunMédecinToolStripMenuItem";
            this.rechercheDunMédecinToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.rechercheDunMédecinToolStripMenuItem.Text = "recherche d’un médecin";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Gestion d\'hôpital";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesMédecinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheDunMédecinToolStripMenuItem;
    }
}

