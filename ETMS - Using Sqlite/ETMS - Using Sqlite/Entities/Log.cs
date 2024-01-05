using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETMS___Using_Sqlite.Entities
{
    public class Log
    {
        public Guid LogId { get; set; }
        public DateTime? TimeStamp { get; set; }
        public uint Timeshift { get; set; }
    }
}
