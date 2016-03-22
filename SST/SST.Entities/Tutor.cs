using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Entities
{
    public class Tutor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public TimeSpan BeginningWorkingDay { get; set; }
        public TimeSpan EndWorkingDay { get; set; }
        public Discipline DisciplineInfo { get; set; }
        public Price PriceInfo { get; set; }
    }
}
