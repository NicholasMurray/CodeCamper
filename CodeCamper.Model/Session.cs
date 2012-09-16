using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamper.Model
{
    public class Session : SessionBrief
    {
        public string Description { get; set; }

        public Person Speaker { get; set; }
        public Track Track { get; set; }
        public TimeSlot TimeSlot { get; set; }
        public Room Room { get; set; }

        public virtual ICollection<Attendance> AttendanceList { get; set; }
    }
}
