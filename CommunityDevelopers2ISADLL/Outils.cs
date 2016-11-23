using CommunityDevelopers2ISADAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityDevelopers2ISADLL
{
    /// <summary>
    /// 
    /// </summary>
    public class Outils
    {
        #region "Categories"
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Categorie> GetAllCategories()
        {
            DataTable dt = CategorieDAO.GetAllCategories();
            if (dt.Rows.Count >= 1)
            {
                List<Categorie> _Categories = new List<Categorie>();
                foreach (DataRow row in dt.Rows)
                {
                    Categorie categorie = new Categorie(int.Parse(row["ID_CATEGORIE"].ToString()), row["NOM_CATEGORIE"].ToString());
                    categorie.Id = int.Parse(row["ID_CATEGORIE"].ToString());
                    _Categories.Add(categorie);
                }
                return _Categories;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idCategorie"></param>
        /// <returns></returns>
        public static Categorie GetCategorieByID(int idCategorie)
        {
            DataTable dt = CategorieDAO.GetCategorieByID(idCategorie);
            if (dt.Rows.Count == 1)
            {

                DataRow row = dt.Rows[0]; //On obtient la ligne à l'index specifier ici 0 c'est la 1er ligne
                Categorie categorie = new Categorie(idCategorie, row["NOM_CATEGORIE"].ToString());
                return categorie;
            }
            return null;
        }

        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        #region "Utilisateurs"
        public static Utilisateur Login(string login, string password)
        {
            DataTable dt = UtilisateurDAO.Login(login, password);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                return GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString()));
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iduser"></param>
        /// <returns></returns>
        public static Utilisateur GetUtilisateurByID(int iduser)
        {
            DataTable dt = UtilisateurDAO.GetUtilisateurByID(iduser);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                Utilisateur user = new Utilisateur(int.Parse(row["ID_UTILISATEUR"].ToString()), row["LOGIN"].ToString(), row["PASSWORD"].ToString(), (bool)row["ROLEMODERA"]);
                return user;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Utilisateur> GetAllUtilisateur()
        {
            DataTable dt = UtilisateurDAO.GetAllUtilisateur();
            if (dt.Rows.Count >= 1)
            {
                List<Utilisateur> _Utilisateurs = new List<Utilisateur>();
                foreach (DataRow row in dt.Rows)
                {
                    Utilisateur user = new Utilisateur(int.Parse(row["ID_UTILISATEUR"].ToString()), row["LOGIN"].ToString(), row["PASSWORD"].ToString(), (bool)row["ROLEMODERA"]);
                    _Utilisateurs.Add(user);
                }
                return _Utilisateurs;
            }
            return null;
        }

        public static int EditPassword(int iduser, string password)
        {
            return UtilisateurDAO.EditPassword(iduser, password);
        }
        #endregion

        #region "Sujets"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idsujet"></param>
        /// <returns></returns>
        public static Sujet GetSujetByID(int idsujet)
        {
            DataTable dt = SujetDAO.GetSujetByID(idsujet);
            if (dt.Rows.Count == 1)
            {
                DataRow row = dt.Rows[0];
                //Sujet sujet = new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE"].ToString(), row["DESCRIPTION"].ToString(), GetCategorieByID(int.Parse(row["ID_CATEGORIE"].ToString())));
                Sujet sujet = new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE"].ToString(), row["DESCRIPTION"].ToString(), DateTime.Parse(row["DATECREATION"].ToString()), GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString())), GetCategorieByID(int.Parse(row["ID_CATEGORIE"].ToString())));
                return sujet;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<Sujet> GetAllSujets()
        {
            DataTable dt = SujetDAO.GetAllSujets();

            if (dt.Rows.Count >= 1)
            {
                List<Sujet> _Sujets = new List<Sujet>();
                foreach (DataRow row in dt.Rows)
                {
                    Sujet sujet = new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE"].ToString(), row["DESCRIPTION"].ToString(), DateTime.Parse(row["DATECREATION"].ToString()), GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString())), GetCategorieByID(int.Parse(row["ID_CATEGORIE"].ToString())));
                    //Sujet sujet = (new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE"].ToString(), row["DESCRIPTION"].ToString(), GetCategorieByID(int.Parse(row["ID_CATEGORIE"].ToString()))));
                    _Sujets.Add(sujet);
                }
                return _Sujets;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idcategorie"></param>
        /// <returns></returns>
        public static List<Sujet> GetSujetsByCategorieID(int idcategorie)
        {
            DataTable dt = SujetDAO.GetSujetsByCategorieID(idcategorie);
            if (dt.Rows.Count >= 1)
            {
                List<Sujet> _Sujets = new List<Sujet>();
                foreach (DataRow row in dt.Rows)
                {
                    //Reponse reponse = new Reponse(int.Parse(row["ID_REPONSE"].ToString()), row["TEXT_REPONSE"].ToString(), DateTime.Parse(row["DATECREATION"].ToString()), GetSujetByID(idSujet), GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString())));
                    Sujet sujet = new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE"].ToString(), row["DESCRIPTION"].ToString(), DateTime.Parse(row["DATECREATION"].ToString()), GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString())), GetCategorieByID(int.Parse(row["ID_CATEGORIE"].ToString())));
                    //Sujet sujet = (new Sujet(int.Parse(row["ID_SUJET"].ToString()), row["TITRE"].ToString(), row["DESCRIPTION"].ToString(),  GetCategorieByID(int.Parse(row["ID_CATEGORIE"].ToString()))));
                    _Sujets.Add(sujet);
                }
                return _Sujets;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idCategorie"></param>
        /// <param name="titre"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        public static int AddSujet(int idUtilisateur, int idCategorie, string titre, string description)
        {
            return SujetDAO.AddSujet(idUtilisateur, idCategorie, titre, description);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idsujet"></param>
        /// <param name="oldTitre"></param>
        /// <param name="oldDescription"></param>
        /// <param name="newTitre"></param>
        /// <param name="newDescription"></param>
        /// <returns></returns>
        public static int ModifierSujet(int idsujet, string oldTitre, string oldDescription, string newTitre, string newDescription)
        {
            return SujetDAO.ModifierSujet(idsujet, oldTitre, oldDescription, newTitre, newDescription);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idSujet"></param>
        /// <returns></returns>
        public static int DeleteSujet(int idSujet)
        {
            return SujetDAO.DeleteSujet(idSujet);
        }

        #endregion

        #region "Réponses"

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idSujet"></param>
        /// <returns></returns>
        public static List<Reponse> GetAllReponseBySujet(int idSujet)
        {
            DataTable dt = ReponseDAO.GetAllReponseBySujet(idSujet);
            if (dt.Rows.Count >= 1)
            {
                List<Reponse> _Reponses = new List<Reponse>();
                foreach (DataRow row in dt.Rows)
                {
                    Reponse reponse = new Reponse(int.Parse(row["ID_REPONSE"].ToString()), row["TEXT_REPONSE"].ToString(), DateTime.Parse(row["DATECREATION"].ToString()), GetSujetByID(idSujet), GetUtilisateurByID(int.Parse(row["ID_UTILISATEUR"].ToString())));
                    _Reponses.Add(reponse);
                }
                return _Reponses;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <param name="idSujet"></param>
        /// <param name="texte"></param>
        /// <returns></returns>
        public static int AddReponse(int idUtilisateur, int idSujet, string texte)
        {
            return ReponseDAO.AddReponse(idUtilisateur, idSujet, texte);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idReponse"></param>
        /// <returns></returns>
        public static int DeleteReponse(int idReponse)
        {
            return ReponseDAO.DeleteReponse(idReponse);
        }
        #endregion

    }
}
