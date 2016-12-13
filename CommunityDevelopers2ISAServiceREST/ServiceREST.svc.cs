using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CommunityDevelopers2ISAMetiers;
using CommunityDevelopers2ISADLL;

namespace CommunityDevelopers2ISAServiceREST
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceREST : ICommunityDevelopers2ISAREST
    {
        public List<Categorie> GetAllCategories()
        {
            return Outils.GetAllCategories();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idsujet"></param>
        /// <returns></returns>
        public List<Reponse> GetAllReponseBySujet(string idsujet)
        {
            int res; 

            if (int.TryParse(idsujet , out res))
            {
                return Outils.GetAllReponseBySujet(res);
            }
            else
            {
                return null; 
            }

        }

        public List<Sujet> GetSujetsByCategorieID(string idcategorie)
        {
            int res;

            if (int.TryParse(idcategorie, out res))
            {
                return Outils.GetSujetsByCategorieID(res);
            }
            else
            {
                return null; 
            }
        }
    }


}
