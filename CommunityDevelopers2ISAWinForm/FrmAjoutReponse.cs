using CommunityDevelopers2ISADLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityDevelopers2ISAWinForm
{
    public partial class FrmAjoutReponse : Form
    {
        internal Sujet sujet;

        public FrmAjoutReponse()
        {
            InitializeComponent();
        }
     
        private void btAjoutReponse_Click(object sender, EventArgs e)
        {
            if (Outils.AddReponse(FrmAccueil.CurrentUtilisateur.Id, sujet.Id, txtBoxReponse.Text) == 1)
            {
                MessageBox.Show(Properties.Resources.MsgBoxAddReponseText, Properties.Resources.MsgBoxAddReponseTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(Properties.Resources.MsgBoxErreurAddReponseText, Properties.Resources.MsgBoxErreurAddReponseTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            this.Close();
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
