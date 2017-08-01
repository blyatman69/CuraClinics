using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using ServiceStack.DataAnnotations;

namespace Cura.CuraClinics.ServiceModel
{
    //[Route("/Clinic/{Name}")]

   public class Clinic 
    {
        [AutoIncrement]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Tag { get; set; }
        public String Description { get; set; }
    }

   
}
