using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityDevelopers2ISADLL;

namespace CommunityDevelopers2ISADAO
{
    /// <summary>
    /// La classe CategorieDAO, permet de récupérer les catégories
    /// qui se trouvent dans la base de données
    /// </summary>
    public static class CategorieDAO
    {
        #region "Property et attributs"
        private static SqlConnection con = ConnexionSql.GetConnexion();
        #endregion

        #region "Constructeurs"
        #endregion

        #region "Méthodes"

        public static List<Categorie> GetAllCategories()
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllCategories";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Categorie");
            da.Fill(dt);
            //con.Close();

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
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetCategorieByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdCategorie";
            parm.Value = idCategorie;
            cmd.Parameters.Add(parm);
            Categorie categorie;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Categories");
            da.Fill(dt);
            //con.Close();

            if (dt.Rows.Count == 1)
            {

                DataRow row = dt.Rows[0]; //On obtient la ligne à l'index specifier ici 0 c'est la 1er ligne
                categorie = new Categorie(idCategorie, row["NOM_CATEGORIE"].ToString());
                return categorie;
            }
            return null;

        }
        #endregion

        #region "Méthodes héritées et substituées"
        #endregion

        #region "Méthodes à implementer pour les interfaces"
        #endregion
    }
}
