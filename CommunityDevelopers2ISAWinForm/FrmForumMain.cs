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
using CommunityDevelopers2ISAMetiers;
using CommunityDevelopers2ISABLL;

namespace CommunityDevelopers2ISAWinForm
{
    public partial class FrmForumMain : Form
    {
        public FrmForumMain()
        {
            InitializeComponent();
            dataGridViewReponses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        #region "Load"

        /// <summary>
        /// L'événement Load se produit juste avant l'ouverture du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmForumMain_Load(object sender, EventArgs e)
        {
            // On remplit la comboBox de la catégorie appelant la procédure stockée qui se trouve dans la DAO
            remplirComboBoxCategorie(Outils.GetAllCategories());
            // on remplit la comboBox du sujet en passant l'identifiant de la catégorie en paramètre en appelant la méthode qui se trouve dans la DAO
            remplirComboBoxSujet(Outils.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue));
            visibiliteModerateur();
        }

        #endregion

      

        #region "Event Click"

        /// <summary>
        /// Cette méthode permet de quitter la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btQuitter_Click(object sender, EventArgs e)
        {
            // fermeture de la fenêtre
            this.Close();
        }

        /// <summary>
        /// Cette méthode permet à un utilisateur de s'identifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLogin_Click(object sender, EventArgs e)
        {
            //création de la fenêtre Authentification dans un bloc using
            using (FrmAuthentification frmAuthentification = new FrmAuthentification())
            {
                frmAuthentification.ShowDialog();
            }
            visibiliteModerateur();
        }


        /// <summary>
        /// Cette méthode permet à un utilisateur de changer son mot de passe 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEditPassword_Click(object sender, EventArgs e)
        {
            //création de la fenêtre EditPassword dans un bloc using
            using ( FrmEditPassword frmEditPassword = new FrmEditPassword())
            {
                frmEditPassword.ShowDialog();
            }
            visibiliteModerateur();

        }

        /// <summary>
        /// Cette méthode permet à un utilisateur de se déconnecter, on verifiant son rôle et son statut (on vérifier si l'utilisateur n'est pas déconnecté)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btLogout_Click(object sender, EventArgs e)
        {
            FrmAccueil.Isconnected = false;
            FrmAccueil.IsRmodo = false;
            MessageBox.Show(Properties.Resources.MsgBoxDeconnexionText, Properties.Resources.MsgBoxDeconnexionTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
            visibiliteModerateur();
        }

        /// <summary>
        /// méthode permettant l'ouverture d'une nouvelle fenêtre, pour ajouter un nouveau sujet dès qu'on clic sur le bouton ajouter sujet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAjouterSujet_Click(object sender, EventArgs e)
        {
            //création de la fenêtre AjoutSujet dans un bloc using
            using (FrmAjoutSujet frmAjoutSujet = new FrmAjoutSujet())
            {
                frmAjoutSujet.categorie = (Categorie)cbBoxCategorie.SelectedItem;
                frmAjoutSujet.Text = string.Format("Ajouter le sujet dans la categorie {0}", frmAjoutSujet.categorie.Libelle);
                frmAjoutSujet.ShowDialog();
                remplirComboBoxSujet(Outils.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue)); 
            }
        }

        /// <summary>
        /// Méthode permettant de voir le détail d'une réponse.
        /// L'événement se produit lorsqu'on clic sur le contenue d'une cellule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void dataGridViewReponses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentRow = e.RowIndex;

            DataGridViewRow row = dataGridViewReponses.Rows[CurrentRow];

            //création de la fenêtre Reponse dans un bloc using
            using (FrmReponse frmReponse = new FrmReponse())
            {
                frmReponse.txtBoxReponse.Text = row.Cells["Texte"].Value.ToString();
                frmReponse.lblAuteur.Text += row.Cells["Auteur"].Value.ToString();
                frmReponse.lblDatecreation.Text += row.Cells["Date"].Value.ToString();
                frmReponse.ShowDialog();
            }

        }



