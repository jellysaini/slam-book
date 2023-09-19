using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using BuinessLayer;
namespace baseclasslib
{
    public class baseclass : System.Web.UI.Page 
    {
        private string EMail;
        private string Password;
        public basePropertyUser baseProperty
        {
            get { return (basePropertyUser)Session["PropertyUser"]; }
            set { Session["PropertyUser"] = value; }
        }
        public slamBKBasePropertyClass baseSlamProperty
        {
            get { return (slamBKBasePropertyClass)Session["PropertySlambk"]; }
            set { Session["PropertySlambk"] = value; }
        }
        public baseclass()
        { }
        public baseclass(string EM,string Pass)
        {
            EMail=EM;
            Password=Pass;
        }   
        public void getData()
        {
            basePropertyUser ob = new basePropertyUser(EMail, Password);
            ob.getValue();
            baseProperty = ob;            
        }
        public void getSlamData(Int32 userId)
        {
            slamBKBasePropertyClass ob = new slamBKBasePropertyClass();
            ob.getSlamData(userId);
            baseSlamProperty = ob;
        }
    }
}
