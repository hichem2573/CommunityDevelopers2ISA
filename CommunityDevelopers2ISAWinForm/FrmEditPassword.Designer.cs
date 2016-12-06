namespace CommunityDevelopers2ISAWinForm
{
    partial class FrmEditPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditPassword));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grBoxNewPassword = new System.Windows.Forms.GroupBox();
            this.txtBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.lblComfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.pnlValidation = new System.Windows.Forms.Panel();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.grBoxNewPassword.SuspendLayout();
            this.pnlValidation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grBoxNewPassword, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlValidation, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(322, 301);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grBoxNewPassword
            // 
            this.grBoxNewPassword.Controls.Add(this.txtBoxConfirmPassword);
            this.grBoxNewPassword.Controls.Add(this.txtBoxNewPassword);
            this.grBoxNewPassword.Controls.Add(this.lblComfirmPassword);
            this.grBoxNewPassword.Controls.Add(this.lblNewPassword);
            this.grBoxNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxNewPassword.Location = new System.Drawing.Point(3, 3);
            this.grBoxNewPassword.Name = "grBoxNewPassword";
            this.grBoxNewPassword.Size = new System.Drawing.Size(316, 209);
            this.grBoxNewPassword.TabIndex = 1;
            this.grBoxNewPassword.TabStop = false;
            this.grBoxNewPassword.Text = "Nouveau Mot de Passe : ";
            // 
            // txtBoxConfirmPassword
            // 
            this.txtBoxConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxConfirmPassword.Location = new System.Drawing.Point(131, 145);
            this.txtBoxConfirmPassword.Name = "txtBoxConfirmPassword";
            this.txtBoxConfirmPassword.PasswordChar = '*';
            this.txtBoxConfirmPassword.Size = new System.Drawing.Size(158, 20);
            this.txtBoxConfirmPassword.TabIndex = 3;
            this.txtBoxConfirmPassword.TextChanged += new System.EventHandler(this.txtBoxConfirmPassword_TextChanged);
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBoxNewPassword.Location = new System.Drawing.Point(131, 45);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.PasswordChar = '*';
            this.txtBoxNewPassword.Size = new System.Drawing.Size(158, 20);
            this.txtBoxNewPassword.TabIndex = 2;
            this.txtBoxNewPassword.TextChanged += new System.EventHandler(this.txtBoxNewPassword_TextChanged);
            // 
            // lblComfirmPassword
            // 
            this.lblComfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComfirmPassword.AutoSize = true;
            this.lblComfirmPassword.Location = new System.Drawing.Point(27, 148);
            this.lblComfirmPassword.Name = "lblComfirmPassword";
            this.lblComfirmPassword.Size = new System.Drawing.Size(83, 13);
            this.lblComfirmPassword.TabIndex = 2;
            this.lblComfirmPassword.Text = "Comfirmer MPD:";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(27, 48);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(84, 13);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "Nouveau MPD :";
            // 
            // pnlValidation
            // 
            this.pnlValidation.Controls.Add(this.btAnnuler);
            this.pnlValidation.Controls.Add(this.btValider);
            this.pnlValidation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlValidation.Location = new System.Drawing.Point(3, 218);
            this.pnlValidation.Name = "pnlValidation";
            this.pnlValidation.Size = new System.Drawing.Size(316, 80);
            this.pnlValidation.TabIndex = 1;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAnnuler.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.annuler_icone_8717_32;
            this.btAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnnuler.Location = new System.Drawing.Point(211, 20);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(96, 40);
            this.btAnnuler.TabIndex = 5;
            this.btAnnuler.Text = "&Annuler";
            this.btAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btValider
            // 
            this.btValider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btValider.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.validation;
            this.btValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btValider.Location = new System.Drawing.Point(9, 20);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(91, 40);
            this.btValider.TabIndex = 4;
            this.btValider.Text = "&Valider";
            this.btValider.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // FrmEditPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(322, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(338, 340);
            this.MinimumSize = new System.Drawing.Size(328, 330);
            this.Name = "FrmEditPassword";
            this.Text = "FrmModification MPD";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grBoxNewPassword.ResumeLayout(false);
            this.grBoxNewPassword.PerformLayout();
            this.pnlValidation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grBoxNewPassword;
        private System.Windows.Forms.TextBox txtBoxConfirmPassword;
        private System.Windows.Forms.TextBox txtBoxNewPassword;
        private System.Windows.Forms.Label lblComfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Panel pnlValidation;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btValider;
    }
}