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