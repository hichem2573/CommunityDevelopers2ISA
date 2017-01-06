namespace CommunityDevelopers2ISAWinForm
{
    partial class FrmAjoutSujet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutSujet));
            this.tblPanelAjoutSujet = new System.Windows.Forms.TableLayoutPanel();
            this.grBoxTitreSujet = new System.Windows.Forms.GroupBox();
            this.txtBoxTitreSujet = new System.Windows.Forms.TextBox();
            this.grBoxDescSujet = new System.Windows.Forms.GroupBox();
            this.txtBoxDescSujet = new System.Windows.Forms.TextBox();
            this.floLayPanAjout = new System.Windows.Forms.FlowLayoutPanel();
            this.btValidation = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.tblPanelAjoutSujet.SuspendLayout();
            this.grBoxTitreSujet.SuspendLayout();
            this.grBoxDescSujet.SuspendLayout();
            this.floLayPanAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPanelAjoutSujet
            // 
            this.tblPanelAjoutSujet.ColumnCount = 3;
            this.tblPanelAjoutSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelAjoutSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tblPanelAjoutSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanelAjoutSujet.Controls.Add(this.grBoxTitreSujet, 1, 1);
            this.tblPanelAjoutSujet.Controls.Add(this.grBoxDescSujet, 1, 2);
            this.tblPanelAjoutSujet.Controls.Add(this.floLayPanAjout, 1, 3);
            this.tblPanelAjoutSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelAjoutSujet.Location = new System.Drawing.Point(0, 0);
            this.tblPanelAjoutSujet.Name = "tblPanelAjoutSujet";
            this.tblPanelAjoutSujet.RowCount = 5;
            this.tblPanelAjoutSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.81818F));
            this.tblPanelAjoutSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.18182F));
            this.tblPanelAjoutSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tblPanelAjoutSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tblPanelAjoutSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPanelAjoutSujet.Size = new System.Drawing.Size(421, 364);
            this.tblPanelAjoutSujet.TabIndex = 0;
            // 
            // grBoxTitreSujet
            // 
            this.grBoxTitreSujet.Controls.Add(this.txtBoxTitreSujet);
            this.grBoxTitreSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxTitreSujet.Location = new System.Drawing.Point(24, 27);
            this.grBoxTitreSujet.Name = "grBoxTitreSujet";
            this.grBoxTitreSujet.Size = new System.Drawing.Size(374, 80);
            this.grBoxTitreSujet.TabIndex = 0;
            this.grBoxTitreSujet.TabStop = false;
            this.grBoxTitreSujet.Text = "Titre : ";
            // 
            // txtBoxTitreSujet
            // 
            this.txtBoxTitreSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxTitreSujet.Location = new System.Drawing.Point(3, 16);
            this.txtBoxTitreSujet.Name = "txtBoxTitreSujet";
            this.txtBoxTitreSujet.Size = new System.Drawing.Size(368, 20);
            this.txtBoxTitreSujet.TabIndex = 0;
            this.txtBoxTitreSujet.Text = " Veuillez saisir votre titre";
           
            // 
            // grBoxDescSujet
            // 
            this.grBoxDescSujet.Controls.Add(this.txtBoxDescSujet);
            this.grBoxDescSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxDescSujet.Location = new System.Drawing.Point(24, 113);
            this.grBoxDescSujet.Name = "grBoxDescSujet";
            this.grBoxDescSujet.Size = new System.Drawing.Size(374, 149);
            this.grBoxDescSujet.TabIndex = 1;
            this.grBoxDescSujet.TabStop = false;
            this.grBoxDescSujet.Text = "Description  du Sujet : ";
            // 
            // txtBoxDescSujet
            // 
            this.txtBoxDescSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxDescSujet.Location = new System.Drawing.Point(3, 16);
            this.txtBoxDescSujet.Multiline = true;
            this.txtBoxDescSujet.Name = "txtBoxDescSujet";
            this.txtBoxDescSujet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDescSujet.Size = new System.Drawing.Size(368, 130);
            this.txtBoxDescSujet.TabIndex = 0;
            
            // 
            // floLayPanAjout
            // 
            this.floLayPanAjout.Controls.Add(this.btValidation);
            this.floLayPanAjout.Controls.Add(this.btAnnuler);
            this.floLayPanAjout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floLayPanAjout.Location = new System.Drawing.Point(24, 268);
            this.floLayPanAjout.Name = "floLayPanAjout";
            this.floLayPanAjout.Size = new System.Drawing.Size(374, 72);
            this.floLayPanAjout.TabIndex = 2;
            // 
            // btValidation
            // 
            this.btValidation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btValidation.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.ajouter;
            this.btValidation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btValidation.Location = new System.Drawing.Point(15, 15);
            this.btValidation.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.btValidation.Name = "btValidation";
            this.btValidation.Size = new System.Drawing.Size(131, 46);
            this.btValidation.TabIndex = 0;
            this.btValidation.Text = "&Valider";
            this.btValidation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btValidation.UseVisualStyleBackColor = true;
            this.btValidation.Click += new System.EventHandler(this.btValidation_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnnuler.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.annuler_icone_8717_32;
            this.btAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnnuler.Location = new System.Drawing.Point(209, 15);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(60, 15, 15, 3);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(140, 46);
            this.btAnnuler.TabIndex = 1;
            this.btAnnuler.Text = "&Annuler";
            this.btAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // FrmAjoutSujet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(421, 364);
            this.Controls.Add(this.tblPanelAjoutSujet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(437, 403);
            this.MinimumSize = new System.Drawing.Size(427, 393);
            this.Name = "FrmAjoutSujet";
            this.Text = "Ajouter ou modifier sujet";
            this.Load += new System.EventHandler(this.FrmAjoutSujet_Load);
            this.tblPanelAjoutSujet.ResumeLayout(false);
            this.grBoxTitreSujet.ResumeLayout(false);
            this.grBoxTitreSujet.PerformLayout();
            this.grBoxDescSujet.ResumeLayout(false);
            this.grBoxDescSujet.PerformLayout();
            this.floLayPanAjout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanelAjoutSujet;
        private System.Windows.Forms.GroupBox grBoxTitreSujet;
        private System.Windows.Forms.TextBox txtBoxTitreSujet;
        private System.Windows.Forms.GroupBox grBoxDescSujet;
        private System.Windows.Forms.TextBox txtBoxDescSujet;
        private System.Windows.Forms.FlowLayoutPanel floLayPanAjout;
        private System.Windows.Forms.Button btValidation;
        private System.Windows.Forms.Button btAnnuler;
    }
}