using SST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Repositories.Interfaces
{
    public interface ILessonRepository
    {
        IEnumerable<Lesson> GetLessonsByLearnerId(int id);

        IEnumerable<Lesson> GetLessonsDateTimesByTutorId(int id);

        void UpdateLessonStatus(int id, int status);

        void UpdateLessonPaid(int id);
    }
}
