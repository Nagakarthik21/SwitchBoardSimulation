using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchboard
{
    public class Device
    {
        public int DeviceId { get; }
        public string Name { get; }
        public bool State { get; set; }

        public Device(int deviceId, string name)
        {
            DeviceId = deviceId;
            Name = name;
            State = false;
        }
        public void ToggleState()
        {
            State = !State;
        }
    }
}