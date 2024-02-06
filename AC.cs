using Switchboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchboard
{
    class AC : Device
    {
        static int i = 1;
        public AC(int deviceId) : base(deviceId,("AC"+(i++)))
        {

        }
    }
}