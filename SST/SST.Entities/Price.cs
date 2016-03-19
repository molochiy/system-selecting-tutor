using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Entities
{
    public class Price
    {
        public int Id { get; set; }
        public int TutorId { get; set; }
        public int DesciplineId { get; set; }
        public decimal LessonPrice { get; set; }
    }
}
