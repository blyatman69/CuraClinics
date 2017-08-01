using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.OrmLite;
using ServiceStack;
using Cura.CuraClinics.ServiceModel;

namespace Cura.CuraClinics
{
    public class ClinicData
    {
        System.Data.IDbConnection _dbConnection;
        public ClinicData(System.Data.IDbConnection dbconnection)
        {
            _dbConnection = dbconnection;
        }
        public int addClinic(Clinic c)
        {
            return (int)_dbConnection.Insert<Clinic>(c, selectIdentity: true);
        }
        public List<Clinic> getClinicList()
        {
            return _dbConnection.Select<Clinic>();
        }
        public Clinic getClinicById(int id)
        {
            return _dbConnection.SingleById<Clinic>(id);
        }
        public Clinic UpdateClinic(Clinic c)
        {
            _dbConnection.Update<Clinic>(c);
            return c;
        }
        public int DeleteClinicById(int id)
        {
            return _dbConnection.Delete(id);
        }
    }
}