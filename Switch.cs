using Switchboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchboard
{
    class Switch
    {
        public int SwitchId { get; }
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public bool State { get; set; }
        public Switch(int switchId, int deviceId,string deviceName)
        {
            SwitchId = switchId;
            DeviceId = deviceId;
            DeviceName = deviceName;
            State = false;
        }
        public void ToggleState()
        {
            State = !State;
        }
        public String GetState()
        {
            if (State)
            {
                return "ON";
            }
            else
            {
                return "OFF";
            }
        }
    }
}