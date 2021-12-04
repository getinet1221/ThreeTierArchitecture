# ThreeTierArchitecture
# Three Tier Architecture Using ASP.net C#
## Description
- This arctitecture divide the app into three **logical** layers. These layers are
	- Data Access Layer
		- DAL (In this project, Data Access Layer is designated by **DAL**)
	- Business Logic Layer
		- BLL (In this project, Business Logic Layer is designated by **BLL**)
	- Presentation Layer
		- Food (In this project, Presentation Layer is designated by **Food**)
<hr />

As to me it is better to start coding from Data Access Layer
'''
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
'''
### Author
- [Getinet Amare Mekonne](https://www.github.com/getinet1221)
- [Telegram](https://t.me/getinet2112)
