using Switchboard;


namespace Switchboard
{
    class StartUp
    {
        public void HandleDevice(Device device)
        {
            Console.WriteLine("1. Switch " + device.Name + " " + (device.State ? "OFF":"ON"));
            Console.WriteLine("2. Back");
        }
        static void Main()
        {
            Console.Write("Number of Fans : ");
            int fans = Helper.Input();
            Console.Write("Number of Acs : ");
            int acs = Helper.Input();
            Console.Write("Number of Bulbs : ");
            int bulbs = Helper.Input();

            SwitchBoard switchboard = new SwitchBoard();
            StartUp startup = new StartUp();
            List<Device> devices = new List<Device>();

            int j = 1;

            for (int i = 0; i < fans; i++)
            {
                Fan fan = new Fan(j);
                devices.Add(fan);
                Switch fanSwitch = new Switch(j, fan.DeviceId, ("Fan"+(i+1)));
                switchboard.AddSwitch(fanSwitch);
                j++;
            }
            for (int i = 0; i < acs; i++)
            {
                AC ac = new AC(j);
                devices.Add(ac);
                Switch acSwitch = new Switch(j, ac.DeviceId,("AC"+(i+1)));
                switchboard.AddSwitch(acSwitch);
                j++;
            }
            for (int i = 0; i < bulbs; i++)
            {
                Bulb bulb = new Bulb(j);
                devices.Add(bulb);
                Switch bulbSwitch = new Switch(j, bulb.DeviceId, ("Bulb" + (i + 1)));
                switchboard.AddSwitch(bulbSwitch);
                j++;
            }
            while (true)
            {
                switchboard.ShowMenu();
                Console.WriteLine("0. Exit");
                Console.WriteLine("Type the Device Number");

                int number = Helper.Input();

                if (number == 0)
                {
                   break;
                }
                else if (number > devices.Count)
                {
                    Console.WriteLine("Enter Valid Number");
                    number = Helper.Input();
                }

                Device device = null;

                foreach(Device appliance in devices)
                {
                    if(appliance.DeviceId == number)
                    {
                        device=appliance;
                    }
                }

                startup.HandleDevice(device);

                int choice = Helper.Input();

                if (choice == 1)
                {
                    switchboard.ChangeSwitchState(device.DeviceId);
                    device.ToggleState();
                }
            }
        }
    }
}