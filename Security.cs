using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseProject
{
    /// <summary>
    /// Клас Security представляє систему безпеки, яка включає функції 
    /// озброєння та роззброєння сигналізації, моніторингу камер, 
    /// контролю доступу та сповіщення влади.
    /// </summary>
    public class Security
    {
        bool burglarAlarmStatus;// Статус сигналізації від зломів
        private bool alarmStatus;// Загальний статус сигналізації
        /// <summary>
        /// Вмикає сигналізацію від зломів.
        /// </summary>
        public void ArmAlarm()
        {
            Console.WriteLine("Burglar alarm is on");
            burglarAlarmStatus = true;
            throw new NotImplementedException();
        }
        /// <summary>
        /// Вимикає сигналізацію від зломів.
        /// </summary>
        public void DisarmAlarm()
        {
            Console.WriteLine("Burglar alarm is off");
            burglarAlarmStatus = false;
            throw new NotImplementedException();
        }
        /// <summary>
        /// Вмикає загальну сигналізацію та сповіщає про злом.
        /// </summary>
        public void TurnOnAlarm()
        {
            alarmStatus = true;
            
            NotifyAuthorities();
            SendAlerts();
            throw new NotImplementedException();
        }
        /// <summary>
        /// Моніторить камери спостереження.
        /// </summary>
        public void MonitorCameras()
        {
            Console.WriteLine("Monitoring the house...");
            throw new NotImplementedException();
        }
        /// <summary>
        /// Сповіщає про злом.
        /// </summary>
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
        /// <summary>
        /// Надсилає сповіщення про тривогу.
        /// </summary>
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
