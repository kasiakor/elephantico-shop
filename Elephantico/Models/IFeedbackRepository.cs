using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elephantico.Models
{
    public interface IFeedbackRepository
    {
        // a method that will allow to add feedback
        void AddFeedback(Feedback feedback);
    }
}
