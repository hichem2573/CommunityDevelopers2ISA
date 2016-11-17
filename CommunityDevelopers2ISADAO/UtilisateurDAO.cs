using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CommunityDevelopers2ISADAO
{
    /// <summary>
    /// La classe UtilisateurDAO, permet de récupérer les utilisateurs
    /// qui se trouvent dans la base de données
    /// </summary>
    public abstract class UtilisateurDAO
    {
        #region "Property et attributs"
        private static SqlConnection con = ConnexionSql.GetConnexion();
        #endregion

        #region "Constructeurs"
        #endregion

        #region "Méthodes"
        /// <summary>
        /// La méthode Login, permet l'authantification d'un utilisateur
        /// </summary>
        /// <param name="login">Le login de l'utilisateur</param>
        /// <param name="mdp">Le mot de passe de l'utilisateur</param>
        /// <returns></returns>
        public static DataTable Login(string login, string password)
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetLoginPassword";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parLogin = cmd.CreateParameter(); //On creer une nouvelle instance d'objet sqlParameter
            parLogin.ParameterName = "@Login";
            parLogin.Value = login;
            cmd.Parameters.Add(parLogin);

            SqlParameter parMDP = cmd.CreateParameter();
            parMDP.ParameterName = "@Password";
            parMDP.Value = password;
            cmd.Parameters.Add(parMDP);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Login");
            da.Fill(dt);
            //con.Close();
            return dt;

            

        }
        /// <summary>
        /// La méthode GetUtilisateurByID, permet de récupérer un utilisateur,
        /// On passant son id en parametre
        /// </summary>
        /// <param name="iduser">L'identidiant de l'urilisateur</param>
        /// <returns>Un utilisateur</returns>
        public static DataTable GetUtilisateurByID(int iduser)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetUserByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@iduser";
            parm.Value = iduser;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Utilisateurs");
            da.Fill(dt);
            //con.Close();

            return dt;
        }

        /// <summary>
        /// La méthode GetAllUtilisateur, permet de récupérer tous les utilisateur
        /// </summary>
        /// <returns>La liste des utilisateurs</returns>
        public static DataTable GetAllUtilisateur()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllUtilisateurs";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Utilisateurs");
            da.Fill(dt);

            return dt;
        }

        public static int EditPassword (int iduser, string password)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "ModifierPassword";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parIdUser = cmd.CreateParameter(); //On creer une nouvelle instance d'objet sqlParameter
            parIdUser.ParameterName = "@ID_Utilisateur";
            parIdUser.Value = iduser;
            cmd.Parameters.Add(parIdUser);

            SqlParameter parPassword = cmd.CreateParameter(); //On creer une nouvelle instance d'objet sqlParameter
            parPassword.ParameterName = "@PASSWORD";
            parPassword.Value = password;
            cmd.Parameters.Add(parPassword);

            con.Open();
            int nbligne = cmd.ExecuteNonQuery();
            con.Close();
            return nbligne;
        }
    }
        #endregion

        #region "Méthodes héritées et substituées"
        #endregion

        #region "Méthodes à implementer pour les interfaces"
        #endregion
    
}
