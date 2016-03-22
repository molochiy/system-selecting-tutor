using SST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Repositories.Interfaces
{
    public interface ILearnerRepository
    {
        IEnumerable<Learner> GetLearnersByPartOfEmail(string email);

        Learner GetLearnerByEmail(string email);

        int InsertLearner(Learner learner);        
    }
}
