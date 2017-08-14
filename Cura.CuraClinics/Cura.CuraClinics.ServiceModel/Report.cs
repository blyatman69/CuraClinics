using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cura.CuraClinics.ServiceModel
{
    public class Report
    {
        [AutoIncrement]
        public int Id { get; set; }
        public String Message { get; set; }
    }
}
