using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cura.CuraClinics.ServiceModel;
using ServiceStack.OrmLite;
using ServiceStack;

namespace Cura.CuraClinics.DataLayer
{
    public class CSData
    {
        System.Data.IDbConnection _dbConnection;
        public CSData(System.Data.IDbConnection dbconnection)
        {
            _dbConnection = dbconnection;
        }
        public int addCS(CS c)
        {
            return (int)_dbConnection.Insert<CS>(c, selectIdentity: true);
        }
        public List<CS> GetCSList()
        {
            return _dbConnection.Select<CS>();
        }
        public CS getCSById(int id)
        {
            return _dbConnection.SingleById<CS>(id);
        }
        public CS UpdateCS(CS c)
        {
            _dbConnection.Update<CS>(c);
            return c;
        }
        public int DeleteCSById(int id)
        {
            return _dbConnection.Delete(getCSById(id));
        }
    }
}