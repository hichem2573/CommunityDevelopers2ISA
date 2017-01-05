using CommunityDevelopers2ISAMetiers;
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
    public partial class FrmAccueil : Form
    {
        // variable déterminant le rôle de l'utilisateur (soit modérateur ou utilisateur identifié)
        static internal bool IsRmodo;
        // variable rendant le current utilisateur
        static internal Utilisateur CurrentUtilisateur;
        // variable déterminant si l'utilisateur est connecté ou non 
        static internal bool Isconnected;

        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void btEntrer_Click(object sender, EventArgs e)
        {
            using (FrmForumMain frmmain = new FrmForumMain())
            {
                frmmain.ShowDialog();
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
