namespace CommunityDevelopers2ISAWinForm
{
    partial class FrmReponse
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
            this.tLPReponse = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxReponse = new System.Windows.Forms.TextBox();
            this.tLP = new System.Windows.Forms.TableLayoutPanel();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblDatecreation = new System.Windows.Forms.Label();
            this.tLPReponse.SuspendLayout();
            this.tLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPReponse
            // 
            this.tLPReponse.ColumnCount = 3;
            this.tLPReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.027933F));
            this.tLPReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.97207F));
            this.tLPReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPReponse.Controls.Add(this.txtBoxReponse, 1, 1);
            this.tLPReponse.Controls.Add(this.tLP, 1, 0);
            this.tLPReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPReponse.Location = new System.Drawing.Point(0, 0);
            this.tLPReponse.Name = "tLPReponse";
            this.tLPReponse.RowCount = 3;
            this.tLPReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.46988F));
            this.tLPReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.53012F));
            this.tLPReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLPReponse.Size = new System.Drawing.Size(398, 353);
            this.tLPReponse.TabIndex = 0;
            // 
            // txtBoxReponse
            // 
            this.txtBoxReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxReponse.Location = new System.Drawing.Point(22, 61);
            this.txtBoxReponse.Multiline = true;
            this.txtBoxReponse.Name = "txtBoxReponse";
            this.txtBoxReponse.Size = new System.Drawing.Size(352, 268);
            this.txtBoxReponse.TabIndex = 0;
            // 
            // tLP
            // 
            this.tLP.ColumnCount = 2;
            this.tLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP.Controls.Add(this.lblDatecreation, 1, 0);
            this.tLP.Controls.Add(this.lblAuteur, 0, 0);
            this.tLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP.Location = new System.Drawing.Point(22, 3);
            this.tLP.Name = "tLP";
            this.tLP.RowCount = 1;
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP.Size = new System.Drawing.Size(352, 52);
            this.tLP.TabIndex = 1;
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(3, 19);
            this.lblAuteur.Margin = new System.Windows.Forms.Padding(3, 19, 3, 0);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(59, 13);
            this.lblAuteur.TabIndex = 0;
            this.lblAuteur.Text = "Créer par : ";
            // 
            // lblDatecreation
            // 
            this.lblDatecreation.AutoSize = true;
            this.lblDatecreation.Location = new System.Drawing.Point(179, 19);
            this.lblDatecreation.Margin = new System.Windows.Forms.Padding(3, 19, 3, 0);
            this.lblDatecreation.Name = "lblDatecreation";
            this.lblDatecreation.Size = new System.Drawing.Size(80, 13);
            this.lblDatecreation.TabIndex = 1;
            this.lblDatecreation.Text = "Date création : ";
            // 
            // FrmReponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(398, 353);
            this.Controls.Add(this.tLPReponse);
            this.Name = "FrmReponse";
            this.Text = "FrmReponse";
            this.tLPReponse.ResumeLayout(false);
            this.tLPReponse.PerformLayout();
            this.tLP.ResumeLayout(false);
            this.tLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPReponse;
        internal System.Windows.Forms.TextBox txtBoxReponse;
        private System.Windows.Forms.TableLayoutPanel tLP;
        internal System.Windows.Forms.Label lblAuteur;
        internal System.Windows.Forms.Label lblDatecreation;
    }
}