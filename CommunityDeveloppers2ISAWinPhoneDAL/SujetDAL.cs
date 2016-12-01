using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommunityDeveloppers2ISAWinPhoneDAL
{

    /// <summary>
    /// La classe sujet, permet de voir tous les sujets d'une rubrique
    /// Pemet de voir les reponses, concernant un sujet
    /// Elle comporte un identifiant, titre du sujet, la description, la rubrique et les reponses
    /// </summary>
    [Serializable]
    [DataContract]
    public class SujetDAL
    {
        #region "Property et Attributs"
        /// <summary>
        /// l'identifiant du sujet
        /// </summary>
        private int _Id;

        [DataMember]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        /// <summary>
        /// La description d'un sujet
        /// </summary>
        private string _Desc;

        [DataMember]
        public string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }

        /// <summary>
        /// La date de création du sujet
        /// </summary>
        private DateTime _Date;

        [DataMember]
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        /// <summary>
        /// La categorie à la quelle appartient le sujet
        /// </summary>
        private CategorieDAL _Categorie;

        [DataMember]
        public CategorieDAL Categorie
        {
            get { return _Categorie; }
            set { _Categorie = value; }
        }

        /// <summary>
        /// Le Titre du sujet
        /// </summary>
        private string _Titre;

        [DataMember]
        public string Titre
        {
            get { return _Titre; }
            set { _Titre = value; }
        }

        /// <summary>
        /// La liste des réponses, concernant un sujet
        /// </summary>
        private List<ReponseDAL> _Reponse;

        [DataMember]
        public List<ReponseDAL> Reponse
        {
            get { return _Reponse; }
            set { _Reponse = value; }
        }

        /// <summary>
        /// L'utilisateur qui a crée et posté la reponse
        /// </summary>
        private UtilisateurDAL _Utilisateur;

        [DataMember]
        public UtilisateurDAL Utilisateur
        {
            get { return _Utilisateur; }
            set { _Utilisateur = value; }
        }

        /// <summary>
        /// L'auteur de la reponse
        /// </summary>
        private string _Auteur;

        [DataMember]
        public string Auteur
        {
            get { return _Auteur; }
            set { _Auteur = value; }
        }
        #endregion

        #region "Constructeurs"
        /// <summary>
        /// Constructeur d'un nouveau sujet, sans reponse
        /// </summary>
        /// <param name="id">L'identifiant du sujet</param>
        /// <param name="titre">Le titre du sujet</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="categorie">La categorie à la quelle appatient le sujet</param>
        public SujetDAL(int id, string titre, string description, CategorieDAL categorie)
        {
            this.Id = id;
            this.Titre = titre;
            this.Desc = description;
            this.CategorieDal = categorie;
            this.Reponses = new List<Reponse>();
            this.Date = DateTime.Now;
        }

        public SujetDAL(int id, string titre, string description, DateTime date, UtilisateurDAL utilisateur, CategorieDAL categorie) : this(id, titre, description, categorie)
        {
            this.Date = date;
            this.Utilisateur = utilisateur;
            this.Auteur = utilisateur.Login;
        }

        /// <summary>
        /// Constructeur d'un objet sujet, ayant des reponse
        /// </summary>
        /// <param name="id">L'identifiant du sujet</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="titre">Le titre du sujet</param>
        /// <param name="categorie">La categorie à la quelle appartient le sujet</param>
        /// <param name="Reponses">Les reponses du sujet</param>
        public SujetDAL(int id, string description, string titre, CategorieDAL categorie, List<Reponse> Reponses): this(id, titre, description, categorie)
        {
            this.Reponses = Reponses;
        }
        #endregion

        #region "Méthodes"
        public string GetNomUtilisateur()
        {
            return Utilisateur.Login;
        }
        #endregion

        #region "Méthodes héritées et substituées "
        #endregion

        #region "Méthodes à implementer pour les interfaces"
        #endregion
    }
}
