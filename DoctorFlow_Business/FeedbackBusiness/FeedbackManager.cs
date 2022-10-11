using DoctorFlow_Data.Data;
using DoctorFlow_Data.Data.FeedbackData;
using DoctorFlow_Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorFlow_Business.FeedbackBusiness
{
    public class FeedbackManager : IFeedbackManager
    {
       IFeedbackRepository repository= new FeedbackRepository();
        public void Add(Feedback feedback)
        {

            repository.Add(feedback);
            return;
        }

        public Feedback GetById(long id)
        {
            Feedback fed = repository.GetById(id);
            return fed;
        }

        public IEnumerable<Feedback> GetFeedbacks()
        {
            return repository.GetFeedbacks();
        }

        public void Remove(int id)
        {
            repository.Remove(id);
        }
    }
}
