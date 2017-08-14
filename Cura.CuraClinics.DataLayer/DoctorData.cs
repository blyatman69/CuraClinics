using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.OrmLite;
using ServiceStack;
using Cura.CuraClinics.ServiceModel;

namespace Cura.CuraClinics.Views
{
    public class DoctorData
    {
        System.Data.IDbConnection _dbConnection;
        public DoctorData(System.Data.IDbConnection dbconnection)
        {
            _dbConnection = dbconnection;
        }
        public int addDoctor(Doctor c)
        {
            return (int)_dbConnection.Insert<Doctor>(c, selectIdentity: true);
        }
        public List<Doctor> getDoctorList()
        {
            return _dbConnection.Select<Doctor>();
        }
        public Doctor getDoctorById(int id)
        {
            return _dbConnection.SingleById<Doctor>(id);
        }
        public Doctor UpdateDoctor(Doctor c)
        {
            _dbConnection.Update<Doctor>(c);
            return c;
        }
        public int DeleteDoctorById(int id)
        {
            return _dbConnection.Delete(getDoctorById(id));
        }
    }
}