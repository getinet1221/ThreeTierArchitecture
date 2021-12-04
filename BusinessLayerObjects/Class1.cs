using System;

namespace BusinessLayerObjects
{
    
    public class Class1
    {
    }
    public class BusinessObjects
    {
        private string name;
        private string type;
        public void SetName(string name)
        {
            this.name = name;
        }
        public String GetName()
        {
            return name;
        }
        public void SetType(string type)
        {
            this.type = type;
        }
        public string GetType1()
        {
            return type;
        }
    }
}
