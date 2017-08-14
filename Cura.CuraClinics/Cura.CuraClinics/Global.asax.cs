using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Cura.CuraClinics.ServiceInterface;
using Funq;
using ServiceStack;
using ServiceStack.Razor;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.MySql;
using Cura.CuraClinics.ServiceModel;


namespace Cura.CuraClinics
{
    public class Global : System.Web.HttpApplication
    {
        public class ClinicAppHost : AppHostBase
        {
            public ClinicAppHost() : base("Clinic", typeof(ClinicService).Assembly)
            {
            }

            public override void Configure(Container container)
            {
                //config
                container.Register<IDbConnectionFactory>(new OrmLiteConnectionFactory(Properties.Settings.Default.LocalSqlConnectionString, MySqlDialectProvider.Instance));
                using (var db = container.Resolve<IDbConnectionFactory>().Open())
                {
                    db.CreateTable<Clinic>(overwrite: false);
                    db.CreateTable<Doctor>(overwrite: false);
                    db.CreateTable<CS>(overwrite: false);
                    db.CreateTable<Report>(overwrite: false);



                }
             this.Plugins.Add(new RazorFormat());

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