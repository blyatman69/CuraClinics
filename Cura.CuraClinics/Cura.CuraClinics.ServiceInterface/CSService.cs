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
    public class CSService : Service
    {
        public List<CS> Get(GetCSRequest request)
        {
            CSData cd = new CSData(Db);
            return cd.GetCSList();
        }
        public CS Get(CSIdRequest request)
        {
            CSData cd = new CSData(Db);
            return cd.getCSById(request.CSId);
        }
        public int Post(CSRequest request)
        {
            var c = new CS()
            {
                Id=request.Id,
                Name = request.Name,
                Price = request.Price
              
            };
            CSData cd = new CSData(Db);
            return cd.addCS(c);
        }
        public CS Put(CSRequest request)
        {
            var c = new CS()
            {
                Id = request.Id,
                Name = request.Name,
                Price = request.Price
               
            };
            CSData cd = new CSData(Db);
            return cd.UpdateCS(c);
        }
        public void Delete(CSIdRequest request)
        {
            CSData cd = new CSData(Db);
            cd.DeleteCSById(request.CSId);
        }

    }
}