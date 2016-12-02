using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALWinPhone
{

    public class DalWSRReponse
    {
        //[Serializable]

        //[DataContract]
        //#region "Property et Attributs"
        ///// <summary>
        ///// L'identifiant de la reponse
        ///// </summary>
        //private int _Id;

        //[DataMember]
        //public int Id
        //{
        //    get { return _Id; }
        //    set { _Id = value; }
        //}

        ///// <summary>
        ///// Le texte de la reponse
        ///// </summary>
        //private string _Texte;

        //[DataMember]
        //public string Texte
        //{
        //    get { return _Texte; }
        //    set { _Texte = value; }
        //}

        ///// <summary>
        /////Le sujet auquel appartient la reponse
        ///// </summary>
        //private Sujet _Sujet;

        //[DataMember]
        //public Sujet Sujet
        //{
        //    get { return _Sujet; }
        //    set { _Sujet = value; }
        //}

        ///// <summary>
        ///// La date de creation de la reponse
        ///// </summary>
        //private DateTime _Date;

        //[DataMember]
        //public DateTime Date
        //{
        //    get { return _Date; }
        //    set { _Date = value; }
        //}

        ///// <summary>
        ///// L'utilisateur qui a crée et posté la reponse
        ///// </summary>
        //private Utilisateur _Utilisateur;

        //[DataMember]
        //public Utilisateur Utilisateur
        //{
        //    get { return _Utilisateur; }
        //    set { _Utilisateur = value; }
        //}

        ///// <summary>
        ///// L'auteur de la reponse
        ///// </summary>
        //private string _Auteur;

        //[DataMember]
        //public string Auteur
        //{
        //    get { return _Auteur; }
        //    set { _Auteur = value; }
        //}


        //#endregion

        //#region "Constructeurs"
        ///// <summary>
        ///// Constructeur de la reponse
        ///// </summary>
        ///// <param name="id">L'identifiant de la reponse</param>
        ///// <param name="texte">Le texte de la reponse</param>
        ///// <param name="date">La date de création </param>
        ///// <param name="utilisateur">L'utilisateur qui a crée et posté la reponse</param>
        ///// <param name="sujet">Le sujet auquel appartient la reponse</param>
        //public DalWSRReponse(int id, string texte, DateTime date, Sujet sujet, Utilisateur utilisateur)
        //{
        //    this.Id = id;
        //    this.Texte = texte;
        //    this.Date = date;
        //    this.Auteur = utilisateur.Login;
        //    this.Sujet = sujet;
        //    this.Utilisateur = utilisateur;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="id"></param>
        ///// <param name="text"></param>
        //public DalWSRReponse(int id, string text)
        //{
        //    this.Id = id;
        //    this.Texte = text;
        //}

        //#endregion

        //#region "Méthodes"
        ///// <summary>
        ///// Méthode GetNomUtilisateur, permet de recupèré le nom d'auteur de la reponse
        ///// </summary>
        ///// <returns>Le nom de l'auteur de la reponse</returns>
        //public string GetNomUtilisateur()
        //{
        //    return Utilisateur.Login;
        //}
        //#endregion

        //#region "Méthodes héritées et substituées "
        //#endregion

        //#region "Méthodes à implementer pour les interfaces"
        //#endregion
    }
}
