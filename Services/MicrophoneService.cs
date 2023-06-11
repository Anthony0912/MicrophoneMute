using Entities;
using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Services
{
    public class MicrophoneService
    {
        private DeviceCollection device = new DeviceCollection();
        private List<DeviceCollection> devices = new List<DeviceCollection>();
        private MMDevice mMDevice;
        private MMDeviceEnumerator mMDeviceEnumerator;

        public MicrophoneService()
        {
            mMDeviceEnumerator = new MMDeviceEnumerator();
            mMDevice = GetMicrophoneDefaultSystem();
        }

        public void MuteMicrophone()
        {
            SetStatusMicrophone(true);
        }

        public void UnmuteMicrophone()
        {
            SetStatusMicrophone(false);
        }

        public DeviceCollection GetDefaultMicrophone()
        {
            device = LoadDeviceCollection(mMDevice);
            return device;
        }

        public List<DeviceCollection> GetListOfMicrophones()
        {
            try
            {
                MMDeviceCollection mMDeviceCollection = mMDeviceEnumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
                foreach (var collection in mMDeviceCollection)
                {
                    devices.Add(LoadDeviceCollection(collection));
                }
                return devices;
            }
            catch (COMException)
            {
                return null;
            }
        }

        private DeviceCollection LoadDeviceCollection(MMDevice device)
        {
            DeviceCollection deviceCollection = new DeviceCollection
            {
                Id = device.ID,
                Name = device.DeviceFriendlyName
            };
            return deviceCollection;
        }

        private void SetStatusMicrophone(bool stateMute)
        {
            if(mMDevice == null)
            {
                return;
            }
            mMDevice.AudioEndpointVolume.Mute = stateMute;
        }

        private MMDevice GetMicrophoneDefaultSystem()
        {
            try
            {
                MMDevice device = mMDeviceEnumerator.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Communications);
                return device;
            }
            catch(COMException)
            {
                return null;
            }
        }
    }
}
