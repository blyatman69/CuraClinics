using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace Cura.CuraClinics
{
    [Route("/Clinic", Verbs = "GET")]
    public class GetClinicRequest { }
    [Route("/Clinic", Verbs = "POST")]
    [Route("/Clinic/{ClinicId}", Verbs = "PUT")]

    public class Requests
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Tag { get; set; }
        public String Description { get; set; }
        public int OpeningTime { get; set; }
        public String Location { get; set; }
        public int PhoneNumber { get; set; }
        public String Email { get; set; }
        public String Website { get; set; }
        public String Treatments { get; set; }
        public Double Reviews { get; set; }
        public DateTime JoinDate { get; set; }
        public String Language { get; set; }
        public String RewardsAndCertificates { get; set; }
    }
    [Route("/Clinic/{ClinicId}",Verbs="GET, DELETE")]
    public class ClinicIdRequest
    {
        public int ClinicId { get; set; }
    }

}