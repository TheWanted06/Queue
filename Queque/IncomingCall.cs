using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queque
{
    class IncomingCall
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public DateTime CallTime { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Consultant { get; set; }

        //add a new prop-->
        public bool isPriority { get; set; }
    }
}

