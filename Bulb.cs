using Switchboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchboard
{
    class Bulb : Device
    {
        static int i = 1;
        public Bulb(int deviceId) : base(deviceId, ("Bulb"+(i++)))
        {

        }
    }
}