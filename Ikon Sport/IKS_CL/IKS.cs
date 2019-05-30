using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace IKS_CL
{
    public class IKS
    {      
        public string connStr;

        

        public IKS(string DataSource, string databaseName)
        {
            connStr = "Data Source="+DataSource+";Initial Catalog="+databaseName+";Integrated Security=True";
        }



        //opretter en bruger i den database der passer til den givende Connection string.
        //Bruger parametre tilsvarende til text fra en string (i dette tilfælde en string fra en textbox)
        public void createUser(string dbUsername, string dbFirstname, string dbLastname, string dbMail, string dbPwd)
        {
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();

                //tilføjer overstående strings til en parametre der svare til columns fra databasen
                SqlCommand cmd = new SqlCommand("spStaffLogin_CreateUser", sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Username", dbUsername));
                cmd.Parameters.Add(new SqlParameter("@Firstname", dbFirstname));
                cmd.Parameters.Add(new SqlParameter("@Lastname", dbLastname));
                cmd.Parameters.Add(new SqlParameter("@Mail", dbMail));
                cmd.Parameters.Add(new SqlParameter("@Pwd", dbPwd));

                SqlDataReader reader = cmd.ExecuteReader();

            }
        }

        public void opretAdresse(int dbPostnummer, string dbBy, string dbVej, string dbHusnummer)
        {
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();

                //tilføjer overstående strings/int til en parametre der svare til columns fra databasen
                SqlCommand cmd = new SqlCommand("spMedlemskort", sqlConn);
                sqlConn.InfoMessage += sqlConn_InfoMessage;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Postnummer", dbPostnummer));
                cmd.Parameters.Add(new SqlParameter("@City", dbBy));
                cmd.Parameters.Add(new SqlParameter("@Vej", dbVej));
                cmd.Parameters.Add(new SqlParameter("@Husnummer", dbHusnummer));

                SqlDataReader reader = cmd.ExecuteReader();

            }
        }

        static void sqlConn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            var outputFromStoredProcedure = e.Message;
        }

        public void opretMedlemskort(string dbNavn, string dbEfternavn, string dbMail, string dbTelefon)
        {
            using (SqlConnection sqlConn = new SqlConnection(connStr))
            {
                sqlConn.Open();

                //tilføjer overstående strings/int til en parametre der svare til columns fra databasen
                SqlCommand cmd = new SqlCommand("spMedlemskort", sqlConn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Navn", dbNavn));
                cmd.Parameters.Add(new SqlParameter("@Efternavn", dbEfternavn));
                cmd.Parameters.Add(new SqlParameter("@Mail", dbMail));
                cmd.Parameters.Add(new SqlParameter("@telefon", dbTelefon));

                SqlDataReader reader = cmd.ExecuteReader();

            }
        }
    }
}
