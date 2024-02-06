using Switchboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchboard
{
    class Fan : Device
    {
        static int i = 1;
        public Fan(int deviceId) : base(deviceId,("Fan"+(i++)))
        {

        }
    }
}