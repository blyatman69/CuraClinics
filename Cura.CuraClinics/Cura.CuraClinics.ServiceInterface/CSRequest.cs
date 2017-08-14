using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cura.CuraClinics.ServiceInterface
{
    [Route("/CS", Verbs = "GET")]
    public class GetCSRequest { }
    [Route("/CS", Verbs = "POST")]
    [Route("/CS/{CSId}", Verbs = "PUT")]

    public class CSRequest
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public double Price { get; set; }


    }
    [Route("/CS/{CSId}", Verbs = "GET, DELETE")]
    public class CSIdRequest
    {
        public int CSId { get; set; }
    }

}