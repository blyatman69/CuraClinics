using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cura.CuraClinics.ServiceInterface
{
    [Route("/Report", Verbs = "GET")]
    public class GetReportRequest { }
    [Route("/Report", Verbs = "POST")]
    [Route("/Report/{ReportId}", Verbs = "PUT")]

    public class ReportRequest
    {
        public int Id { get; set; }
        public String Message { get; set; }

    }
    [Route("/Report/{ReportId}", Verbs = "GET, DELETE")]
    public class ReportIdRequest
    {
        public int ReportId { get; set; }
    }
}
