using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using Cura.CuraClinics.DataLayer;
using Cura.CuraClinics.ServiceModel;
using Cura.CuraClinics.Views;

namespace Cura.CuraClinics.ServiceInterface
{
    public class DoctorService : Service
    {
        public List<Doctor> Get(GetDoctorRequest request)
        {
            DoctorData cd = new DoctorData(Db);
            return cd.getDoctorList();
        }
        public Doctor Get(DoctorIdRequest request)
        {
            DoctorData cd = new DoctorData(Db);
            return cd.getDoctorById(request.DoctorID);
        }
        public int Post(DoctorRequests request)
        {
            var c = new Doctor()
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Email = request.Email,
                JoinDate = request.JoinDate,
                Title = request.Title,
                Website = request.Website,
                PhoneNumber = request.PhoneNumber,
                Reviews = request.Reviews,
                Language = request.Language,
                RewardsAndCertificates = request.RewardsAndCertificates

            };
            DoctorData cd = new DoctorData(Db);
            return cd.addDoctor(c);
        }
        public Doctor Put(DoctorRequests request)
        {
            Doctor c = new Doctor()
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Email = request.Email,
                JoinDate = request.JoinDate,
                Title = request.Title,
                Website = request.Website,
                PhoneNumber = request.PhoneNumber,
                Reviews = request.Reviews,
                Language = request.Language,
                RewardsAndCertificates = request.RewardsAndCertificates

            };
            DoctorData cd = new DoctorData(Db);
            return cd.UpdateDoctor(c);
        }
        public void Delete(DoctorIdRequest request)
        {
            DoctorData cd = new DoctorData(Db);
            cd.DeleteDoctorById(request.DoctorID);
        }

    }
}