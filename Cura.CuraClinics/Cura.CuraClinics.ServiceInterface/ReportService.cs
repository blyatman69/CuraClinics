using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using Cura.CuraClinics.DataLayer;
using Cura.CuraClinics.ServiceModel;
using Cura.CuraClinics.Views;
using Cura.CuraClinics.ServiceInterface;

namespace Cura.CuraClinics.ServiceInterface
{
    public class ReportService : Service
    {
        public List<Report> Get(GetReportRequest request)
        {
            ReportData cd = new ReportData(Db);
            return cd.GetReportList();
        }
        public Report Get(ReportIdRequest request)
        {
            ReportData cd = new ReportData(Db);
            return cd.getReportById(request.ReportId);
        }
        public int Post(ReportRequest request)
        {
            var c = new Report()
            {
             
                Message = request.Message

            };
            ReportData cd = new ReportData(Db);
            return cd.addReport(c);
        }
        public Report Put(ReportRequest request)
        {
            var c = new Report()
            {
                Id = request.Id,
                Message = request.Message,

            };
            ReportData cd = new ReportData(Db);
            return cd.UpdateReport(c);
        }
        public void Delete(ReportIdRequest request)
        {
            ReportData cd = new ReportData(Db);
            cd.DeleteReportById(request.ReportId);
        }

    }
}