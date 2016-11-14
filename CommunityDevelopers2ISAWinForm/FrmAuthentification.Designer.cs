namespace CommunityDevelopers2ISAWinForm
{
    partial class FrmAuthentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuthentification));
            this.tlPanelAuthentification = new System.Windows.Forms.TableLayoutPanel();
            this.plLoginPassword = new System.Windows.Forms.Panel();
            this.gpAuthentification = new System.Windows.Forms.GroupBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.plValidation = new System.Windows.Forms.Panel();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.tlPanelAuthentification.SuspendLayout();
            this.plLoginPassword.SuspendLayout();
            this.gpAuthentification.SuspendLayout();
            this.plValidation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPanelAuthentification
            // 
            this.tlPanelAuthentification.ColumnCount = 1;
            this.tlPanelAuthentification.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanelAuthentification.Controls.Add(this.plLoginPassword, 0, 0);
            this.tlPanelAuthentification.Controls.Add(this.plValidation, 0, 2);
            this.tlPanelAuthentification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelAuthentification.Location = new System.Drawing.Point(0, 0);
            this.tlPanelAuthentification.Name = "tlPanelAuthentification";
            this.tlPanelAuthentification.RowCount = 3;
            this.tlPanelAuthentification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.38562F));
            this.tlPanelAuthentification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.614379F));
            this.tlPanelAuthentification.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlPanelAuthentification.Size = new System.Drawing.Size(384, 362);
            this.tlPanelAuthentification.TabIndex = 0;
            // 
            // plLoginPassword
            // 
            this.plLoginPassword.Controls.Add(this.gpAuthentification);
            this.plLoginPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plLoginPassword.Location = new System.Drawing.Point(3, 3);
            this.plLoginPassword.Name = "plLoginPassword";
            this.plLoginPassword.Size = new System.Drawing.Size(378, 292);
            this.plLoginPassword.TabIndex = 0;
            // 
            // gpAuthentification
            // 
            this.gpAuthentification.Controls.Add(this.txtBoxPassword);
            this.gpAuthentification.Controls.Add(this.txtBoxLogin);
            this.gpAuthentification.Controls.Add(this.label2);
            this.gpAuthentification.Controls.Add(this.lblLogin);
            this.gpAuthentification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpAuthentification.Location = new System.Drawing.Point(0, 0);
            this.gpAuthentification.Name = "gpAuthentification";
            this.gpAuthentification.Size = new System.Drawing.Size(378, 292);
            this.gpAuthentification.TabIndex = 0;
            this.gpAuthentification.TabStop = false;
            this.gpAuthentification.Text = "Authentification";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxPassword.Location = new System.Drawing.Point(164, 161);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(165, 20);
            this.txtBoxPassword.TabIndex = 3;
            this.txtBoxPassword.Text = "Mot de passe ";
            // 
            // txtBoxLogin
            // 
            this.txtBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxLogin.Location = new System.Drawing.Point(164, 78);
            this.txtBoxLogin.Name = "txtBoxLogin";
            this.txtBoxLogin.Size = new System.Drawing.Size(165, 20);
            this.txtBoxLogin.TabIndex = 1;
            this.txtBoxLogin.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(32, 81);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login :";
            // 
            // plValidation
            // 
            this.plValidation.Controls.Add(this.btAnnuler);
            this.plValidation.Controls.Add(this.btValider);
            this.plValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plValidation.Location = new System.Drawing.Point(3, 309);
            this.plValidation.Name = "plValidation";
            this.plValidation.Size = new System.Drawing.Size(378, 50);
            this.plValidation.TabIndex = 2;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnnuler.Image = ((System.Drawing.Image)(resources.GetObject("btAnnuler.Image")));
            this.btAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnnuler.Location = new System.Drawing.Point(258, 5);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(111, 38);
            this.btAnnuler.TabIndex = 9;
            this.btAnnuler.Text = "&Annuler";
            this.btAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btValider
            // 
            this.btValider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btValider.Image = ((System.Drawing.Image)(resources.GetObject("btValider.Image")));
            this.btValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btValider.Location = new System.Drawing.Point(9, 5);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(102, 38);
            this.btValider.TabIndex = 8;
            this.btValider.Text = "&Valider";
            this.btValider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.tlPanelAuthentification);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(461, 462);
            this.MinimumSize = new System.Drawing.Size(400, 401);
            this.Name = "FrmAuthentification";
            this.Text = "CommunityDevelopers2ISA";
            this.tlPanelAuthentification.ResumeLayout(false);
            this.plLoginPassword.ResumeLayout(false);
            this.gpAuthentification.ResumeLayout(false);
            this.gpAuthentification.PerformLayout();
            this.plValidation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPanelAuthentification;
        private System.Windows.Forms.Panel plLoginPassword;
        private System.Windows.Forms.GroupBox gpAuthentification;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.TextBox txtBoxLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Panel plValidation;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btValider;
    }
}