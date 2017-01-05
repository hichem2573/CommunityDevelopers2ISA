namespace CommunityDevelopers2ISAWinForm
{
    partial class FrmForumMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmForumMain));
            this.tlPanelFrmForumMain = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewReponses = new System.Windows.Forms.DataGridView();
            this.plAuthentification = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.btEditPassword = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            this.tblPanelCategorie = new System.Windows.Forms.TableLayoutPanel();
            this.gpBoxCategorie = new System.Windows.Forms.GroupBox();
            this.cbBoxCategorie = new System.Windows.Forms.ComboBox();
            this.tblPanelAdministration = new System.Windows.Forms.TableLayoutPanel();
            this.gpBoxAdministration = new System.Windows.Forms.GroupBox();
            this.btDeleteReponse = new System.Windows.Forms.Button();
            this.btDeleteSujet = new System.Windows.Forms.Button();
            this.btEditSujet = new System.Windows.Forms.Button();
            this.tlPanelSujet = new System.Windows.Forms.TableLayoutPanel();
            this.gpBoxSujet = new System.Windows.Forms.GroupBox();
            this.cbBoxSujet = new System.Windows.Forms.ComboBox();
            this.lblPasDeSujet = new System.Windows.Forms.Label();
            this.gpBoxDescSujet = new System.Windows.Forms.GroupBox();
            this.txtBoxDescSujet = new System.Windows.Forms.TextBox();
            this.plAddSujetAddReponse = new System.Windows.Forms.Panel();
            this.gpBoxAjoutSujetReponse = new System.Windows.Forms.GroupBox();
            this.btPosterReponse = new System.Windows.Forms.Button();
            this.btAjouterSujet = new System.Windows.Forms.Button();
            this.pnlQuitter = new System.Windows.Forms.Panel();
            this.btQuitter = new System.Windows.Forms.Button();
            this.lblPasDeReponse = new System.Windows.Forms.Label();
            this.tlPanelFrmForumMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReponses)).BeginInit();
            this.plAuthentification.SuspendLayout();
            this.tblPanelCategorie.SuspendLayout();
            this.gpBoxCategorie.SuspendLayout();
            this.tblPanelAdministration.SuspendLayout();
            this.gpBoxAdministration.SuspendLayout();
            this.tlPanelSujet.SuspendLayout();
            this.gpBoxSujet.SuspendLayout();
            this.gpBoxDescSujet.SuspendLayout();
            this.plAddSujetAddReponse.SuspendLayout();
            this.gpBoxAjoutSujetReponse.SuspendLayout();
            this.pnlQuitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlPanelFrmForumMain
            // 
            this.tlPanelFrmForumMain.BackColor = System.Drawing.Color.CadetBlue;
            this.tlPanelFrmForumMain.ColumnCount = 3;
            this.tlPanelFrmForumMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.33957F));
            this.tlPanelFrmForumMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.66042F));
            this.tlPanelFrmForumMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tlPanelFrmForumMain.Controls.Add(this.dataGridViewReponses, 1, 2);
            this.tlPanelFrmForumMain.Controls.Add(this.plAuthentification, 1, 3);
            this.tlPanelFrmForumMain.Controls.Add(this.tblPanelCategorie, 0, 0);
            this.tlPanelFrmForumMain.Controls.Add(this.tblPanelAdministration, 1, 0);
            this.tlPanelFrmForumMain.Controls.Add(this.tlPanelSujet, 0, 2);
            this.tlPanelFrmForumMain.Controls.Add(this.plAddSujetAddReponse, 2, 2);
            this.tlPanelFrmForumMain.Controls.Add(this.pnlQuitter, 2, 3);
            this.tlPanelFrmForumMain.Controls.Add(this.lblPasDeReponse, 1, 1);
            this.tlPanelFrmForumMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelFrmForumMain.Location = new System.Drawing.Point(0, 0);
            this.tlPanelFrmForumMain.Name = "tlPanelFrmForumMain";
            this.tlPanelFrmForumMain.RowCount = 4;
            this.tlPanelFrmForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.08772F));
            this.tlPanelFrmForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.91228F));
            this.tlPanelFrmForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.tlPanelFrmForumMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tlPanelFrmForumMain.Size = new System.Drawing.Size(1067, 509);
            this.tlPanelFrmForumMain.TabIndex = 0;
            // 
            // dataGridViewReponses
            // 
            this.dataGridViewReponses.AllowUserToAddRows = false;
            this.dataGridViewReponses.AllowUserToDeleteRows = false;
            this.dataGridViewReponses.AllowUserToResizeColumns = false;
            this.dataGridViewReponses.AllowUserToResizeRows = false;
            this.dataGridViewReponses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReponses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewReponses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReponses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReponses.Location = new System.Drawing.Point(237, 117);
            this.dataGridViewReponses.Name = "dataGridViewReponses";
            this.dataGridViewReponses.ReadOnly = true;
            this.dataGridViewReponses.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridViewReponses.RowTemplate.Height = 40;
            this.dataGridViewReponses.Size = new System.Drawing.Size(588, 317);
            this.dataGridViewReponses.TabIndex = 0;
            this.dataGridViewReponses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReponses_CellClick);
            this.dataGridViewReponses.SelectionChanged += new System.EventHandler(this.dataGridViewReponses_SelectionChanged);
            // 
            // plAuthentification
            // 
            this.plAuthentification.Controls.Add(this.btLogout);
            this.plAuthentification.Controls.Add(this.btEditPassword);
            this.plAuthentification.Controls.Add(this.btLogin);
            this.plAuthentification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plAuthentification.Location = new System.Drawing.Point(237, 440);
            this.plAuthentification.Name = "plAuthentification";
            this.plAuthentification.Size = new System.Drawing.Size(588, 66);
            this.plAuthentification.TabIndex = 2;
            // 
            // btLogout
            // 
            this.btLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogout.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.logout;
            this.btLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogout.Location = new System.Drawing.Point(410, 16);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(119, 41);
            this.btLogout.TabIndex = 5;
            this.btLogout.Text = "D&éconnecter";
            this.btLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btEditPassword
            // 
            this.btEditPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditPassword.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.edit;
            this.btEditPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditPassword.Location = new System.Drawing.Point(227, 16);
            this.btEditPassword.Name = "btEditPassword";
            this.btEditPassword.Size = new System.Drawing.Size(119, 41);
            this.btEditPassword.TabIndex = 6;
            this.btEditPassword.Text = "Modifier &MDP";
            this.btEditPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEditPassword.UseVisualStyleBackColor = true;
            this.btEditPassword.Click += new System.EventHandler(this.btEditPassword_Click);
            // 
            // btLogin
            // 
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.login;
            this.btLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLogin.Location = new System.Drawing.Point(49, 16);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(119, 41);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "&Se Connecter";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tblPanelCategorie
            // 
            this.tblPanelCategorie.ColumnCount = 1;
            this.tblPanelCategorie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelCategorie.Controls.Add(this.gpBoxCategorie, 0, 0);
            this.tblPanelCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelCategorie.Location = new System.Drawing.Point(3, 3);
            this.tblPanelCategorie.Name = "tblPanelCategorie";
            this.tblPanelCategorie.RowCount = 1;
            this.tblPanelCategorie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelCategorie.Size = new System.Drawing.Size(228, 91);
            this.tblPanelCategorie.TabIndex = 4;
            // 
            // gpBoxCategorie
            // 
            this.gpBoxCategorie.Controls.Add(this.cbBoxCategorie);
            this.gpBoxCategorie.Location = new System.Drawing.Point(3, 3);
            this.gpBoxCategorie.Name = "gpBoxCategorie";
            this.gpBoxCategorie.Size = new System.Drawing.Size(222, 85);
            this.gpBoxCategorie.TabIndex = 0;
            this.gpBoxCategorie.TabStop = false;
            this.gpBoxCategorie.Text = "Categories :";
            // 
            // cbBoxCategorie
            // 
            this.cbBoxCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoxCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxCategorie.FormattingEnabled = true;
            this.cbBoxCategorie.Location = new System.Drawing.Point(3, 16);
            this.cbBoxCategorie.Name = "cbBoxCategorie";
            this.cbBoxCategorie.Size = new System.Drawing.Size(216, 21);
            this.cbBoxCategorie.TabIndex = 0;
            this.cbBoxCategorie.SelectedIndexChanged += new System.EventHandler(this.cbBoxCategorie_SelectedIndexChanged);
            // 
            // tblPanelAdministration
            // 
            this.tblPanelAdministration.ColumnCount = 1;
            this.tblPanelAdministration.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelAdministration.Controls.Add(this.gpBoxAdministration, 0, 0);
            this.tblPanelAdministration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelAdministration.Location = new System.Drawing.Point(237, 3);
            this.tblPanelAdministration.Name = "tblPanelAdministration";
            this.tblPanelAdministration.RowCount = 1;
            this.tblPanelAdministration.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanelAdministration.Size = new System.Drawing.Size(588, 91);
            this.tblPanelAdministration.TabIndex = 5;
            // 
            // gpBoxAdministration
            // 
            this.gpBoxAdministration.Controls.Add(this.btDeleteReponse);
            this.gpBoxAdministration.Controls.Add(this.btDeleteSujet);
            this.gpBoxAdministration.Controls.Add(this.btEditSujet);
            this.gpBoxAdministration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpBoxAdministration.Location = new System.Drawing.Point(3, 3);
            this.gpBoxAdministration.Name = "gpBoxAdministration";
            this.gpBoxAdministration.Size = new System.Drawing.Size(582, 85);
            this.gpBoxAdministration.TabIndex = 0;
            this.gpBoxAdministration.TabStop = false;
            this.gpBoxAdministration.Text = "Administration :";
            // 
            // btDeleteReponse
            // 
            this.btDeleteReponse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDeleteReponse.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.message_supprimez;
            this.btDeleteReponse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeleteReponse.Location = new System.Drawing.Point(420, 21);
            this.btDeleteReponse.Name = "btDeleteReponse";
            this.btDeleteReponse.Size = new System.Drawing.Size(144, 48);
            this.btDeleteReponse.TabIndex = 11;
            this.btDeleteReponse.Text = "Supprimer &Reponse";
            this.btDeleteReponse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDeleteReponse.UseVisualStyleBackColor = true;
            this.btDeleteReponse.Click += new System.EventHandler(this.btDeleteReponse_Click);
            // 
            // btDeleteSujet
            // 
            this.btDeleteSujet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btDeleteSujet.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.supprimer;
            this.btDeleteSujet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeleteSujet.Location = new System.Drawing.Point(224, 21);
            this.btDeleteSujet.Name = "btDeleteSujet";
            this.btDeleteSujet.Size = new System.Drawing.Size(127, 48);
            this.btDeleteSujet.TabIndex = 10;
            this.btDeleteSujet.Text = "&Supprimer Sujet";
            this.btDeleteSujet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDeleteSujet.UseVisualStyleBackColor = true;
            this.btDeleteSujet.Click += new System.EventHandler(this.btDeleteSujet_Click);
            // 
            // btEditSujet
            // 
            this.btEditSujet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEditSujet.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.edit_sujet;
            this.btEditSujet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEditSujet.Location = new System.Drawing.Point(11, 21);
            this.btEditSujet.Name = "btEditSujet";
            this.btEditSujet.Size = new System.Drawing.Size(127, 48);
            this.btEditSujet.TabIndex = 9;
            this.btEditSujet.Text = "&Modifier Sujet";
            this.btEditSujet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEditSujet.UseVisualStyleBackColor = true;
            this.btEditSujet.Click += new System.EventHandler(this.btEditSujet_Click);
            // 
            // tlPanelSujet
            // 
            this.tlPanelSujet.ColumnCount = 1;
            this.tlPanelSujet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlPanelSujet.Controls.Add(this.gpBoxSujet, 0, 0);
            this.tlPanelSujet.Controls.Add(this.lblPasDeSujet, 0, 2);
            this.tlPanelSujet.Controls.Add(this.gpBoxDescSujet, 0, 1);
            this.tlPanelSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPanelSujet.Location = new System.Drawing.Point(3, 117);
            this.tlPanelSujet.Name = "tlPanelSujet";
            this.tlPanelSujet.RowCount = 3;
            this.tlPanelSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.37855F));
            this.tlPanelSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.62145F));
            this.tlPanelSujet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlPanelSujet.Size = new System.Drawing.Size(228, 317);
            this.tlPanelSujet.TabIndex = 6;
            // 
            // gpBoxSujet
            // 
            this.gpBoxSujet.Controls.Add(this.cbBoxSujet);
            this.gpBoxSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpBoxSujet.Location = new System.Drawing.Point(3, 3);
            this.gpBoxSujet.Name = "gpBoxSujet";
            this.gpBoxSujet.Size = new System.Drawing.Size(222, 100);
            this.gpBoxSujet.TabIndex = 0;
            this.gpBoxSujet.TabStop = false;
            this.gpBoxSujet.Text = "Sujets :";
            // 
            // cbBoxSujet
            // 
            this.cbBoxSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbBoxSujet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxSujet.FormattingEnabled = true;
            this.cbBoxSujet.Location = new System.Drawing.Point(3, 16);
            this.cbBoxSujet.Name = "cbBoxSujet";
            this.cbBoxSujet.Size = new System.Drawing.Size(216, 21);
            this.cbBoxSujet.TabIndex = 1;
            this.cbBoxSujet.SelectedIndexChanged += new System.EventHandler(this.cbBoxSujet_SelectedIndexChanged);
            // 
            // lblPasDeSujet
            // 
            this.lblPasDeSujet.AutoSize = true;
            this.lblPasDeSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPasDeSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasDeSujet.ForeColor = System.Drawing.Color.White;
            this.lblPasDeSujet.Location = new System.Drawing.Point(3, 263);
            this.lblPasDeSujet.Name = "lblPasDeSujet";
            this.lblPasDeSujet.Size = new System.Drawing.Size(222, 54);
            this.lblPasDeSujet.TabIndex = 1;
            this.lblPasDeSujet.Text = "Désolé ! La Categorie, ne contient aucun sujet";
            this.lblPasDeSujet.Visible = false;
            // 
            // gpBoxDescSujet
            // 
            this.gpBoxDescSujet.Controls.Add(this.txtBoxDescSujet);
            this.gpBoxDescSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpBoxDescSujet.Location = new System.Drawing.Point(3, 109);
            this.gpBoxDescSujet.Name = "gpBoxDescSujet";
            this.gpBoxDescSujet.Size = new System.Drawing.Size(222, 151);
            this.gpBoxDescSujet.TabIndex = 2;
            this.gpBoxDescSujet.TabStop = false;
            this.gpBoxDescSujet.Text = "Description Sujet ;";
            // 
            // txtBoxDescSujet
            // 
            this.txtBoxDescSujet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxDescSujet.Enabled = false;
            this.txtBoxDescSujet.Location = new System.Drawing.Point(3, 16);
            this.txtBoxDescSujet.Multiline = true;
            this.txtBoxDescSujet.Name = "txtBoxDescSujet";
            this.txtBoxDescSujet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDescSujet.Size = new System.Drawing.Size(216, 132);
            this.txtBoxDescSujet.TabIndex = 2;
            // 
            // plAddSujetAddReponse
            // 
            this.plAddSujetAddReponse.Controls.Add(this.gpBoxAjoutSujetReponse);
            this.plAddSujetAddReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plAddSujetAddReponse.Location = new System.Drawing.Point(831, 117);
            this.plAddSujetAddReponse.Name = "plAddSujetAddReponse";
            this.plAddSujetAddReponse.Size = new System.Drawing.Size(233, 317);
            this.plAddSujetAddReponse.TabIndex = 7;
            // 
            // gpBoxAjoutSujetReponse
            // 
            this.gpBoxAjoutSujetReponse.Controls.Add(this.btPosterReponse);
            this.gpBoxAjoutSujetReponse.Controls.Add(this.btAjouterSujet);
            this.gpBoxAjoutSujetReponse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpBoxAjoutSujetReponse.Location = new System.Drawing.Point(0, 0);
            this.gpBoxAjoutSujetReponse.Name = "gpBoxAjoutSujetReponse";
            this.gpBoxAjoutSujetReponse.Size = new System.Drawing.Size(233, 317);
            this.gpBoxAjoutSujetReponse.TabIndex = 0;
            this.gpBoxAjoutSujetReponse.TabStop = false;
            this.gpBoxAjoutSujetReponse.Text = "Ajout Sujet ou réponse";
            // 
            // btPosterReponse
            // 
            this.btPosterReponse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btPosterReponse.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.ajouter_un_message;
            this.btPosterReponse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPosterReponse.Location = new System.Drawing.Point(50, 191);
            this.btPosterReponse.Name = "btPosterReponse";
            this.btPosterReponse.Size = new System.Drawing.Size(135, 47);
            this.btPosterReponse.TabIndex = 8;
            this.btPosterReponse.Text = "&Poster Reponse";
            this.btPosterReponse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPosterReponse.UseVisualStyleBackColor = true;
            this.btPosterReponse.Click += new System.EventHandler(this.btPosterReponse_Click);
            // 
            // btAjouterSujet
            // 
            this.btAjouterSujet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAjouterSujet.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.ajouter;
            this.btAjouterSujet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAjouterSujet.Location = new System.Drawing.Point(50, 70);
            this.btAjouterSujet.Name = "btAjouterSujet";
            this.btAjouterSujet.Size = new System.Drawing.Size(135, 47);
            this.btAjouterSujet.TabIndex = 7;
            this.btAjouterSujet.Text = "&Ajout Sujet";
            this.btAjouterSujet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAjouterSujet.UseVisualStyleBackColor = true;
            this.btAjouterSujet.Click += new System.EventHandler(this.btAjouterSujet_Click);
            // 
            // pnlQuitter
            // 
            this.pnlQuitter.Controls.Add(this.btQuitter);
            this.pnlQuitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuitter.Location = new System.Drawing.Point(831, 440);
            this.pnlQuitter.Name = "pnlQuitter";
            this.pnlQuitter.Size = new System.Drawing.Size(233, 66);
            this.pnlQuitter.TabIndex = 8;
            // 
            // btQuitter
            // 
            this.btQuitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btQuitter.Image = global::CommunityDevelopers2ISAWinForm.Properties.Resources.quitter;
            this.btQuitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btQuitter.Location = new System.Drawing.Point(63, 16);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(115, 41);
            this.btQuitter.TabIndex = 4;
            this.btQuitter.Text = "&Quitter";
            this.btQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // lblPasDeReponse
            // 
            this.lblPasDeReponse.AutoSize = true;
            this.lblPasDeReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasDeReponse.ForeColor = System.Drawing.Color.White;
            this.lblPasDeReponse.Location = new System.Drawing.Point(237, 97);
            this.lblPasDeReponse.Name = "lblPasDeReponse";
            this.lblPasDeReponse.Size = new System.Drawing.Size(443, 17);
            this.lblPasDeReponse.TabIndex = 9;
            this.lblPasDeReponse.Text = "Désolé ! Le sujet sélectionné, ne contient aucune reponse";
            this.lblPasDeReponse.Visible = false;
            // 
            // FrmForumMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1067, 509);
            this.Controls.Add(this.tlPanelFrmForumMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1083, 548);
            this.MinimumSize = new System.Drawing.Size(983, 448);
            this.Name = "FrmForumMain";
            this.Text = "2ISA\'s Developers Community";
            this.Load += new System.EventHandler(this.FrmForumMain_Load);
            this.tlPanelFrmForumMain.ResumeLayout(false);
            this.tlPanelFrmForumMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReponses)).EndInit();
            this.plAuthentification.ResumeLayout(false);
            this.tblPanelCategorie.ResumeLayout(false);
            this.gpBoxCategorie.ResumeLayout(false);
            this.tblPanelAdministration.ResumeLayout(false);
            this.gpBoxAdministration.ResumeLayout(false);
            this.tlPanelSujet.ResumeLayout(false);
            this.tlPanelSujet.PerformLayout();
            this.gpBoxSujet.ResumeLayout(false);
            this.gpBoxDescSujet.ResumeLayout(false);
            this.gpBoxDescSujet.PerformLayout();
            this.plAddSujetAddReponse.ResumeLayout(false);
            this.gpBoxAjoutSujetReponse.ResumeLayout(false);
            this.pnlQuitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlPanelFrmForumMain;
        private System.Windows.Forms.DataGridView dataGridViewReponses;
        private System.Windows.Forms.Panel plAuthentification;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Button btEditPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.TableLayoutPanel tblPanelCategorie;
        private System.Windows.Forms.GroupBox gpBoxCategorie;
        private System.Windows.Forms.ComboBox cbBoxCategorie;
        private System.Windows.Forms.TableLayoutPanel tblPanelAdministration;
        private System.Windows.Forms.GroupBox gpBoxAdministration;
        private System.Windows.Forms.Button btDeleteReponse;
        private System.Windows.Forms.Button btDeleteSujet;
        private System.Windows.Forms.Button btEditSujet;
        private System.Windows.Forms.TableLayoutPanel tlPanelSujet;
        private System.Windows.Forms.GroupBox gpBoxSujet;
        private System.Windows.Forms.ComboBox cbBoxSujet;
        private System.Windows.Forms.Label lblPasDeSujet;
        private System.Windows.Forms.GroupBox gpBoxDescSujet;
        private System.Windows.Forms.TextBox txtBoxDescSujet;
        private System.Windows.Forms.Panel plAddSujetAddReponse;
        private System.Windows.Forms.GroupBox gpBoxAjoutSujetReponse;
        private System.Windows.Forms.Button btPosterReponse;
        private System.Windows.Forms.Button btAjouterSujet;
        private System.Windows.Forms.Panel pnlQuitter;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label lblPasDeReponse;
    }
}