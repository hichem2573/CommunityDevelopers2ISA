using CommunityDevelopers2ISADLL;
using CommunityDevelopers2ISAOutils;
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
    public partial class FrmAuthentification : Form
    {


        public FrmAuthentification()
        {
            InitializeComponent();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            FrmAccueil.CurrentUtilisateur = Outil.Login(txtBoxLogin.Text, txtBoxPassword.Text);
            if (FrmAccueil.CurrentUtilisateur != null)
            {
                FrmAccueil.Isconnected = true;
                FrmAccueil.IsRmodo = FrmAccueil.CurrentUtilisateur.IsRmode;
                this.Close();


            }
            else
            {
                FrmAccueil.Isconnected = false;
                MessageBox.Show("Votre Login ou votre mot de passe sont incorrect!", "Veuillez saisir vos identifiants svp", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }


        }

        
    }

}
