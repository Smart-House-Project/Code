using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouseProject
{
    public class Media
    {
        private Dictionary<int, boolean> deviceStatus;
        private Dictionary<int, Content> currentContent;
        private MediaLibrary mediaLibrary;
        private Dictionary<int, Schedule> playbackSchedule;
        private bool assistantIntegrationStatus;

        public void ControlDevice()
        {
            throw new NotImplementedException();
        }

        public void StreamContent()
        {
            throw new NotImplementedException();
        }

        public void ManageLibrary()
        {
            throw new NotImplementedException();
        }

        public void SchedulePlayback()
        {
            throw new NotImplementedException();
        }

        public void IntegrateWithAssistant()
        {
            throw new NotImplementedException();
        }

        public Service service;

    }
}
