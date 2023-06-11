using Entities;
using Services;
using System.Collections.Generic;

namespace Features
{
    public class MicrophoneFeature
    {
        private MicrophoneService microphoneFeature;

        public MicrophoneFeature()
        {
            microphoneFeature = new MicrophoneService();
        }

        public void MuteMicrophone()
        {
            microphoneFeature.MuteMicrophone();
        }

        public void UnmuteMicrophone()
        {
            microphoneFeature.UnmuteMicrophone();
        }

        public List<DeviceCollection> GetListOfMicrophones()
        {
            List<DeviceCollection> deviceCollection = microphoneFeature.GetListOfMicrophones();
            return deviceCollection;
        }

        public DeviceCollection GetDefaultMicrophone()
        {
            DeviceCollection deviceCollection = microphoneFeature.GetDefaultMicrophone();
            return deviceCollection;
        }
    }
}
