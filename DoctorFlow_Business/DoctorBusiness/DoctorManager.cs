using DoctorFlow_Data.Data;
using DoctorFlow_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFlow_Business.DoctorBusiness
{
    public class DoctorManager : IDoctorManager
    {
        IDoctorRepository repository = new DoctorRepository();
        public void Delete(int id)
        {
            repository.Remove(id);
        }

        public void Add(Doctor doc)
        {
            repository.Add(doc);
            return;
        }

        public Doctor GetDoctorById(long id)
        {
            Doctor doc = repository.GetById(id);
            return doc;
        }

      

        public IEnumerable<Doctor> GetDoctors()
        {
            return repository.GetDoctors();
        }

        public void Update(Doctor doctor)
        {
            repository.Edit(doctor);
        }
    }
}
