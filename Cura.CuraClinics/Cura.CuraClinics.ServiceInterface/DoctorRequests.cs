using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace Cura.CuraClinics
{
    [Route("/Doctor", Verbs = "GET")]
    public class GetDoctorRequest { }
    [Route("/Doctor", Verbs = "POST")]
    [Route("/Doctor", Verbs = "PUT")]

    public class DoctorRequests
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Title { get; set; }
        public String Email { get; set; }
        public String Description { get; set; }
        public String Website { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime JoinDate { get; set; }
        public double Reviews { get; set; }
        public String Language { get; set; }
        public String RewardsAndCertificates { get; set; }
    }
    [Route("/Doctor/{DoctorId}", Verbs = "GET, DELETE")]
    public class DoctorIdRequest
    {
        public int DoctorID { get; set; }
    }
}