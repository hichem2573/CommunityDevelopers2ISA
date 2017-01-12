using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d’élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkID=390556

namespace CommunityDeveloppers2ISAWinPhone
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static MonitorViewModel _monitorViewModel = new MonitorViewModel();

        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }
        /// <summary>
        /// Invoqué lorsque cette page est sur le point d'être affichée dans un frame.
        /// </summary>
        /// <param name="e">Données d'événement décrivant la manière dont l'utilisateur a accédé à cette page.
        /// Ce paramètre est généralement utilisé pour configurer la page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Binding de la source de données (MonitorViewModel) avec le contexte de la page
            DataContext = _monitorViewModel;

            // On s'abonne à l'événement système 'HardwareButtons_BackPressed'          
            HardwareButtons.BackPressed += HardwareButtons_BackPressed;

        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            HardwareButtons.BackPressed -= HardwareButtons_BackPressed;
        }
        private void HardwareButtons_BackPressed(object sender, BackPressedEventArgs e)
        {
            // On interdit la sortie de l'application par ce bouton
            e.Handled = true;
        }

        private async void btCategorie_Click(object sender, RoutedEventArgs e)
        {
            btCategorie.Visibility = Visibility.Collapsed;
            prCategorie.IsActive = true;
            prCategorie.Visibility = Visibility.Visible;
            await _monitorViewModel.GetCategorie();
            prCategorie.IsActive = false;
            prCategorie.Visibility = Visibility.Collapsed;
            btCategorie.Visibility = Visibility.Visible;
        }

        private void ListView_Click(object sender, RoutedEventArgs e)
        {
            ViewModelCategorie ViewModelcategorie = (ViewModelCategorie)((Button)sender).DataContext;
            Frame.Navigate(typeof(SujetPage), ViewModelcategorie);
        }
    }
}
