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
            this.tbLPReponse = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtBoxReponse = new System.Windows.Forms.TextBox();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.lblDateCreation = new System.Windows.Forms.Label();
            this.tbLPReponse.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLPReponse
            // 
            this.tbLPReponse.ColumnCount = 3;
            this.tbLPReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbLPReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 373F));
            this.tbLPReponse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tbLPReponse.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tbLPReponse.Controls.Add(this.txtBoxReponse, 1, 1);
            this.tbLPReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPReponse.Location = new System.Drawing.Point(0, 0);
            this.tbLPReponse.Name = "tbLPReponse";
            this.tbLPReponse.RowCount = 4;
            this.tbLPReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.80315F));
            this.tbLPReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 299F));
            this.tbLPReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tbLPReponse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tbLPReponse.Size = new System.Drawing.Size(403, 353);
            this.tbLPReponse.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblDateCreation, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAuteur, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 315);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(367, 26);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtBoxReponse
            // 
            this.txtBoxReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxReponse.Location = new System.Drawing.Point(17, 16);
            this.txtBoxReponse.Multiline = true;
            this.txtBoxReponse.Name = "txtBoxReponse";
            this.txtBoxReponse.Size = new System.Drawing.Size(367, 293);
            this.txtBoxReponse.TabIndex = 1;
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Location = new System.Drawing.Point(3, 6);
            this.lblAuteur.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(44, 13);
            this.lblAuteur.TabIndex = 0;
            this.lblAuteur.Text = "Auteur :";
            // 
            // lblDateCreation
            // 
            this.lblDateCreation.AutoSize = true;
            this.lblDateCreation.Location = new System.Drawing.Point(191, 6);
            this.lblDateCreation.Margin = new System.Windows.Forms.Padding(8, 6, 3, 0);
            this.lblDateCreation.Name = "lblDateCreation";
            this.lblDateCreation.Size = new System.Drawing.Size(74, 13);
            this.lblDateCreation.TabIndex = 1;
            this.lblDateCreation.Text = "Date création:";
            // 
            // FrmReponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(403, 353);
            this.Controls.Add(this.tbLPReponse);
            this.Name = "FrmReponse";
            this.Text = "FrmReponse";
            this.tbLPReponse.ResumeLayout(false);
            this.tbLPReponse.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbLPReponse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtBoxReponse;
        private System.Windows.Forms.Label lblDateCreation;
        private System.Windows.Forms.Label lblAuteur;
    }
}