using CommunityDevelopers2ISAMetiers;
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
        /// Méthode permettant de retourner la liste des catégories
        /// </summary>
        /// <returns>Retourne la Liste des catégories, présent dans le forum</returns>
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
        /// Méthode permettant de retourner une catégorie, en lui passant l'identifiant en paramètre
        /// </summary>
        /// <param name="idCategorie">L'identifiant de la catégorie</param>
        /// <returns>Une catégorie, en lui passant un Id en paramètre</returns>
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

        #region "Utilisateurs"
        /// <summary>
        /// Méthode permettant de verifier le login et le mot de passe d'un utilisateur pour la connexion à l'application
        /// </summary>
        /// <param name="login">Le pseudo de l'utilisateur</param>
        /// <param name="password">Le mot de passe de l'utilisateur</param>
        /// <returns>Retourne l'utilisateur, si le pseudo et mot de passe sont juste et que l'utilisateur est enregistré dans la BDD</returns>
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
        /// Méthode permettant de retourner un utilisateur et son rôle
        /// </summary>
        /// <param name="iduser">L'identifiant de l'utilisateur</param>
        /// <returns>Un utilisateur avec son rôle</returns>
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
        /// Méthode permettant de retourner la liste des utilisateurs enregistrés la base de données
        /// </summary>
        /// <returns>La liste de tous les utrilisateur</returns>
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
        /// Méthode permettant un sujet en lui passant l'identifiant en paramètre
        /// </summary>
        /// <param name="idsujet">L'identifiant du sujet</param>
        /// <returns>Un sujet</returns>
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
        /// Méthode permettant de recuperer la liste des sujets
        /// </summary>
        /// <returns>Une liste de sujets </returns>
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
        /// Méthode permettant de recuperer tous les sujets d'une catégorie, en lui passant l'identifiant 
        /// De la catégorie en paramètre
        /// </summary>
        /// <param name="idcategorie">L'identifiant de la catégorie</param>
        /// <returns>La liste des sujets de la catégorie</returns>
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
        /// Méthode permettant d'ajouter un nouveau sujet dans une catégorie
        /// Avec le nom de l'auteur, le titre du sujet, la description et la date
        /// </summary>
        /// <param name="idUtilisateur">L'identifiant de l'utilisateur</param>
        /// <param name="idCategorie">Identifiant de la catégorie</param>
        /// <param name="titre">Le titre du sujet</param>
        /// <param name="description">La description du sujet</param>
        /// <returns>Retoure le chiffre 1 si tout ce passe bien</returns>
        public static int AddSujet(int idUtilisateur, int idCategorie, string titre, string description)
        {
            return SujetDAO.AddSujet(idUtilisateur, idCategorie, titre, description);
        }

        /// <summary>
        /// Méthode permettant la modification d'un sujet
        /// La modification concerne le titre ou la description, en lui passant l'identifiant du sujet à modifier 
        /// </summary>
        /// <param name="idsujet">L'identifiant du sujet</param>
        /// <param name="oldTitre">L'ancien Titre</param>
        /// <param name="oldDescription">L'ancienne discription</param>
        /// <param name="newTitre">Le nouveau Titre</param>
        /// <param name="newDescription">La nouvelle description</param>
        /// <returns>Retourn 1 quand ca se passe bien</returns>
        public static int ModifierSujet(int idsujet, string oldTitre, string oldDescription, string newTitre, string newDescription)
        {
            return SujetDAO.ModifierSujet(idsujet, oldTitre, oldDescription, newTitre, newDescription);
        }

        /// <summary>
        /// Méthode permettant la suppression d'un sujet
        /// en lui passant l'identifiant du sujet
        /// </summary>
        /// <param name="idSujet">L'identifiant</param>
        /// <returns>Retourn 1 quand ca se passe bien</returns>
        public static int DeleteSujet(int idSujet)
        {
            return SujetDAO.DeleteSujet(idSujet);
        }

        #endregion

        #region "Réponses"

        /// <summary>
        /// Méthode permettant de recuperer la liste des réponses
        /// Pour un sujet donné, en lui passant en paramètre l'identifiant du sujet
        /// </summary>
        /// <param name="idSujet">L'identifiant du sujet</param>
        /// <returns>La liste des réponses </returns>
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
        /// Méthode permettant l'ajout d'une réponse, avec le nom de l'auteur et la date de création
        /// Dans un sujet donné en lui passant en paramètre l'identifiant de sujet 
        /// </summary>
        /// <param name="idUtilisateur">L'identifiant de l'utilisateur</param>
        /// <param name="idSujet">L'identifiant du sujet</param>
        /// <param name="texte">Le texte de la réponse</param>
        /// <returns>Retourne 1 si tout ce passe bien</returns>
        public static int AddReponse(int idUtilisateur, int idSujet, string texte)
        {
            return ReponseDAO.AddReponse(idUtilisateur, idSujet, texte);
        }

        /// <summary>
        /// Méthode permettant de suppression d'une reponse
        /// En lui passant l'identifiant de la réponse 
        /// </summary>
        /// <param name="idReponse">L'identifiant de la réponse</param>
        /// <returns>Retourne 1 si tout ce passe bien</returns>
        public static int DeleteReponse(int idReponse)
        {
            return ReponseDAO.DeleteReponse(idReponse);
        }
        #endregion

    }
}
