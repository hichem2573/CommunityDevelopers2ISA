namespace CommunityDevelopers2ISAWinForm
{
    partial class FrmAjoutReponse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAjoutReponse));
            this.tabLayPanAjoutReponse = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxReponse = new System.Windows.Forms.TextBox();
            this.floLayPan = new System.Windows.Forms.FlowLayoutPanel();
            this.btAjoutReponse = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.tabLayPanAjoutReponse.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.floLayPan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLayPanAjoutReponse
            // 
            this.tabLayPanAjoutReponse.ColumnCount = 3;
            this.tabLayPanAjoutReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.478873F));
            this.tabLayPanAjoutReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.52113F));
            this.tabLayPanAjoutReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabLayPanAjoutReponse.Controls.Add(this.groupBox1, 1, 1);
            this.tabLayPanAjoutReponse.Controls.Add(this.floLayPan, 1, 2);
            this.tabLayPanAjoutReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLayPanAjoutReponse.Location = new System.Drawing.Point(0, 0);
            this.tabLayPanAjoutReponse.Name = "tabLayPanAjoutReponse";
            this.tabLayPanAjoutReponse.RowCount = 4;
            this.tabLayPanAjoutReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.40816F));
            this.tabLayPanAjoutReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.59184F));
            this.tabLayPanAjoutReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tabLayPanAjoutReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tabLayPanAjoutReponse.Size = new System.Drawing.Size(376, 339);
            this.tabLayPanAjoutReponse.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxReponse);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(26, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Texte de la réponse: ";
            // 
            // txtBoxReponse
            // 
            this.txtBoxReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxReponse.Location = new System.Drawing.Point(3, 16);
            this.txtBoxReponse.Multiline = true;
            this.txtBoxReponse.Name = "txtBoxReponse";
            this.txtBoxReponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxReponse.Size = new System.Drawing.Size(320, 150);
            this.txtBoxReponse.TabIndex = 0;
            // 
            // floLayPan
            // 
            this.floLayPan.Controls.Add(this.btAjoutReponse);
            this.floLayPan.Controls.Add(this.btAnnuler);
            this.floLayPan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floLayPan.Location = new System.Drawing.Point(26, 222);
            this.floLayPan.Name = "floLayPan";
            this.floLayPan.Size = new System.Drawing.Size(326, 78);
            this.floLayPan.TabIndex = 1;
            // 
            // btAjoutReponse
            // 
            this.btAjoutReponse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAjoutReponse.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.ajouter_un_message;
            this.btAjoutReponse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAjoutReponse.Location = new System.Drawing.Point(19, 19);
            this.btAjoutReponse.Margin = new System.Windows.Forms.Padding(19, 19, 3, 3);
            this.btAjoutReponse.Name = "btAjoutReponse";
            this.btAjoutReponse.Size = new System.Drawing.Size(139, 38);
            this.btAjoutReponse.TabIndex = 0;
            this.btAjoutReponse.Text = "&Ajouter la réponse";
            this.btAjoutReponse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAjoutReponse.UseVisualStyleBackColor = true;
            this.btAjoutReponse.Click += new System.EventHandler(this.btAjoutReponse_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnnuler.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.annuler_icone_8717_32;
            this.btAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnnuler.Location = new System.Drawing.Point(180, 19);
            this.btAnnuler.Margin = new System.Windows.Forms.Padding(19, 19, 15, 3);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(130, 38);
            this.btAnnuler.TabIndex = 1;
            this.btAnnuler.Text = "&Annuler";
            this.btAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // FrmAjoutReponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(376, 339);
            this.Controls.Add(this.tabLayPanAjoutReponse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(392, 378);
            this.MinimumSize = new System.Drawing.Size(380, 366);
            this.Name = "FrmAjoutReponse";
            this.Text = "Ajouter une réponse";
            this.tabLayPanAjoutReponse.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.floLayPan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabLayPanAjoutReponse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxReponse;
        private System.Windows.Forms.FlowLayoutPanel floLayPan;
        private System.Windows.Forms.Button btAjoutReponse;
        private System.Windows.Forms.Button btAnnuler;
    }
}