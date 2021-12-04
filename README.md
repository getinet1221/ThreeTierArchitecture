# ThreeTierArchitecture
# Three Tier Architecture Using ASP.net C#
## Description
- This arcitecture divides the whole app into three **logical** layers. These layers are
	- Data Access Layer
		- DAL (In this project, Data Access Layer is designated by **DAL**)
	- Business Logic Layer
		- BLL (In this project, Business Logic Layer is designated by **BLL**)
	- Presentation Layer
		- Food (In this project, Presentation Layer is designated by **Food**)
<hr />

As to me and my collegous point of view, it is better to start coding from the one we communicate with the database i.e. Data Access Layer and then go to Business Logic Layer

```C#

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

```
The above source code demonestrates Data Access Layer. Core Points that you have to focus
- Establishing connection with database on line 11. 
	- To do it easily, go to your visual studio IDE, click Tools->Connect to Database->Selecr your server name->select database name and finally go to Advanced button to copy the path easily.
	- Write two methods to store data and retrive as you see.
**Here is a Business Logic Layer**
- This layer performs Validation, Calculation, enables communication with the remaining two layers.
```
using System;
using DAL;
namespace BLL
{
    public class Class1
    {

    }
    public class BusinessLogicLayer
    {
        public void InsertFood(string name, string type)
        {
            DataAccessLayer bl = new DataAccessLayer();
            bl.InsertFoodItem(name, type);
        }
        public object SelectFood()
        {
            DataAccessLayer bl = new DataAccessLayer();
            return bl.SelectFoodItem();
        }
    }
}
```
**Here is the last layer demonestration**
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace Food
{
    public partial class AddFood : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            // manage your code right here
            BusinessLogicLayer bll = new BusinessLogicLayer();
            bll.InsertFood(txtName.Text, txtType.Text);
            GridView1.DataSource = bll.SelectFood();
            GridView1.DataBind();

        }
    }
}
```
**Database Table source code**
**Name of database => FoodOrdering**
```
CREATE TABLE Food(
id int IDENTITY(1,1) PRIMARY KEY not null,
Name varchar(250) not null,
Type varchar(250) not null
);
```
### Clone it via the following address 
**git clone https://github.com/getinet1221/ThreeTierArchitecture.git**

### Author
- [Getinet Amare Mekonne](https://www.github.com/getinet1221)
- [Telegram](https://t.me/getinet2112)
