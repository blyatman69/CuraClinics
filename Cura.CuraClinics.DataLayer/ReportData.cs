using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cura.CuraClinics.ServiceModel;
using ServiceStack.OrmLite;
using ServiceStack;

namespace Cura.CuraClinics.DataLayer
{
    public class ReportData
    {
        System.Data.IDbConnection _dbConnection;
        public ReportData(System.Data.IDbConnection dbconnection)
        {
            _dbConnection = dbconnection;
        }
        public int addReport(Report c)
        {
            return (int)_dbConnection.Insert<Report>(c, selectIdentity: true);
        }
        public List<Report> GetReportList()
        {
            return _dbConnection.Select<Report>();
        }
        public Report getReportById(int id)
        {
            return _dbConnection.SingleById<Report>(id);
        }
        public Report UpdateReport(Report c)
        {
            _dbConnection.Update<Report>(c);
            return c;
        }
        public int DeleteReportById(int id)
        {
            return _dbConnection.Delete(getReportById(id));
        }
    }
}