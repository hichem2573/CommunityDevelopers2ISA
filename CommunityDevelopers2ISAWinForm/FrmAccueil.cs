using CommunityDevelopers2ISADAL;
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
        static internal bool IsRmodo;
        static internal Utilisateur CurrentUtilisateur;
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
