using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CommunityDevelopers2ISAMetiers;
using CommunityDevelopers2ISABLL;

namespace CommunityDevelopers2ISAServiceREST
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ServiceREST" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou ServiceREST.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class ServiceREST : ICommunityDevelopers2ISAREST

    {
        /// <summary>
        /// Méthode permettant de récupérer toutes les catégories du forum
        /// </summary>
        /// <returns> liste de catégorie</returns>
        public List<Categorie> GetAllCategories()
        {
            return Outils.GetAllCategories();
        }

        /// <summary>
        /// Méthode de recupération de la liste des réponses d'un sujet
        /// </summary>
        /// <param name="idsujet">L'identifiant de sujet</param>
        /// <returns>La liste de toutes les réponses pour un sujet donné</returns>
        public List<Reponse> GetAllReponseBySujet(string idsujet)
        {
            int res;

            if (int.TryParse(idsujet, out res))
            {
                 return Outils.GetAllReponseBySujet(res);
            }
            else
            {
                return null;
            }

        }

        /// <summary>
        /// Méthode de recupération de la liste de tous les sujets d'une catégorie 
        /// </summary>
        /// <param name="idcategorie">L'identifiant de la catégorie</param>
        /// <returns>La liste des tous les sujets d'une catégorie</returns>
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
