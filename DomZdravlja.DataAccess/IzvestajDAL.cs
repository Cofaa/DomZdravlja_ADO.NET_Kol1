using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DomZdravlja.Shared;
using System.Data.SqlClient;
using DomZdravlha.Shared;
using System.Data;

namespace DomZdravlja.DataAccess
{
    public class IzvestajDAL
    {
        private string _connString = ConfigurationManager.ConnectionStrings["DomZdravljaConnString"].ConnectionString;
    
        public List<IzvestajDTO> GetIzvestajBySluzba(int sluzbaID)
        {
            var result = new List<IzvestajDTO>();

            using (SqlConnection conn = new SqlConnection(_connString))
            {
                string sql = @"SELECT IzvestajID, SluzbaID, NazivIzvestaja, BrojPacijenata, DatumKreiranja
                               FROM tblIzvestaj
                               WHERE SluzbaID = @SluzbaID
                               ORDER BY IzvestajID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@SluzbaID", sluzbaID);

                conn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var i = new IzvestajDTO()
                        {
                            IzvestajID = dr.GetInt32(0),
                            SluzbaID = dr.GetInt32(1),
                            NazivIzvestaja = dr.GetString(2),
                            BrojPacijenata = dr.GetInt32(3),
                            DatumKreiranja = dr.GetDateTime(4)
                        };
                        result.Add(i);
                    }
                }
            }
            return result;
        }

        public void InsertIzvestaj(IzvestajDTO izvestaj)
        {
            using (SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    SqlCommand cmd = new SqlCommand("sp_DodajIzvestaj", conn, tran);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@SluzbaID", izvestaj.SluzbaID);
                    cmd.Parameters.AddWithValue("@NazivIzvestaja", izvestaj.NazivIzvestaja);
                    cmd.Parameters.AddWithValue("@BrojPacijenata", izvestaj.BrojPacijenata);
                    cmd.Parameters.AddWithValue("@DatumKreiranja", izvestaj.DatumKreiranja);

                    cmd.ExecuteScalar();

                    tran.Commit();
                }
                catch (Exception)
                { 
                    tran.Rollback();
                    throw;
                }
            }
        }

        public void UpdateIzvestaj(IzvestajDTO izvestaj) 
        {
            using (SqlConnection con = new SqlConnection(_connString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE tblIzvestaj
                                        SET NazivIzvestaja = @NazivIzvestaja,
                                            BrojPacijenata = @BrojPacijenata,
                                            DatumKreiranja = @DatumKreiranja
                                        WHERE IzvestajID = @IzvestajID";

                    cmd.Parameters.AddWithValue("@NazivIzvestaja", izvestaj.NazivIzvestaja);
                    cmd.Parameters.AddWithValue("@BrojPacijenata", izvestaj.BrojPacijenata);
                    cmd.Parameters.AddWithValue("DatumKreiranja", izvestaj.DatumKreiranja);
                    cmd.Parameters.AddWithValue("@IzvestajID", izvestaj.IzvestajID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteIzvestaj(int IzvestajID)
        {
            using(SqlConnection conn = new SqlConnection(_connString))
            {
                conn.Open();
                string sql = "DELETE FROM tblIzvestaj WHERE IzvestajID = @IzvestajID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IzvestajID", IzvestajID);
                cmd.ExecuteNonQuery();
            }
        }

        public List<IzvestajDTO> GetIzvestajiBySluzba(int sluzbaID)
        {
            throw new NotImplementedException();
        }
    }
}
