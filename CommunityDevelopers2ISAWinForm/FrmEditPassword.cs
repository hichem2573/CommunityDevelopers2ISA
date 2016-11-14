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
            //DialogResult dr = new DialogResult();
            //dr = MessageBox.Show(Properties.Resources.MsgBoxConfirmChangementPasswordText, Properties.Resources.MsgBoxConfirmChangementPasswordTitre, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //    if (dr == DialogResult.Yes)
            //    {

            //    }
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
            btValider.Enabled = !(string.IsNullOrWhiteSpace(txtBoxNewPassword.Text) || string.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text)) && txtBoxNewPassword.Text == txtBoxConfirmPassword.Text;
            //MessageBox.Show(Properties.Resources.MsgBoxErreurNewPasswordText, Properties.Resources.MsgBoxErreurNewPasswordTitre, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

        private void txtBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            btValider.Enabled = !(string.IsNullOrWhiteSpace(txtBoxNewPassword.Text) || string.IsNullOrWhiteSpace(txtBoxConfirmPassword.Text)) && txtBoxNewPassword.Text == txtBoxConfirmPassword.Text;
            //MessageBox.Show(Properties.Resources.MsgBoxErreurNewPasswordText, Properties.Resources.MsgBoxErreurNewPasswordTitre, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
        }

    }
}
