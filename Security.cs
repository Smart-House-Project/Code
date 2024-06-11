using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseProject
{
    public class Security
    {
        bool burglarAlarmStatus;
        private bool alarmStatus;

        public void ArmAlarm()
        {
            Console.WriteLine("Burglar alarm is on");
            burglarAlarmStatus = true;
            throw new NotImplementedException();
        }

        public void DisarmAlarm()
        {
            Console.WriteLine("Burglar alarm is off");
            burglarAlarmStatus = false;
            throw new NotImplementedException();
        }
        public void TurnOnAlarm()
        {
            alarmStatus = true;
            
            NotifyAuthorities();
            SendAlerts();
            throw new NotImplementedException();
        }
        public void MonitorCameras()
        {
            Console.WriteLine("Monitoring the house...");
            throw new NotImplementedException();
        }

        public void NotifyAuthorities()
        {
            Console.WriteLine("Calling the police...");
            Console.WriteLine("Calling the owners...");
            throw new NotImplementedException();
        }

        public void ControlAccess()
        {
            throw new NotImplementedException();
        }

        public void SendAlerts()
        {
            if(alarmStatus)
            {
                Console.WriteLine("ALARM!!!ALARM!!!SOMEONE BROKE INTO THE HOUSE!!!");
            }
            throw new NotImplementedException();
        }

    }
}