        /// <summary>
        /// Méthode permettant l'ouverture d'une nouvelle fenêtre 
        /// Pour ajouter une réponse dès qu'on clic sur le bouton ajouter réponse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btPosterReponse_Click(object sender, EventArgs e)
        {
            //création de la fenêtre AjoutReponse dans un bloc using
            using (FrmAjoutReponse frmAjoutReponse = new FrmAjoutReponse())
            {
                frmAjoutReponse.sujet = (Sujet)cbBoxSujet.SelectedItem;
                frmAjoutReponse.Text = string.Format("Ajout de la réponse au sujet {0}", frmAjoutReponse.sujet.Titre);
                frmAjoutReponse.ShowDialog();
                remplirDataGridReponses(Outils.GetAllReponseBySujet((int)cbBoxSujet.SelectedValue));
               
            }
        }

        #endregion

        #region "Modérateur"

        /// <summary>
        /// Méthode permettant au modérateur, la modification du titre d'un sujet ou sa description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void btEditSujet_Click(object sender, EventArgs e)
        {
            //création de la fenêtre AjoutSujet dans un bloc using
            using (FrmAjoutSujet frmModifierSujet = new FrmAjoutSujet())
            {
                frmModifierSujet.categorie = (Categorie)cbBoxCategorie.SelectedItem;
                frmModifierSujet.sujet = (Sujet)cbBoxSujet.SelectedItem;
                frmModifierSujet.Text = string.Format("Edit le sujet {0} dans la catégorie {1}", frmModifierSujet.sujet.Titre, frmModifierSujet.categorie.Libelle);
                frmModifierSujet.ShowDialog();
                remplirComboBoxSujet(Outils.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue));
            }
        }

        /// <summary>
        /// Méthode permettant la suppression d'un sujet, en séléctionnant le sujet à supprimer dans la ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDeleteSujet_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.MsgBoxDeleteSujetText, Properties.Resources.MsgBoxDeleteSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(dr == DialogResult.OK)
            {
                if(Outils.DeleteSujet((int)cbBoxSujet.SelectedValue) != 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurDeleteSujetText, Properties.Resources.MsgBoxErreurDeleteSujetTitre);
                }
                List<Sujet> sujets = Outils.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue);
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

        /// <summary>
        /// Méthode permettant la suppression d'une réponse, en séléctionnant la réponse à supprimer dans la DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btDeleteReponse_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();

            dr = MessageBox.Show(Properties.Resources.MsgBoxDeletePostText, Properties.Resources.MsgBoxDeletePostTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if(dr == DialogResult.OK)
            {
                if(Outils.DeleteReponse((int)dataGridViewReponses.CurrentRow.Cells["ID"].Value) != 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurDeletePostText, Properties.Resources.MsgBoxErreurDeletePostTitre);
                }
                List<Reponse> reponses = Outils.GetAllReponseBySujet((int)cbBoxSujet.SelectedValue);
               
                if (reponses != null)
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
            List<Sujet> sujets = Outils.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue);
            if (sujets != null)
            {
                PanelSujetVisible();
                remplirComboBoxSujet(sujets);
            }
            else
            {
                PanelSujetInvisible();
                PanelReponseInvisible();
            }
        }

        private void cbBoxSujet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (visibiliteSujets())
            {
                PanelSujetVisible();
                Sujet sujet = (Sujet)cbBoxSujet.SelectedItem;
                txtBoxDescSujet.Text = sujet.Desc + Environment.NewLine + "Créer par : " + sujet.Auteur + Environment.NewLine + "Date de création : " + sujet.Date;
                if (visibiliteReponse())
                {
                    PanelReponseVisible();
                    List<Reponse> reponses = Outils.GetAllReponseBySujet((int)cbBoxSujet.SelectedValue);
                    
                    if (reponses != null)
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
        /// <summary>
        /// L'événement selectionCahnged se produit lorsque la sélection est modifiée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// si un utilisateur connecté et suivant son rôle certaines zones vont s'afficher ou non 
        /// </summary>
        private void visibiliteModerateur()
        {
            
            plAddSujetAddReponse.Visible = FrmAccueil.Isconnected;
            btEditPassword.Visible = FrmAccueil.Isconnected;
            btLogout.Visible = FrmAccueil.Isconnected;
            gpBoxAdministration.Visible = FrmAccueil.IsRmodo;
            btLogin.Visible = !FrmAccueil.Isconnected;
        }

        /// <summary>
        /// Cette méthode permet l'affichage des réponses dans le datagridView 
        /// On en lui passant l'identifiant du sujet, on vérifiant que notre combobox sujet n'est pas vide
        /// </summary>
        /// <returns>Vrai si le sujet existe et qu'il contient des réponses</returns>
        private bool visibiliteReponse()
        {
            
            if(cbBoxSujet.SelectedIndex != -1)
            {
                // On récupere la liste des réponses, en lui passant l'identifiant du sujet en paramètre 

                 if(Outils.GetAllReponseBySujet((int)cbBoxSujet.SelectedValue) != null)
                
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Méthode permattant l'affichage ou la visualisation des sujet dans la comboBox
        /// Si la catégorie existe
        /// </summary>
        /// <returns>liste des sujet pour une catégorie donnée</returns>
        private bool visibiliteSujets()
        {
            if(cbBoxCategorie.SelectedIndex != -1)
            {
                if(Outils.GetSujetsByCategorieID((int)cbBoxCategorie.SelectedValue) != null)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// On remplit la comboBox catégorie avec la liste récupéré.En affichant le libelle de la catégorie 
        /// </summary>
        /// <param name="categories">liste des catégorie</param>
        private void remplirComboBoxCategorie(List<Categorie> categories)
        {
            cbBoxCategorie.ValueMember = "Id";
            cbBoxCategorie.DisplayMember = "Libelle";
            cbBoxCategorie.DataSource = categories;
        }

        /// <summary>
        /// On remplit la comboBox sujet avec la liste récupéré.En affichant le titre du sujet
        /// </summary>
        /// <param name="sujets">liste des sujets</param>
        private void remplirComboBoxSujet(List<Sujet> sujets)
        {
            cbBoxSujet.ValueMember = "Id";
            cbBoxSujet.DisplayMember = "Titre";
            cbBoxSujet.DataSource = sujets;
            Sujet sujet = (Sujet)cbBoxSujet.SelectedItem;
            
        }

        /// <summary>
        /// On remplit DataGridView avec la liste récupéré.En affichant l'identifiant de la réponse, l'auteur, et la date
        /// </summary>
        /// <param name="reponses">liste de reponse</param>
        private void remplirDataGridReponses(List<Reponse> reponses)
        {
            dataGridViewReponses.DataSource = reponses;
            dataGridViewReponses.Columns["ID"].Visible = false;
            dataGridViewReponses.Columns["SUJET"].Visible = false;
            dataGridViewReponses.Columns["UTILISATEUR"].Visible = false;
        }

        /// <summary>
        /// Cette méthode permet l'affichage du DataGridView. S'il un sujet contient des réponses
        /// </summary>
        private void PanelReponseVisible()
        {
            dataGridViewReponses.Visible = true;
            lblPasDeReponse.Visible = false;
            btDeleteReponse.Enabled = true;
        }

        /// <summary>
        /// Cette méthode n'affichera pas le DatagridView sera invisible. S'il le sujet choisi ne contient pas de réponses
        /// </summary>
        private void PanelReponseInvisible()
        {
            dataGridViewReponses.Visible = false;
            lblPasDeReponse.Visible = true;
            btDeleteReponse.Enabled = false;
        }

        /// <summary>
        /// Cette méthode, permet l'affichage de la zone Ajout Sujet, une fois l'utilisateur est identifié
        /// </summary>
        private void PanelSujetVisible()
        {
            cbBoxSujet.Visible = true;
            gpBoxDescSujet.Visible = true;
            lblPasDeSujet.Visible = false;
            btEditSujet.Enabled = true;
            btDeleteSujet.Enabled = true;
        }

        /// <summary>
        /// Cette méthode  rendra la zone ajout sujet, dès que l'utilisateur sera déconnecter
        /// </summary>
        private void PanelSujetInvisible()
        {
            cbBoxSujet.Visible = false;
            gpBoxDescSujet.Visible = false;
            lblPasDeSujet.Visible = true;
            btEditSujet.Enabled = false;
            btDeleteSujet.Enabled = false;
        }



        #endregion

       
    }
}
