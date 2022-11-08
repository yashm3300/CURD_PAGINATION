using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using PaginationAspCore.Model;
using pagination.model;

namespace pagination.Database_Access_Layer
{
    public class db
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-3K9D57R;Initial Catalog=DB;Integrated Security=True");
        public Categorymodel GetCategory(int currentpage)
        {
            int maxRows = 10;
            SqlCommand com = new SqlCommand("Sp_Category_Details_Paging", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Pageindex", currentpage);
            com.Parameters.AddWithValue("@Pagesize", maxRows);

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Categorymodel categorymodel = new Categorymodel();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Categorymodel category = new Categorymodel();
                {
                    CategoryID = Convert.ToInt32(dr["CategoryID]"),
                    CategoryName = dr["CategoryName"].ToString(),
                    Department = dr["Department"].ToString(),
                });

            }
       categorymodel.PageCount = Convert.ToInt32(ds.Tables[1].Rows[0][0]) / maxRows;
            categorymodel.CurrentIndex = currentpage;
            return categorymodel;
        }
    }
}