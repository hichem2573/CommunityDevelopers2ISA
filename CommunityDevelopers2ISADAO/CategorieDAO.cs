using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

        public static DataTable GetAllCategories()
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllCategories";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Categorie");
            da.Fill(dt);
            //con.Close();

            return dt;
        }

        public static DataTable GetCategorieByID(int idCategorie)
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetCategorieByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdCategorie";
            parm.Value = idCategorie;
            cmd.Parameters.Add(parm);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Categories");
            da.Fill(dt);
            //con.Close();
            return dt;
           

        }
        #endregion

        #region "Méthodes héritées et substituées"
        #endregion

        #region "Méthodes à implementer pour les interfaces"
        #endregion
    }
}
