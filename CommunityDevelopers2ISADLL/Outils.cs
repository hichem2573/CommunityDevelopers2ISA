using CommunityDevelopers2ISADAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityDevelopers2ISADLL
{
    public class Outils
    {
        #region "Categories"
        public static List<Categorie> GetAllCategories()
        {
            DataTable dt = CategorieDAO.GetAllCategories();
            if (dt.Rows.Count >= 1)
            {
                List<Categorie> _Categories = new List<Categorie>();
                foreach (DataRow row in dt.Rows)
                {
                    Categorie categorie = new Categorie(int.Parse(row["ID_CATEGORIE"].ToString()), row["NOM_CATEGORIE"].ToString());
                    categorie.Id = int.Parse(row["ID_CATEGORIE"].ToString());
                    _Categories.Add(categorie);
                }
                return _Categories;
            }
            return null;
        }

        public static Categorie GetCategorieByID(int idCategorie)
        {
            DataTable dt = CategorieDAO.GetCategorieByID(idCategorie);
            if (dt.Rows.Count == 1)
            {

                DataRow row = dt.Rows[0]; //On obtient la ligne à l'index specifier ici 0 c'est la 1er ligne
                Categorie categorie = new Categorie(idCategorie, row["NOM_CATEGORIE"].ToString());
                return categorie;
            }
            return null;
        }

        #endregion

        #region "Utilisateurs"
        #endregion

        #region "Sujets"
        #endregion

        #region "Réponses"
        #endregion

    }
}
