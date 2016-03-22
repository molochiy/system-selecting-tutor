using SST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Repositories.Interfaces
{
    public interface IDisciplineRepository
    {
        IEnumerable<Discipline> GetAllDesciplines();
        IEnumerable<Discipline> GetDisciplinesByTutorId(int id);
    }
}
