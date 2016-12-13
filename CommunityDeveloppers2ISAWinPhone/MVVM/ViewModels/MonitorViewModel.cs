using ConsumeWebServiceRest;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using CommunityDevelopers2ISAMetiers;

namespace CommunityDeveloppers2ISAWinPhone
{
    public class MonitorViewModel : ViewModelBase 
    {
        private ConsumeWSR _cdDAL;
        private ObservableCollection<ViewModelCategorie> _colViewModelCategorie;


        public MonitorViewModel()
        {
            _cdDAL = new ConsumeWSR();
            _colViewModelCategorie = new ObservableCollection<ViewModelCategorie>();
        }

        #region "Propriétés Bindables"

        public ReadOnlyObservableCollection<ViewModelCategorie> Categorie
        {
            get { return new ReadOnlyObservableCollection<ViewModelCategorie>(_colViewModelCategorie); }
        }

        #endregion

        #region "Méthodes"

        public async Task GetCategorie()
        {
            List<Categorie> categories = await _cdDAL.getCategorie();
            MAJ_Categories(categories);
        }

        private void MAJ_Categories(List<Categorie> categories)
        {
            foreach(Categorie categorie in categories)
            {
                ViewModelCategorie categorieVM = new ViewModelCategorie(categorie, _cdDAL);

                if (!_colViewModelCategorie.Contains(categorieVM))
                {
                    _colViewModelCategorie.Add(categorieVM);
                }
            }
        }

        #endregion
    }
}
