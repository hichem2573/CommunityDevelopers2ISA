using CommunityDevelopers2ISAMetiers;
using ConsumeWebServiceRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityDeveloppers2ISAWinPhone
{
    public class ViewModelReponse : ViewModelBase
    {
        private ConsumeWSR _cdDAL;
        private int _idReponse;
        private string _Texte;
        private string _Auteur;
        private DateTime _Date;


        internal ViewModelReponse(Reponse reponse, ConsumeWSR cdDaL)
        {
            _cdDAL = cdDaL;
            _idReponse = reponse.Id;
            _Texte = reponse.Texte;
            _Auteur = reponse.Auteur;
            _Date = reponse.Date;
        }

        public int idReponse
        {
            get { return _idReponse; }
            private set
            {
                if(_idReponse != value)
                {
                    _idReponse = value;
                    RaisePropertyChanged();
                }
                
            }
        }

        public string Texte
        {
            get { return _Texte; }
            private set
            {
                if(_Texte != value)
                {
                     _Texte = value;
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
    }
}
