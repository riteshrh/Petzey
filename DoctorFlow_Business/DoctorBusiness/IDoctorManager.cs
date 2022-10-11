﻿using DoctorFlow_Data.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFlow_Business.DoctorBusiness
{
    public interface IDoctorManager
    {

        IEnumerable<Doctor> GetDoctors();
        Doctor GetDoctorById(long id);
        void Delete(int id);
        void Update(Doctor doctor);

        void Add(Doctor doctor);


    }
}
