using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommunityDevelopers2ISABLL;
using CommunityDevelopers2ISAMetiers;

namespace CommunityDevelopers2ISAWinForm
{
    public partial class FrmAjoutSujet : Form
    {
        internal Categorie categorie;
        internal Sujet sujet;

        public FrmAjoutSujet()
        {
            InitializeComponent();
        }

        private void FrmAjoutSujet_Load(object sender, EventArgs e)
        {
            if(sujet == null)
            {
                
                txtBoxTitreSujet.Text = string.Empty;
                txtBoxDescSujet.Text = string.Empty;
                btValidation.Text = "Valider l'ajout";
            }
            else
            {
                txtBoxTitreSujet.Text = sujet.Titre;
                txtBoxDescSujet.Text = sujet.Desc;
                btValidation.Text = "Valider la modif";
            }
        }

        private void btValidation_Click(object sender, EventArgs e)
        {
            if(sujet == null)
            {
                if (Outils.AddSujet(FrmAccueil.CurrentUtilisateur.Id, categorie.Id, txtBoxTitreSujet.Text, txtBoxDescSujet.Text) == 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxAddSujetText, Properties.Resources.MsgBoxAddSujetTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurAddSujetText, Properties.Resources.MsgBoxErreurAddSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {

                if (Outils.ModifierSujet(sujet.Id, sujet.Titre, sujet.Desc, txtBoxTitreSujet.Text, txtBoxDescSujet.Text) == 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxEditSujetText, Properties.Resources.MsgBoxEditSujetText, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurEditSujetText, Properties.Resources.MsgBoxErreurEditSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                this.Close();
            }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(Properties.Resources.MsgBoxCancelText, Properties.Resources.MsgBoxCancelTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }

     
    }
}
