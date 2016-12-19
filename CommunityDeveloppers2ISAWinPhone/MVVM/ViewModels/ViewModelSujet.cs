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
        private ConsumeWSR _cdDAL;
        private int _idSujet;
        private string _Titre;
        private string _Auteur;
        private DateTime _Date;

        private ObservableCollection<ViewModelReponse> _colViewModelReponses;


        internal ViewModelSujet(Sujet sujet, ConsumeWSR cdDAL)
        {
            _idSujet = sujet.Id;
            _Titre = sujet.Titre;
            _Auteur = sujet.Auteur;
            _Date = sujet.Date;
            _cdDAL = cdDAL;
           
            _colViewModelReponses = new ObservableCollection<ViewModelReponse>();
        }

        public int IdSujet
        {
            get { return _idSujet; }
            private set
            {
                if(_idSujet != value)
                {
                    _idSujet = value;
                    RaisePropertyChanged();
                }
                
            }
        }

        public string Titre
        {
            get { return _Titre; }
            private set
            {
                if(_Titre != value)
                {
                    _Titre = value;
                    RaisePropertyChanged();
                }
                
            }
        }

        public string Auteur
        {
            get { return _Auteur; }
            private set
            {
                if(_Auteur != value)
                {
                    _Auteur = value;
                    RaisePropertyChanged();
                }
                
            }
        }

        public DateTime Date
        {
            get { return _Date; }
            private set
            {
                if(_Date != value)
                {
                    _Date = value;
                    RaisePropertyChanged();
                }
               
            }
        }

        public ReadOnlyObservableCollection<ViewModelReponse> Reponse
        {
            get { return new ReadOnlyObservableCollection<ViewModelReponse>(_colViewModelReponses); }
        }

        #region "Méthodes"

        public async Task getReponseBySujet()
        {
            List<Reponse> reponses = await _cdDAL.getReponseBySujet(IdSujet);
            MAJ_Reponses(reponses);
        }

        private void MAJ_Reponses(List<Reponse> reponses)
        {
            _colViewModelReponses.Clear();
            foreach (Reponse reponse in reponses)
            {
                ViewModelReponse reponseVM = new ViewModelReponse(reponse, _cdDAL);
                if (!_colViewModelReponses.Contains(reponseVM))
                {
                    _colViewModelReponses.Add(reponseVM);
                }
            }
        }
        #endregion

    }
}
