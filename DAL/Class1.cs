using System;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class Class1
    {
    }
    public class DataAccessLayer
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-S2R97R0;Initial Catalog=FoodOrdering;Integrated Security=True");
         public void InsertFoodItem(String Name, String Type)
        {
            SqlDataAdapter ada = new SqlDataAdapter("INSERT INTO Food values('" + Name + "','" + Type + "')", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
        }
        public object SelectFoodItem()
        {
            SqlDataAdapter ada = new SqlDataAdapter("SELECT * FROM Food", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            return dt;
        }
    }
}
