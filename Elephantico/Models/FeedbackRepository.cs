using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elephantico.Models
{
    public class FeedbackRepository: IFeedbackRepository
    {
        private readonly AppDBContex _appDBContex;

        // we inject dbcontext
        // we use dbcontext to add feedback to database
        public FeedbackRepository(AppDBContex appDBContex)
        {
            _appDBContex = appDBContex;
        }
        public void AddFeedback(Feedback feedback)
        {
            _appDBContex.Feedbacks.Add(feedback);
            _appDBContex.SaveChanges();
        }
    }
}
