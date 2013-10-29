using System;
using System.Data.SqlClient;

namespace connectToSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection myConn = new SqlConnection("user id=Krasi;" + "password = ;server = localhost;" + "Trusted_Connection = yes;" + "database = DevAlpha;" + "connection timeout=30");

            try
            {
                myConn.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error on opening the connection {0}", e.ToString());
                Console.ReadKey();
            }
            try
            {
                SqlDataReader myReader = null;
                SqlCommand myCommand = new SqlCommand("SELECT * FROM Country", myConn);
                myReader = myCommand.ExecuteReader();
                Console.WriteLine("Country ID, Country Name, Two Letter Code, Three Letter Code");
                while(myReader.Read())
                {
                    Console.WriteLine("{0} {1} {2} {3}", myReader["CountryID"].ToString(), myReader["CountryName"].ToString(), myReader["TwoLetterCode"].ToString(), myReader["ThreeLetterCode"].ToString());
                } 
                Console.ReadKey();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error reading from database {0}", exc.ToString());
                Console.ReadKey();
            }
            try
            {
                myConn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error on closing the connection {0}", ex.ToString());
                Console.ReadKey();
            }
        }
    }
}
