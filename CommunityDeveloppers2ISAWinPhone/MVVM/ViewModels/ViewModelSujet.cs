using CommunityDevelopers2ISAMetiers;
using ConsumeWebServiceRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityDeveloppers2ISAWinPhone
{
    public class ViewModelSujet : ViewModelBase
    {
        private ConsumeWSR _cdDal;
        private int _idSujet;
        private string _Auteur;
        private string _Titre;
        private DateTime _Date;
        //private Categorie _Categorie;


        internal ViewModelSujet(Sujet sujet, ConsumeWSR cdDAL)
        {
            _idSujet = sujet.Id;
            _Auteur = sujet.Auteur;
            _Titre = sujet.Titre;
            _Date = sujet.Date;
            //_Categorie = sujet.Categorie;

        }

        public int IdSujet
        {
            get { return _idSujet }
            private set
            {
                _idSujet = value;
                RaisePropertyChanged();
            }
        }

        public string Auteur
        {
            get { return _Auteur; }
            private set
            {
                _Auteur = value;
                RaisePropertyChanged();
            }
        }

        public string Titre
        {
            get { return _Titre; }
            private set
            {
                _Titre = value;
                RaisePropertyChanged();
            }
        }

        public DateTime Date
        {
            get { return _Date; }
            private set
            {
                _Date = value;
                RaisePropertyChanged();
            }
        }

    }
}
