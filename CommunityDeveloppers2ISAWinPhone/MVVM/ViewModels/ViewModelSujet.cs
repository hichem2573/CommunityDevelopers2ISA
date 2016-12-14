using CommunityDevelopers2ISAMetiers;
using ConsumeWebServiceRest;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityDeveloppers2ISAWinPhone
{
    public class ViewModelSujet : ViewModelBase
    {
        //private ConsumeWSR _cdDAL;
        private int _idSujet;
        private string _Titre;
        private string _Auteur;
        private DateTime _Date;

        private ObservableCollection<ViewModelReponse> _colViewModelReponses;


        internal ViewModelSujet(Sujet sujet, ConsumeWSR cdDAl)
        {
            _idSujet = sujet.Id;
            _Titre = sujet.Titre;
            _Auteur = sujet.Auteur;
            _Date = sujet.Date;
            _colViewModelReponses = new ObservableCollection<ViewModelReponse>();
        }

        public int IdSujet
        {
            get { return _idSujet; }
            private set
            {
                _idSujet = value;
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

        public string Auteur
        {
            get { return _Auteur; }
            private set
            {
                _Auteur = value;
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

        public ReadOnlyObservableCollection<ViewModelReponse> Reponses
        {
            get { return new ReadOnlyObservableCollection<ViewModelReponse>(_colViewModelReponses); }
        }

       
    }
}
