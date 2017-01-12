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
        /// <summary>
        /// Test avant démmarage de mon projet
        /// </summary>
        [TestMethod]
        public void TestCreationCategorie()
        {
            string expectedString = "Categorie de test";
            Categorie categorie = new Categorie(2, "Categorie de test");

            Assert.AreEqual(categorie.Libelle, expectedString);
        }
        /// <summary>
        /// Test après la création de la classe CategorieDAO
        /// </summary>
        [TestMethod]
        public void TestGetCategorieByID()
        {
            string expectedString = "Développement";
            Categorie categorie = Outils.GetCategorieByID(7);

            Assert.AreEqual(categorie.Libelle, expectedString);
        }
    }
}
