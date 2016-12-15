using CommunityDevelopers2ISAMetiers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsumeWebServiceRest
{
    public class ConsumeWSR
    {
        private const string ADR_GET_CATEGORIE = "http://user11.2isa.org/ServiceREST.svc/Categorie";
        private const string ADR_GET_SUJET = "http://user11.2isa.org/ServiceREST.svc/Sujet/";
        private const string ADR_GET_REPONSE = "http://user11.2isa.org/ServiceREST.svc/Reponse/";
        private List<Categorie> _categories = new List<Categorie>();
        private List<Sujet> _sujets = new List<Sujet>();
        private List<Reponse> _reponses = new List<Reponse>();
        

        public List<Categorie> Categories
        {
            get
            {
                return _categories;
            }
        }

        public async Task<List<Categorie>> getCategorie()
        {

            // Création de l'instance HttpClient avec Timeout infini car c'est le CancellationToken qui gère l'arrêt ou le TimeOut de la tâche
            // ATTENTION, en Windows phone on a quand même un timeout au bout de 60s
            using (HttpClient client = new HttpClient() { Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite) })
            {
                // Permet de supprimer la mise en cache. En WindowsPhone, deux requêtes successives identiques retournent le résultat de la première 
                // qui a été mis en cache
                client.DefaultRequestHeaders.IfModifiedSince = DateTimeOffset.Now;

                // Appel du service Rest (en asynchrone)
                using (HttpResponseMessage wcfResponse = await client.GetAsync(ADR_GET_CATEGORIE, CancellationToken.None))
                {
                    if (wcfResponse.IsSuccessStatusCode)
                    {
                        // Désérialisation de la réponse du service
                        return DeserializeHttpContent(wcfResponse.Content);
                    }

                }
                return null;
            }
        }

        private List<Categorie> DeserializeHttpContent(HttpContent content)
        {
            using (Stream s = content.ReadAsStreamAsync().Result)
            {
                if (s.Length > 0)
                {
                    return _categories = (List<Categorie>)new DataContractSerializer(typeof(List<Categorie>)).ReadObject(s);
                }
                return null;
            }
        }

        public List<Sujet> sujets
        {
            get { return _sujets; }
        }

        public async Task<List<Sujet>> getSujetByCategorieID(int idcategorie)
        {
            using (HttpClient client = new HttpClient() { Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite) })
            {
                // Permet de supprimer la mise en cache. En WindowsPhone, deux requêtes successives identiques retournent le résultat de la première 
                // qui a été mis en cache
                client.DefaultRequestHeaders.IfModifiedSince = DateTimeOffset.Now;

                // Appel du service Rest (en asynchrone)
                using (HttpResponseMessage wcfResponse = await client.GetAsync(ADR_GET_SUJET+idcategorie.ToString(), CancellationToken.None))
                {
                    if (wcfResponse.IsSuccessStatusCode)
                    {
                        // Désérialisation de la réponse du service
                        return DeserializeHttpContentSujet(wcfResponse.Content);
                    }

                }
                return null;
            }
        }

        private List<Sujet> DeserializeHttpContentSujet(HttpContent content)
        {
            using (Stream s = content.ReadAsStreamAsync().Result)
            {
                if (s.Length > 0)
                {
                    return _sujets = (List<Sujet>)new DataContractSerializer(typeof(List<Sujet>)).ReadObject(s);
                }
                return null;
            }
        }


        public List<Reponse> reponses
        {
            get { return _reponses; }
        }
        public async Task<List<Reponse>> getReponse()
        {
            using (HttpClient client = new HttpClient() { Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite) })
            {
                // Permet de supprimer la mise en cache. En WindowsPhone, deux requêtes successives identiques retournent le résultat de la première 
                // qui a été mis en cache
                client.DefaultRequestHeaders.IfModifiedSince = DateTimeOffset.Now;

                // Appel du service Rest (en asynchrone)
                using (HttpResponseMessage wcfResponse = await client.GetAsync(ADR_GET_SUJET, CancellationToken.None))
                {
                    if (wcfResponse.IsSuccessStatusCode)
                    {
                        // Désérialisation de la réponse du service
                        return DeserializeHttpContentReponse(wcfResponse.Content);
                    }

                }
                return null;
            }
        }

        private List<Reponse> DeserializeHttpContentReponse(HttpContent content)
        {
            using (Stream s = content.ReadAsStreamAsync().Result)
            {
                if (s.Length > 0)
                {
                    return _reponses = (List<Reponse>)new DataContractSerializer(typeof(List<Reponse>)).ReadObject(s);
                }
                return null;
            }
        }
    }
}
