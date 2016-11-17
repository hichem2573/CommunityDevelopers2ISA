using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityDevelopers2ISAOutils
{
    public class Outil
    {
        //#region "Méthode Catégorie"

        ///// <summary>
        ///// La méthode, permet la liste des categorie
        ///// </summary>
        ///// <returns>La méthode fait appel à sa méthode dans la classe categorieDAO</returns>
        //public static List<Categorie> GetAllCategories()
        //{
        //    DataTable dt = CategorieDAO.GetAllCategories();
        //         if (dt.Rows.Count >= 1)
        //    {
        //        List<Categorie> _Categories = new List<Categorie>();
        //        foreach (DataRow row in dt.Rows)
        //        {
        //            Categorie categorie = new Categorie(int.Parse(row["ID_CATEGORIE"].ToString()), row["NOM_CATEGORIE"].ToString());
        //            categorie.Id = int.Parse(row["ID_CATEGORIE"].ToString());
        //            _Categories.Add(categorie);
        //        }
        //        return _Categories;
        //    }
        //    return null;
        //}

        ///// <summary>
        ///// La methode, permet la récupération d'une catégorie, dont l'id est passé en paramètre
        ///// </summary>
        ///// <param name="idCategorie"></param>
        ///// <returns>
        ///// La méthode fait appel à sa méthode dans la classe CategorieDAO
        ///// Dont l'id de la categorie est passé en param
        ///// </returns>
        //public static Categorie GetCategorieByID(int idCategorie)
        //{
        //    return CategorieDAO.GetCategorieByID(idCategorie);
        //}

        //#endregion

        //#region "Méthode Utilisateur"

        ///// <summary>
        ///// permet à un utilisateur de se connecté
        ///// </summary>
        ///// <param name="login">Le login de l'utilisateur</param>
        ///// <param name="password">Le mdp de l'utilisateur</param>
        ///// <returns>
        ///// La méthode fait appel à sa méthode dans la classe UtilisateurDAO
        ///// Dont le login et mdp sont passé en param
        ///// </returns>
        //public static Utilisateur Login(string login, string password)
        //{
        //    return UtilisateurDAO.Login(login, password);
        //}

        //public static int EditPassword(int iduser, string password)
        //{
        //    return UtilisateurDAO.EditPassword(iduser, password);
        //}
        //#endregion

        //#region "Méthode Sujet"

        ///// <summary>
        ///// La méthode permet de récupérer un sujet, dont l'id est passé en paramètre
        ///// </summary>
        ///// <param name="idsujet">L'identifiant du sujet</param>
        ///// <returns>
        ///// La méthode fait appel à sa méthode dans la classe SujetDAO
        ///// Dont l'id du sujet est passé en param
        ///// </returns>
        //public static Sujet GetSujetByID(int idsujet)
        //{
        //    return SujetDAO.GetSujetByID(idsujet);
        //}

        ///// <summary>
        ///// la méthode permet de récupérer tous les sujets
        ///// </summary>
        ///// <returns>
        ///// La méthode fait appel à sa méthode dans la classe SujetDAO
        ///// </returns>
        //public static List<Sujet> GetAllSujets()
        //{
        //    return SujetDAO.GetAllSujets();
        //}

        ///// <summary>
        ///// méthode permettant, de récupérer tous les sujets d'une categorie
        ///// </summary>
        ///// <param name="idcategorie"></param>
        ///// <returns>
        ///// La méthode GetSujetByCategorieID fait appel à sa méthode dans la classe SujetDAO
        ///// Dont l'id categorie est passé en param
        ///// </returns>
        //public static List<Sujet> GetSujetsByCategorieID(int idcategorie)
        //{
        //    return SujetDAO.GetSujetsByCategorieID(idcategorie);
        //}

        ///// <summary>
        ///// La méthode AddSujet, permet l'ajout d'un sujet par un utilisateur connecté
        ///// </summary>
        ///// <param name="idUtilisateur">L'identifiant utilisateur</param>
        ///// <param name="idCategorie">L'id de la categorie</param>
        ///// <param name="titre">le titre du sujet</param>
        ///// <param name="description">La description du sujet</param>
        ///// <returns>
        ///// La méthode AddSujet fait appel à sa méthode dans la classe SujetDAO
        ///// Dont le param est l'iduser, idcat, le titre et la description
        ///// </returns>
        //public static int AddSujet(int idUtilisateur, int idCategorie, string titre, string description)
        //{
        //    return SujetDAO.AddSujet(idUtilisateur, idCategorie, titre, description);
        //}

        ///// <summary>
        ///// la méthode ModifierSujet, permet la modification d'un sujet
        ///// </summary>
        ///// <param name="sujet">L'identifiant su sujet</param>
        ///// <param name="newTitre">Nouveau titre</param>
        ///// <param name="newDescription">La nouvelle description</param>
        ///// <returns>
        ///// fait appel à sa méthode dans la classe SujetDAO, Dont le sujet
        ///// Le nouveau titre et la nouvelle description sont passé en param
        ///// </returns>
        //public static int ModifierSujet(Sujet sujet, string newTitre, string newDescription)
        //{
        //    return SujetDAO.ModifierSujet(sujet, newTitre, newDescription);
        //}

        ///// <summary>
        ///// La méthode DeleteSujet, permet la suppression d'un sujet
        ///// Dont l'id est passé en paramètre
        ///// </summary>
        ///// <param name="idSujet">L'identifiant de la reponse</param>
        ///// <returns>
        ///// La méthode DeleteSujet fait appel à sa méthode dans la classe SujetDAO
        ///// Dont le param est l'id </returns>
        //public static int DeleteSujet(int idSujet)
        //{
        //    return SujetDAO.DeleteSujet(idSujet);
        //}
        //#endregion

        //#region "Méthode Reponse"
        ///// <summary>
        ///// LA méthode GetAllBySujet, permet de récupérer toutes les reponse d'un sujet
        ///// Dont l'id est passé en param
        ///// </summary>
        ///// <param name="idSujet"></param>
        ///// <returns>
        ///// La méthode GetAllBySujet fait appel à sa méthode dans la classe ReponseDAO
        ///// Dont le param est idSujet 
        ///// </returns>
        //public static List<Reponse> GetAllReponseBySujet(int idSujet)
        //{
        //    return ReponseDAO.GetAllReponseBySujet(idSujet);
        //}

        ///// <summary>
        ///// La méthode AddReponse, permet l'ajout d'une reponse par un utilisateur connecté
        ///// </summary>
        ///// <param name="idUtilisateur">L'identifiant de l'utilisateur</param>
        ///// <param name="idSujet">L'identifiant du sujet</param>
        ///// <param name="texte">Le texte de la reponse</param>
        ///// <returns>
        ///// La méthode AddReponse fait appel à sa méthode dans la classe ReponseDAO
        ///// Dont le param est l'iduser, idSujet et le texte
        ///// </returns>
        //public static int AddReponse(int idUtilisateur, int idSujet, string texte)
        //{
        //    return ReponseDAO.AddReponse(idUtilisateur, idSujet, texte);
        //}

        ///// <summary>
        ///// La méthode DeleteReponse, permet la suppression d'une reponse
        ///// Dont l'id est passé en paramètre
        ///// </summary>
        ///// <param name="idReponse">L'identifiant de la reponse</param>
        ///// <returns>
        ///// La méthode DeleteReponse fait appel à sa méthode dans la classe ReponseDAO
        ///// Dont le param est l'id </returns>
        //public static int DeleteReponse(int idReponse)
        //{
        //    return ReponseDAO.DeleteReponse(idReponse);
        //}
        //#endregion
    }
}
