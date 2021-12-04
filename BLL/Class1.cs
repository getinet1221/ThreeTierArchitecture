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
