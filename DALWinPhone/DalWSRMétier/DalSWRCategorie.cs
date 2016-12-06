using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DALWinPhone
{
    /// <summary>
    /// TODO
    /// </summary>
    [DataContract]
    public class DalSWRCategorie
    {
        #region "Property et Attributs"
        /// <summary>
        /// L'identifiant de la rubrique
        /// </summary>
        private int _Id;

        [DataMember]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Le nom de la categorie
        /// </summary>
        private string _Libelle;

        [DataMember]
        public string Libelle
        {
            get { return _Libelle; }
            set { _Libelle = value; }
        }

        /// <summary>
        /// La description de la rubrique
        /// </summary>
        private string _Desc;

        [DataMember]
        public string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }

        #endregion

        #region "Constructeurs"

        /// <summary>
        /// Constructeur d'une categorie
        /// </summary>
        /// <param name="id">L'identifiant de la categorie</param>
        /// <param name="libelle">Le libelle (Nom) de la categorie</param>
        /// <param name="desc">La description de la categorie</param>
        public DalSWRCategorie(int id, string libelle, string desc):this(id,libelle)
        {
            _Desc = desc;
        }

        /// <summary>
        /// Constructeur d'une categorie sans description.
        /// </summary>
        /// <param name="id">L'identifiant de la categorie</param>
        /// <param name="libelle">Le nom de la categorie</param>
        public DalSWRCategorie(int id, string libelle)
        {
            this.Id = id;
            this.Libelle = libelle;
        }
        #endregion

        #region "Méthodes"
        #endregion

        #region "Méthodes héritées et substituées "
        #endregion
    }
}
