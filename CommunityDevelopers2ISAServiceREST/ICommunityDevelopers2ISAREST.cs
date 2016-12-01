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

        [OperationContract]
        [WebGet(UriTemplate = "CategorieDAL")]
        List<CategorieDAL> GetAllCategories();
        

        [OperationContract]
        [WebGet(UriTemplate = "SujetDAL/{idcategorie}")]
        List<SujetDAL> GetSujetsByCategorieID(int idcategorie);

        [OperationContract]
        [WebGet(UriTemplate = "ReponseDAL/{idsujet}")]

        List<ReponseDAL> GetRecentAnswersBySujet(int idsujet);
        // TODO: ajoutez vos opérations de service ici
    }  
}

