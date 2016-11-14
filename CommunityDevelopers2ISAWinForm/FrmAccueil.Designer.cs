namespace CommunityDevelopers2ISAWinForm
{
    partial class FrmAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEntrer = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.forum_discussion;
            this.pictureBox1.Location = new System.Drawing.Point(218, 76);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(264, 191);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(250, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 191);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btEntrer
            // 
            this.btEntrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEntrer.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.quitte;
            this.btEntrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEntrer.Location = new System.Drawing.Point(87, 314);
            this.btEntrer.Name = "btEntrer";
            this.btEntrer.Size = new System.Drawing.Size(131, 44);
            this.btEntrer.TabIndex = 1;
            this.btEntrer.Text = "&Accès au forum";
            this.btEntrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEntrer.UseVisualStyleBackColor = true;
            this.btEntrer.Click += new System.EventHandler(this.btEntrer_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btQuitter.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.quitter;
            this.btQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuitter.Location = new System.Drawing.Point(483, 314);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(127, 44);
            this.btQuitter.TabIndex = 2;
            this.btQuitter.Text = "&Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(694, 381);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btEntrer);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAccueil";
            this.Text = "CommunityDevelopers2ISA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btEntrer;
        private System.Windows.Forms.Button btQuitter;
    }
}

