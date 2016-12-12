using CommunityDevelopers2ISADAL;
using ConsumeWebServiceRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityDeveloppers2ISAWinPhone
{
    public class ViewModelCategorie : ViewModelBase
    {

        private ConsumeWSR _cdDAL;
        private int _idCategorie;
        private string _Libelle;

        #region "Constructeur"

        internal ViewModelCategorie (Categorie categorie, ConsumeWSR cdDAL)
        {
            _idCategorie = categorie.Id;
            _Libelle = categorie.Libelle;
            _cdDAL = cdDAL;

            #endregion

            #region "P¨ropriétés Bindables"

        public int IdCategorie
        {
            get { return _idCategorie; }
            private set
            {
                _idCategorie = value;
                RaisePropertyChanged();
            }
        }

        public string Libelle
        {
            get { return _Libelle; }
            private set
            {
                _Libelle = value;
                RaisePropertyChanged();
            }
        }

        #region "Méthodes"

        public override string ToString()
        {
            return Libelle;
        }
        #endregion

        #endregion
    }
}
