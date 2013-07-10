using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArdunioRadar
{
    public class PingResponse
    {
        public PingResponse(int Degree, int Distance)
        {
            this.Degree = Degree;
            this.Distance = Distance;
            this.timestamp = DateTime.Now;
        }
        public DateTime timestamp;
        public int Degree;
        public int Distance;
    }
}
