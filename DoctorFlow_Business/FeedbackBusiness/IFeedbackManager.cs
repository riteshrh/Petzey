using DoctorFlow_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFlow_Business.FeedbackBusiness
{
    public interface IFeedbackManager
    {
        IEnumerable<Feedback> GetFeedbacks();
        Feedback GetById(long id);

        void Add(Feedback feedback);
        void Remove(int id);
    }
}
