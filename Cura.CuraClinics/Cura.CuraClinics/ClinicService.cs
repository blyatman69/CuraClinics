using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using ServiceStack;
using Cura.CuraClinics.ServiceModel;

namespace Cura.CuraClinics.ServiceInterface
{
    public class ClinicService : Service
    {
       public List<Clinic>Get(GetClinicRequest request)
        {
            ClinicData cd = new ClinicData(Db);
            return cd.getClinicList();
        }
        public Clinic Get(ClinicIdRequest request)
        {
            ClinicData cd = new ClinicData(Db);
            return cd.getClinicById(request.ClinicId);
        }
        public int Post(Requests request)
        {
            var c = new Clinic()
            {
                Name = request.Name,
                Tag = request.Tag,
                Description = request.Description
            };
            ClinicData cd = new ClinicData(Db);
            return cd.addClinic(c);
        }
        public Clinic Put(Requests request)
        {
            var c = new Clinic()
            {
                Id = request.Id,
                Name = request.Name,
                Tag = request.Tag,
                Description = request.Description
            };
            ClinicData cd = new ClinicData(Db);
            return cd.UpdateClinic(c);
        }
        public void Delete(ClinicIdRequest request)
        {
            ClinicData cd = new ClinicData(Db);
            cd.DeleteClinicById(request.ClinicId);
        }
    
    }
}
