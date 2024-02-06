using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchboard
{
    class SwitchBoard
    {
        public List<Switch> switches = new List<Switch>();

        public void AddSwitch(Switch newSwitch)
        {
            switches.Add(newSwitch);
        }
        public void ShowMenu()
        {
            foreach (Switch switchBtn in switches)
            {
                Console.WriteLine((switches.IndexOf(switchBtn) + 1) + ". " + switchBtn.DeviceName + " is " + switchBtn.GetState()); 
            }
        }
        public void ChangeSwitchState(int deviceId)
        {
            foreach(Switch switchButton in switches)
            {
                if(switchButton.DeviceId == deviceId)
                {
                    switchButton.ToggleState();
                }
            }
        }
       
    }
}