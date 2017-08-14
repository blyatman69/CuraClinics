using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cura.CuraClinics.ServiceModel
{
   public class Doctor
    {
        [AutoIncrement]
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
}
