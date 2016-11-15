using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommunityDevelopers2ISADLL;
using CommunityDevelopers2ISADAO;

namespace CommunityDevelopers2ISAWinForm
{
    public partial class FrmForumMain : Form
    {
        public FrmForumMain()
        {
            InitializeComponent();
        }

        #region "Load"

        private void FrmForumMain_Load(object sender, EventArgs e)
        {
            remplirComboBoxCategorie(CategorieDAO.GetAllCategories());
            remplirComboBoxSujet(SujetDAO.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue));
            visibiliteModerateur();
        }

        #endregion

      

        #region "Event Click"

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            using(FrmAuthentification frmAuthentification = new FrmAuthentification())
            {
                frmAuthentification.ShowDialog();
            }
            visibiliteModerateur();
        }

        private void btEditPassword_Click(object sender, EventArgs e)
        {
            using ( FrmEditPassword frmEditPassword = new FrmEditPassword())
            {
                frmEditPassword.ShowDialog();
            }
            visibiliteModerateur();

        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            FrmAccueil.Isconnected = false;
            FrmAccueil.IsRmodo = false;
            MessageBox.Show(Properties.Resources.MsgBoxDeconnexionText, Properties.Resources.MsgBoxDeconnexionTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
            visibiliteModerateur();
        }

        private void btAjouterSujet_Click(object sender, EventArgs e)
        {
            using(FrmAjoutSujet frmAjoutSujet = new FrmAjoutSujet())
            {
                frmAjoutSujet.categorie = (Categorie)cbBoxCategorie.SelectedItem;
                frmAjoutSujet.Text = string.Format("Ajouter le sujet dans la categorie {0}", frmAjoutSujet.categorie.Libelle);
                frmAjoutSujet.ShowDialog();
                remplirComboBoxSujet(SujetDAO.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue)); 
            }
        }

       

        private void btPosterReponse_Click(object sender, EventArgs e)
        {
            using (FrmAjoutReponse frmAjoutReponse = new FrmAjoutReponse())
            {
                frmAjoutReponse.sujet = (Sujet)cbBoxSujet.SelectedItem;
                frmAjoutReponse.Text = string.Format("Ajout de la réponse au sujet {0}", frmAjoutReponse.sujet.Titre);
                frmAjoutReponse.ShowDialog();
                remplirDataGridReponses(ReponseDAO.GetAllReponseBySujet((int)cbBoxSujet.SelectedValue));
            }
        }

        #endregion

        #region "Modérateur"
        private void btEditSujet_Click(object sender, EventArgs e)
        {
            using(FrmAjoutSujet frmModifierSujet = new FrmAjoutSujet())
            {
                frmModifierSujet.categorie = (Categorie)cbBoxCategorie.SelectedItem;
                frmModifierSujet.sujet = (Sujet)cbBoxSujet.SelectedItem;
                frmModifierSujet.Text = string.Format("Edit le sujet {0} dans la catégorie {1}", frmModifierSujet.sujet.Titre, frmModifierSujet.categorie.Libelle);
                frmModifierSujet.ShowDialog();
                remplirComboBoxSujet(SujetDAO.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue));
            }
        }

        private void btDeleteSujet_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.MsgBoxDeleteSujetText, Properties.Resources.MsgBoxDeleteSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(dr == DialogResult.OK)
            {
                if(SujetDAO.DeleteSujet((int)cbBoxSujet.SelectedValue) != 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurDeleteSujetText, Properties.Resources.MsgBoxErreurDeleteSujetTitre);
                }
                List<Sujet> sujets = SujetDAO.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue);
                if(sujets != null)
                {
                    remplirComboBoxSujet(sujets);
                }
            }
            if (visibiliteSujets())
            {
                PanelSujetVisible();
            }
            else
            {
                PanelSujetInvisible();
            }
        }

        private void btDeleteReponse_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.MsgBoxDeletePostText, Properties.Resources.MsgBoxDeletePostTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(dr == DialogResult.OK)
            {
                if(ReponseDAO.DeleteReponse((int)dataGridViewReponses.CurrentRow.Cells["ID"].Value) != 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurDeletePostText, Properties.Resources.MsgBoxErreurDeletePostTitre);
                }
                List<Reponse> reponses = ReponseDAO.GetAllReponseBySujet((int)cbBoxSujet.SelectedValue);
                if(reponses != null)
                {
                    remplirDataGridReponses(reponses);
                }
            }
            if (visibiliteReponse())
            {
                PanelReponseVisible();
            }
            else
            {
                PanelReponseInvisible();
            }
        }
        #endregion

        #region "Event IndexChanged"

        private void cbBoxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Sujet> sujets = SujetDAO.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue);
            if (sujets != null)
            {
                PanelSujetVisible();
                remplirComboBoxSujet(sujets);
            }
            else
            {
                PanelSujetInvisible();
            }
        }

        private void cbBoxSujet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (visibiliteSujets())
            {
                PanelSujetVisible();
                Sujet sujet = (Sujet)cbBoxSujet.SelectedItem;
                txtBoxDescSujet.Text = sujet.Desc;
                if (visibiliteReponse())
                {
                    PanelReponseVisible();
                    List<Reponse> reponses = ReponseDAO.GetAllReponseBySujet((int)cbBoxSujet.SelectedValue);
                    if(reponses != null)
                    {
                        remplirDataGridReponses(reponses);
                    }
                }
                else
                {
                    PanelReponseInvisible();
                }
            }
            else
            {
                PanelSujetInvisible();
            }
        }

        private void dataGridViewReponses_SelectionChanged(object sender, EventArgs e)
        {
            if (visibiliteReponse())
            {
                PanelReponseVisible();
            }
            else
            {
                PanelReponseInvisible();
            }
        }

        #endregion

        #region "Visibilite méthodes"

        private void visibiliteModerateur()
        {
            plAddSujetAddReponse.Visible = FrmAccueil.Isconnected;
            btEditPassword.Visible = FrmAccueil.Isconnected;
            btLogout.Visible = FrmAccueil.Isconnected;
            gpBoxAdministration.Visible = FrmAccueil.IsRmodo;
            btLogin.Visible = !FrmAccueil.Isconnected;
        }

        private bool visibiliteReponse()
        {
            if(cbBoxSujet.SelectedIndex != -1)
            {
                if(ReponseDAO.GetAllReponseBySujet((int)cbBoxSujet.SelectedValue) != null)
                {
                    return true;
                }
            }
            return false;
        }

        private bool visibiliteSujets()
        {
            if(cbBoxCategorie.SelectedIndex != -1)
            {
                if(SujetDAO.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue) != null)
                {
                    return true;
                }
            }
            return false;
        }

        private void remplirComboBoxCategorie(List<Categorie> categories)
        {
            cbBoxCategorie.ValueMember = "Id";
            cbBoxCategorie.DisplayMember = "Libelle";
            cbBoxCategorie.DataSource = categories;
        }

        private void remplirComboBoxSujet(List<Sujet> sujets)
        {
            cbBoxSujet.ValueMember = "Id";
            cbBoxSujet.DisplayMember = "Titre";
            cbBoxSujet.DataSource = sujets;
            Sujet sujet = (Sujet)cbBoxSujet.SelectedItem;
            
        }

        private void remplirDataGridReponses(List<Reponse> reponses)
        {
            dataGridViewReponses.DataSource = reponses;
            dataGridViewReponses.Columns["ID"].Visible = false;
            dataGridViewReponses.Columns["SUJET"].Visible = false;
            dataGridViewReponses.Columns["UTILISATEUR"].Visible = false;
        }

        private void PanelReponseVisible()
        {
            dataGridViewReponses.Visible = true;
            lblPasDeReponse.Visible = false;
            btDeleteReponse.Enabled = true;
        }

        private void PanelReponseInvisible()
        {
            dataGridViewReponses.Visible = false;
            lblPasDeReponse.Visible = true;
            btDeleteReponse.Enabled = false;
        }

        private void PanelSujetVisible()
        {
            cbBoxSujet.Visible = true;
            gpBoxDescSujet.Visible = true;
            lblPasDeSujet.Visible = false;
            btEditSujet.Enabled = true;
            btDeleteSujet.Enabled = true;
        }

        private void PanelSujetInvisible()
        {
            cbBoxSujet.Visible = false;
            gpBoxDescSujet.Visible = false;
            lblPasDeSujet.Visible = true;
            btEditSujet.Enabled = false;
            btDeleteSujet.Enabled = false;
        }

        #endregion

        private void dataGridViewReponses_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
