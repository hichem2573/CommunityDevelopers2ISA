using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommunityDevelopers2ISAMetiers;
using System.Collections.Generic;
using CommunityDevelopers2ISABLL;

namespace CommunityDevelopers2ISATestUnitaire
{
    /// <summary>
    /// Description résumée pour UnitTestCategorie
    /// </summary>
    [TestClass]
    public class UnitTestSujet
    {
        /// <summary>
        /// Test méthode GetSujetByCategorieId
        /// </summary>
        [TestMethod]
        public void TestGetSujetsByCategorieID()
        {
            // La liste de sujets attendus, vide pour le moment
            List<Sujet> sujetsAtt = new List<Sujet>();

            // la requête doit renvoyé 1 sujet dont l'id 16 est et le titre "Sortie resto"
            Sujet sujAtt = new Sujet();
            sujAtt.Id = 5;

            Sujet sujAtt1 = new Sujet();
            sujAtt1.Id = 1;

            // on ajoute le sujet attendu dans la liste des sujets attendu
            sujetsAtt.Add(sujAtt);
            sujetsAtt.Add(sujAtt1);

            // On instancie une liste de sujet qui va stocker les sujets retournés par la méthode de la classe Outils GetSujetsByCategorieID
            List<Sujet> sujetsRet = new List<Sujet>();

            // Appelle de la méthode en passant en paramétre l'id de la catégorie
            sujetsRet = Outils.GetSujetsByCategorieID(7);
            CollectionAssert.AreEqual(sujetsAtt, sujetsRet);
        }
    }
}
