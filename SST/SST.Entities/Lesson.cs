using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Entities
{
    public class Lesson
    {
        public int Id { get; set; }
        public int TutorId { get; set; }
        public int LearnerId { get; set; }
        public int DisciplineId { get; set; }
        public DateTime LessonTime { get; set; }
        public bool IsPaid { get; set; }
        public int Status { get; set; }
        public int UserId { get; set; }
    }
}
