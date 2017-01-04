using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CommunityDevelopers2ISAMetiers;
using CommunityDevelopers2ISABLL;

namespace CommunityDevelopers2ISATestUnitaire
{
    /// <summary>
    /// Description résumée pour UnitTestCategorie
    /// </summary>
    [TestClass]
    public class UnitTestCategorie
    {
        [TestMethod]
        public void TestCreationCategorie()
        {
            string expectedString = "Categorie de test";
            Categorie categorie = new Categorie(2, "Categorie de test");

            Assert.AreEqual(categorie.Libelle, expectedString);
        }
        [TestMethod]
        public void TestGetCategorieByID()
        {
            string expectedString = "Adresse Utiles";
            Categorie categorie = Outils.GetCategorieByID(2);

            Assert.AreEqual(categorie.Libelle, expectedString);
        }
    }
}
