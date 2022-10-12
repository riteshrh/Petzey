using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoctorFlow_Data.Entities
{
    public partial class DoctorFlowDbContext : DbContext
    {
        public DoctorFlowDbContext()
            : base("name=DoctorDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }

    }
}




