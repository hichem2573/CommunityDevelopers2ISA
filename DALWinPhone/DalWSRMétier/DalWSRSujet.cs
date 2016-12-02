using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DALWinPhone
{
    [DataContract]
    public class DalWSRSujet
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
        private DalSWRCategorie _Categorie;

        [DataMember]
        public DalSWRCategorie Categorie
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
        private List<DalWSRReponse> _Reponse;

        [DataMember]
        public List<DalWSRReponse> Reponses
        {
            get { return _Reponse; }
            set { _Reponse = value; }
        }

        /// <summary>
        /// L'utilisateur qui a crée et posté la reponse
        /// </summary>
        private DalWSRUtilisateur _Utilisateur;

        [DataMember]
        public DalWSRUtilisateur Utilisateur
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
        public DalWSRSujet(int id, string titre, string description, DalSWRCategorie categorie)
        {
            this.Id = id;
            this.Titre = titre;
            this.Desc = description;
            this.Categorie = categorie;
            this.Reponses = new List<DalWSRReponse>();
            this.Date = DateTime.Now;
        }

        public DalWSRSujet(int id, string titre, string description, DateTime date, DalWSRUtilisateur utilisateur, DalSWRCategorie categorie) : this(id, titre, description, categorie)
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
        public DalWSRSujet(int id, string description, string titre, DalSWRCategorie categorie, List<DalWSRReponse> Reponses): this(id, titre, description, categorie)
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
