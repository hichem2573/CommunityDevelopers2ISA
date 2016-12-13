using CommunityDevelopers2ISAMetiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CommunityDevelopers2ISAServiceREST
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICommunityDevelopers2ISAREST
    {
        //TODO
        [OperationContract]
        [WebGet(UriTemplate = "Categorie")]
        List<Categorie> GetAllCategories();
        

        [OperationContract]
        [WebGet(UriTemplate = "Sujet/{idcategorie}")]
        List<Sujet> GetSujetsByCategorieID(string idcategorie);

        [OperationContract]
        [WebGet(UriTemplate = "Reponse/{idsujet}")]

        List<Reponse> GetAllReponseBySujet(string idsujet);
        
    }  
}

