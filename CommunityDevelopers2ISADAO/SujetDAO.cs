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
    /// La classe SujetDAO, pemet la récupération de tous les sujets, l'ajout d'un sujet, la modéfication 
    /// ou la suppression dans la base de données
    /// </summary>
    public static class SujetDAO
    {
        #region "Property et attributs"
        private static SqlConnection con = ConnexionSql.GetConnexion();
        #endregion

        #region "Constructeurs"
        #endregion

        #region "Méthodes"
        /// <summary>
        /// La méthode GetSujetByID, permet de retourné un sujet dont l'identifiant est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifiant du sujet</param>
        /// <returns>Le sujet</returns>
        public static Sujet GetSujetByID(int idsujet)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetSujetByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdSujet";
            parm.Value = idsujet;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Sujet");
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Sujet sujet = new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE"].ToString(), row["DESCRIPTION"].ToString(), CategorieDAO.GetCategorieByID(int.Parse(row["ID_CATEGORIE"].ToString())));

                return sujet;
            }
            return null;
        }
        /// <summary>
        /// La méthode GetAllSujets, retourne tous les sujets
        /// </summary>
        /// <returns>Tous les sujets</returns>
        public static List<Sujet> GetAllSujets()
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllSujets";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("TousLesSujet");
            da.Fill(dt);
            //con.Close();

            if (dt.Rows.Count >= 1)
            {
                List<Sujet> _Sujets = new List<Sujet>();
                foreach (DataRow row in dt.Rows)
                {
                     Sujet sujet =(new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE"].ToString(), row["DESCRIPTION"].ToString(), CategorieDAO.GetCategorieByID(int.Parse(row["ID_CATEGORIE"].ToString()))));
                    _Sujets.Add(sujet);
                }
                return _Sujets;
            }
            return null;
        }

        /// <summary>
        /// La méthode GetSujetByCategorieID, permet de récupérer les sujet d'une catégorie
        /// Dont l'id est passé en parametre
        /// </summary>
        /// <param name="idcategorie">L'identifiant de la categorie</param>
        /// <returns>La liste des sujets d'une categorie</returns>
        public static List<Sujet> GetSujetsByCategorieID(int idcategorie)
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetSujetsByCategorieID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdCategorie";
            parm.Value = idcategorie;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("TousLesSujet");
            da.Fill(dt);
            //con.Close();

            if (dt.Rows.Count >= 1)
            {
                List<Sujet> _Sujets = new List<Sujet>();
                foreach (DataRow row in dt.Rows)
                {
                    Sujet sujet =(new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE"].ToString(), row["DESCRIPTION"].ToString(), CategorieDAO.GetCategorieByID(int.Parse(row["ID_CATEGORIE"].ToString()))));
                    _Sujets.Add(sujet);
                }
                return _Sujets;
            }
            return null;
        }

        /// <summary>
        /// La méthode AddSujet, permet l'ajout d'un nouveau sujet à la base de données
        /// </summary>
        /// <param name="idUtilisateur">L'identifiant de l'utilisateur</param>
        /// <param name="idCategorie">L'identifiant de la categorie</param>
        /// <param name="titre">Le titre du nouveau sujet</param>
        /// <param name="description">La description du sujet ajouter</param>
        /// <returns>retourne le nombre de lignes affectées, 1 si tout va bien</returns>
        public static int AddSujet(int idUtilisateur, int idCategorie, string titre, string description)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "AddSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdUtilisateur = cmd.CreateParameter();
            parmIdUtilisateur.ParameterName = "@ID_UTILISATEUR";
            parmIdUtilisateur.Value = idUtilisateur;
            cmd.Parameters.Add(parmIdUtilisateur);

            SqlParameter parmIdCategorie = cmd.CreateParameter();
            parmIdCategorie.ParameterName = "@ID_CATEGORIE";
            parmIdCategorie.Value = idCategorie;
            cmd.Parameters.Add(parmIdCategorie);

            SqlParameter parmTitre = cmd.CreateParameter();
            parmTitre.ParameterName = "@TITRE";
            parmTitre.Value = titre;
            cmd.Parameters.Add(parmTitre);

            SqlParameter parmDescr = cmd.CreateParameter();
            parmDescr.ParameterName = "@DESCRIPTION";
            parmDescr.Value = description;
            cmd.Parameters.Add(parmDescr);

            con.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            con.Close();
            return nbLigne;
        }

        /// <summary>
        /// La méthode ModifierSujet, permet la modification d'un sujet en lui changeant le titre
        /// On lui changeant le titre et/ou la description.
        /// On passe l'ancien sujet en paramètre
        /// </summary>
        /// <param name="sujet">Le sujet à modifier</param>
        /// <param name="newTitre">Le nouveau titre du sujet</param>
        /// <param name="newDescription">La nouvelle description</param>
        /// <returns>le nombre de ligne modifier, nbligne = 1 si tout va bien</returns>
        public static int ModifierSujet(Sujet sujet, string newTitre, string newDescription)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "EditSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdSujet = cmd.CreateParameter();
            parmIdSujet.ParameterName = "@ID_SUJET";
            parmIdSujet.Value = sujet.Id;
            cmd.Parameters.Add(parmIdSujet);

            SqlParameter parmNewTitre = cmd.CreateParameter();
            parmNewTitre.ParameterName = "@NEW_TITRE";
            parmNewTitre.Value = newTitre;
            cmd.Parameters.Add(parmNewTitre);

            SqlParameter parmOldTitre = cmd.CreateParameter();
            parmOldTitre.ParameterName = "@OLD_TITRE";
            parmOldTitre.Value = sujet.Titre;
            cmd.Parameters.Add(parmOldTitre);

            SqlParameter parmNewDescr = cmd.CreateParameter();
            parmNewDescr.ParameterName = "@NEW_DESC";
            parmNewDescr.Value = newDescription;
            cmd.Parameters.Add(parmNewDescr);

            SqlParameter parmOldDescr = cmd.CreateParameter();
            parmOldDescr.ParameterName = "@OLD_DESC";
            parmOldDescr.Value = sujet.Desc;
            cmd.Parameters.Add(parmOldDescr);

            con.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            con.Close();
            return nbLigne;

        }

        /// <summary>
        /// La méthode DeleteSujet, permet la suppression d'un sujet dont l'id est passé en paramètre
        /// </summary>
        /// <param name="idSujet">L'identifiant du sujet</param>
        /// <returns>le nombre de lignes suprimées, nbLigne = 1 si tout va bien </returns>
        public static int DeleteSujet(int idSujet)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DeleteSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdSujet = cmd.CreateParameter();
            parmIdSujet.ParameterName = "@ID_SUJET";
            parmIdSujet.Value = idSujet;
            cmd.Parameters.Add(parmIdSujet);

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
