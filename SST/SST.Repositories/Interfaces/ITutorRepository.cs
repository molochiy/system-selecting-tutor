using SST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Repositories.Interfaces
{
    public interface ITutorRepository
    {
        IEnumerable<Tutor> SelectAllTutorsWithDisciplinesAndPrices();        
        IEnumerable<Tutor> GetTutorsByPartOfEmail(string email);

        Tutor GetTutorByEmail(string email);
        Tutor GetTutorById(int id);
    }
}
