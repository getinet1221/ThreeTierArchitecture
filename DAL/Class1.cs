using System;
using System.Data;
using System.Data.SqlClient;
using BusinessLayerObjects;
namespace DAL
{
    public class Class1
    {
    }
    public class DataAccessLayer
    {
        private static string connectionString = null;
        private static SqlConnection conn = null;
        private static SqlCommand sqlCommand = null;
        private SqlDataAdapter adapter = null;
        private static string query = null;
        private SqlDataReader dataReader = null;
        private static bool statusBool = false;
        
        public static SqlConnection EstablishConnection()
        {
            try
            {
                connectionString = "Data Source=DESKTOP-S2R97R0;Initial Catalog=FoodOrdering;Integrated Security=True";
                conn = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in connecting with database "+ex.GetBaseException());
            }
            return conn;
        }        
         public void InsertFoodItem(string name, string type)
        {
            adapter = new SqlDataAdapter("INSERT INTO Food values('" + name + "','" + type + "')", EstablishConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
        }
        public object SelectFoodItem()
        {
            adapter = new SqlDataAdapter("SELECT * FROM Food", EstablishConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public bool CheckFoodItemUniqueness(string name)
        {
            query = "SELECT * FROM Food WHERE Name = '" + name +"'";
            sqlCommand = new SqlCommand(query, EstablishConnection());
            dataReader = sqlCommand.ExecuteReader();
            if (!dataReader.Read())
            {
                statusBool = true;// it means, name of food is unique 
            }
            else
            {
                statusBool = false;// there is a food information with this name in Food table
            }
            return statusBool;
        }
    }
}
