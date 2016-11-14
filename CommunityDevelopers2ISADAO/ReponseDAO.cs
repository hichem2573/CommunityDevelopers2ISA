using CommunityDevelopers2ISADLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityDevelopers2ISADAO
{
    /// <summary>
    /// La classe ReponseDAO, permet la récupération de toutes les reponses
    /// L'ajout d'une reponse à un sujet et la suppression des reponse
    /// </summary>
    public static class ReponseDAO
    {
        #region "Property et attributs"
        private static SqlConnection con = ConnexionSql.GetConnexion();
        #endregion

        #region "Constructeurs"
        #endregion

        #region "Méthodes"
        /// <summary>
        /// La méthode GetAllBySujet, permet de récupérer toutes les reponses d'un sujet
        /// Dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idSujet">L'identifiant du sujet</param>
        /// <returns>Les reponses, concernant un sujet dont l'id est passé en param</returns>
        public static List<Reponse> GetAllReponseBySujet(int idSujet)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllReponseBySujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdSujet";
            parm.Value = idSujet;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Reponses");
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                List<Reponse> _Reponses = new List<Reponse>();
                foreach (DataRow row in dt.Rows)
                {
                    Reponse reponse = new Reponse(int.Parse(row["ID_REPONSE"].ToString()), row["TEXT_REPONSE"].ToString(), DateTime.Parse(row["DATECREATION"].ToString()),SujetDAO.GetSujetByID(idSujet) ,UtilisateurDAO.GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString())));
                    _Reponses.Add(reponse);
                }
                return _Reponses;
            }
            return null;
        }

        /// <summary>
        /// La méthode AddReponse, permet l'ajout d'une nouvelle reponse au sujet
        /// Dont l'identifiant est passé en paramètre, par un utilisteur connecté
        /// </summary>
        /// <param name="idUtilisateur">L'identifiant de l'utilisateur</param>
        /// <param name="idSujet">L'identifiant du sujet</param>
        /// <param name="texte">Le texte de la reponse</param>
        /// <returns>le nombre de lignes ajoutées, nbligne = 1 si tout se passe bien</returns>
        public static int AddReponse(int idUtilisateur, int idSujet, string texte)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "AddReponse";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdUser = cmd.CreateParameter();
            parmIdUser.ParameterName = "@ID_UTILISATEUR";
            parmIdUser.Value = idUtilisateur;
            cmd.Parameters.Add(parmIdUser);

            SqlParameter parmIdSujet = cmd.CreateParameter();
            parmIdSujet.ParameterName = "@ID_SUJET";
            parmIdSujet.Value = idSujet;
            cmd.Parameters.Add(parmIdSujet);

            SqlParameter parmText = cmd.CreateParameter();
            parmText.ParameterName = "@TEXT_REPONSE";
            parmText.Value = texte;
            cmd.Parameters.Add(parmText);

            con.Open();
            //Excute une action T-SQL sur la connection et retourne le nombres de lignes affectées
            int nbLigne = cmd.ExecuteNonQuery();
            con.Close();
            return nbLigne;
        }

        /// <summary>
        /// La méthode DeleteReponse, permet de supprimé une reponse
        /// Dont l'id est passé en paramètre
        /// </summary>
        /// <param name="idReponse">L'identifiant de la reponse</param>
        /// <returns>Le nombre de lignes supprimées, nbligne = 1 si tout va bien</returns>
        public static int DeleteReponse(int idReponse)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DeleteReponse";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdReponse = cmd.CreateParameter();
            parmIdReponse.ParameterName = "@ID_REPONSE";
            parmIdReponse.Value = idReponse;
            cmd.Parameters.Add(parmIdReponse);

            con.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            con.Close();
            return nbLigne;
        }
        #endregion

        #region "Méthodes héritées et substituées"
        #endregion

        #region "Méthodes à implementer pour les interfaces"
        #endregion
    }
}
