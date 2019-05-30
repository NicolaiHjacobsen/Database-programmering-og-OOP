using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using IKS_CL;


namespace Ikon_Sport
{
    class Connection
    {
        public static bool LoginAccepteret = false;


        //Kaldes i LoginForm når en bruger skal logge ind
        public static string loginCheck(string IKSBruger, string IKSKode)
        {

            IKS connStr = new IKS("(local)", "Ikon Sport");
            string sqlConnString = connStr.connStr;
            

            string ReturnValue = "Mangler information i text felt";

            using (SqlConnection sqlConn = new SqlConnection(sqlConnString))
            {
                if(IKSBruger != "" && IKSKode != "")
                {
                    try
                    {
                        sqlConn.Open();

                        if (sqlConn.State == System.Data.ConnectionState.Open)
                        {
                            ReturnValue = "Forbindelse";

                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = sqlConn;
                            cmd.CommandText = "SELECT * FROM staffLogin WHERE username = @brugernavn AND pwd = @pwd";
                            cmd.Parameters.AddWithValue("@brugernavn", IKSBruger);
                            cmd.Parameters.AddWithValue("@pwd", IKSKode);

                            SqlDataReader reader = cmd.ExecuteReader();

                            //Tjekker om der er match mellem den text der er skrevet i text feltet og bruger data i DB
                            if (reader.HasRows)
                            {
                                ReturnValue = "Bruger fundet!";
                                LoginAccepteret = true;
                            }
                            else
                            {
                                ReturnValue = "Ingen bruger fundet!";
                            }
                        }
                    }
                    catch (Exception)
                    {
                        LoginAccepteret = false;
                        throw;
                    }
                }
            }

                return ReturnValue;
        }

        //Bruges til display af produkt information på produkt listen.
        public void produkt_Display(out DataTable sqlDT)
        {
            IKS connStr = new IKS("(local)", "Ikon Sport");
            string sqlConnString = connStr.connStr;

            using (SqlConnection sqlConn = new SqlConnection(sqlConnString))
            {
                sqlConn.Open();

                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM Produkt_Information", sqlConn);
                sqlDT = new DataTable();
                sqlDA.Fill(sqlDT);
                
            }
        }

        public void medlemskort_Display(out DataTable sqlMK)
        {
            IKS connStr = new IKS("(local)", "Ikon Sport");
            string sqlConnString = connStr.connStr;

            using (SqlConnection sqlConn = new SqlConnection(sqlConnString))
            {
                sqlConn.Open();

                SqlDataAdapter sqlDA = new SqlDataAdapter("SELECT * FROM infoMedlemskort", sqlConn);
                sqlMK = new DataTable();
                sqlDA.Fill(sqlMK);

            }

        }

        //Færdig gøres efter DB sp er oprettet.
        public void OpretMedlem(string dbNavn, string dbEfternavn)
        {

        }


    }
}
