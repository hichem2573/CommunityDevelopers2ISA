
using CommunityDevelopers2ISABLL;
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
    public partial class FrmEditPassword : Form
    {
        public FrmEditPassword()
        {
            InitializeComponent();
        }

       

        private void btValider_Click(object sender, EventArgs e)
        {

            btValider.Visible = false;
            DialogResult dres = new DialogResult();
            dres = MessageBox.Show(Properties.Resources.MsgBoxConfirmChangementPasswordText, Properties.Resources.MsgBoxConfirmChangementPasswordTitre, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dres == DialogResult.Yes && (txtBoxNewPassword.TextLength != txtBoxConfirmPassword.TextLength) || !(string.IsNullOrWhiteSpace(txtBoxNewPassword.Text) || string.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text)))
            {
                
                Outils.EditPassword(FrmAccueil.CurrentUtilisateur.Id, txtBoxNewPassword.Text);
                btValider.Visible = true;
                this.Close();

            }
       
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            btValider.Enabled = !(string.IsNullOrWhiteSpace(txtBoxNewPassword.Text) || string.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text)) && txtBoxNewPassword.Text == txtBoxConfirmPassword.Text;
            
        }

        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            btValider.Enabled = !(string.IsNullOrWhiteSpace(txtBoxNewPassword.Text) || string.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text)) && txtBoxNewPassword.Text == txtBoxConfirmPassword.Text;
            
        }

    }
}
