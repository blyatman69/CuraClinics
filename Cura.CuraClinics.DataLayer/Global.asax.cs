using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Cura.CuraClinics.ServiceModel;
using Funq;

namespace Cura.CuraClinics.DataLayer
{
    public class Global : System.Web.HttpApplication
    {
        public class ClinicAppHost : AppHostBase
        {
            public ClinicAppHost() : base("Clinic", typeof(Clinic).Assembly)
            { }
                public override void Configure(Container container)
            {
               //
            }
        }
   
 

        protected void Application_Start(object sender, EventArgs e)
        {
            new ClinicAppHost().Init();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}