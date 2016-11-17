using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CommunityDevelopers2ISADLL
{
    /// <summary>
    /// La classe Utilisateur permet à un utilisateur de s'identifier avec 
    /// son login (nom) et son mot de passe
    /// </summary>
    [Serializable]
    [DataContract]
    public class Utilisateur
    {

        #region "Property et Attributs"

        /// <summary>
        /// L'identifiant de l'utilisateur
        /// </summary>
        private int _Id;

        [DataMember]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Le login (nom) de l'utilisateur
        /// </summary>
        private string _Login;

        [DataMember]
        public string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }
        /// <summary>
        /// Le mot de passe de l'utilisateur
        /// </summary>
        private string _Mdp;

        [DataMember]
        public string Mdp
        {
            get { return _Mdp; }
            set { _Mdp = value; }
        }

        /// <summary>
        /// Le role de l'utilisateur, soit il est modérateur ou un utilisateur logged
        /// </summary>
        private bool _IsRmode;

        [DataMember]
        public bool IsRmode
        {
            get { return _IsRmode; }
            set { _IsRmode = value; }
        }

        

        #endregion

        #region "Constructeurs"

        /// <summary>
        /// constructeur d'un utilisateur
        /// </summary>
        /// <param name="id">L'identifiant de l'utilisateur</param>
        /// <param name="login">le login de l'utilisateur (ici son nom)</param>
        /// <param name="mdp">Le mot de passe de l'utilisateur</param>
        /// <param name="isRmodo">Le role de l'utilisateur, soit utilisateur connecté soit modérateur</param>
        public Utilisateur(int id, string login, string mdp, bool isRmodo)
        {
            this.Id = id;
            this.Login = login;
            this.Login = mdp;
            this.IsRmode = isRmodo;
        }
        #endregion

        #region "Méthodes"
          
        #endregion


        #region "Méthodes héritées et substituées "

        #endregion

        #region "Méthodes à implementer pour les interfaces"
        #endregion
    }

   
}
