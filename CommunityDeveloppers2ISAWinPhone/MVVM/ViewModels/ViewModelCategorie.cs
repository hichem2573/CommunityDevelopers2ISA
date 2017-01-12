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
    /// <summary>
    /// classe métier qui répresente catégorie et integre le DataBinding
    /// </summary>
    public class ViewModelCategorie : ViewModelBase
    {

        private ConsumeWSR _cdDAL;
        private int _idCategorie;
        private string _Libelle;
        private string _errorMessage;
        // Répresente une collection de données dynamiquement, qui fournit des notification lorsque les éléments sont ajoutés, supprimer 
        // Ou lorsque la liste entière est actualisée
        private ObservableCollection<ViewModelSujet> _colViewModelSujets;
        

        #region "Constructeur"

        // Constructeur internal car c'est la classe MonitorViewModel qui construit les catégories
        internal ViewModelCategorie(Categorie categorie, ConsumeWSR cdDAL)
        {
            _idCategorie = categorie.Id;
            _Libelle = categorie.Libelle;
            _cdDAL = cdDAL;
            // Initialisation d'une nouvelle instance de la classe ObservableCollection
            _colViewModelSujets = new ObservableCollection<ViewModelSujet>(); 

        }
            
        public int IdCategorie
        {
            get { return _idCategorie; }
            private set
            {
                if(_idCategorie !=value)
                {
                    _idCategorie = value;
                    RaisePropertyChanged();
                }
               
            }
        }

        public string Libelle
        {
            get { return _Libelle; }
            private set
            {
                if(_Libelle != value)
                {
                     _Libelle = value;
                      RaisePropertyChanged();
                }
               
            }
        }
        #endregion


        #region "propriétés Bindables"

        public ReadOnlyObservableCollection<ViewModelSujet> Sujet
            {
                get { return new ReadOnlyObservableCollection<ViewModelSujet>(_colViewModelSujets); }
            }

            public string ErrorMessage
            {
                get { return _errorMessage; }
                private set
                {
                    if (_errorMessage != value)
                    {
                        _errorMessage = value;
                        RaisePropertyChanged();
                    }
                }
            }
        #endregion

        #region "Méthodes"

        public override string ToString()
        {
            return Libelle;
        }

        public async Task getSujetByCategorieID()
        {
            List<Sujet> sujets = await _cdDAL.getSujetByCategorieID(IdCategorie);
            MAJ_Sujets(sujets);
   
        }

        private void MAJ_Sujets(List<Sujet> sujets)
        {
            if(sujets != null)
            {
                _colViewModelSujets.Clear();
                foreach (Sujet sujet in sujets)
                {
                    ViewModelSujet sujetVM = new ViewModelSujet(sujet, _cdDAL);

                    if (!_colViewModelSujets.Contains(sujetVM))
                    {
                        _colViewModelSujets.Add(sujetVM);
                       
                    }
                    
                }
            }
            else
            {
                ErrorMessage = "La catégorie choisi ne contient pas de sujets !";
            }

        }
        #endregion
    }
}
