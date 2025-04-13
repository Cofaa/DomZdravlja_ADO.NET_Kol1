using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DomZdravlja.Shared;
using System.Data.SqlClient;

namespace DomZdravlja.DataAccess
{
    public class SluzbaDAL
    {
        private string _connString = ConfigurationManager.ConnectionStrings["DomZdravljaConnString"].ConnectionString;


        public List<SluzbaDTO> GetAllSluzba()
        {
            var result = new List<SluzbaDTO>();

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string sql = "SELECT SluzbaID, NazivSluzbe, OpisSluzbe, DatumOsnivanja From tblSluzba ORDER BY SluzbaID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var s = new SluzbaDTO
                        {
                            SluzbaID = dr.GetInt32(0),
                            NazivSluzbe = dr.GetString(1),
                            OpisSluzbe = dr.GetString(2),
                            DatumOsnivanja = dr.GetDateTime(3)
                        };
                        result.Add(s);
                    }
                }
            }
            return result;
        }
    }
}
