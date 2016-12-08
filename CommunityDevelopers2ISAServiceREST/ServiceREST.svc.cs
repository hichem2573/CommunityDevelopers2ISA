using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CommunityDevelopers2ISADAL;

namespace CommunityDevelopers2ISAServiceREST
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceREST : ICommunityDevelopers2ISADAL
    {

        public List<Reponse> GetRecentAnswersBySujet(int idsujet)
        {
            throw new NotImplementedException();
        }


        List<Categorie> ICommunityDevelopers2ISADAL.GetAllCategories()
        {
            throw new NotImplementedException();
        }

        List<Sujet> ICommunityDevelopers2ISADAL.GetSujetsByCategorieID(int idcategorie)
        {
            throw new NotImplementedException();
        }
    }
}
