using Fundamentals.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Fundamentals.ViewModels
{
    public class MainViewModel
    {
        //IDeviceOrientationService orientationService;
        public ICommand GetDeviceOrientationCommand { get; set; }

        IDeviceOrientationService orientationService { get; set; }

        public string OrientationLabel { get; set; }

        public string DeviceOrientationTitle => "Device Orientation";
        public string DeviceOrientationIcon => "DeviceOrientationImg";

        public MainViewModel()
        {
            orientationService = DependencyService.Get<IDeviceOrientationService>();     
            DeviceOrientation orientation = orientationService.GetOrientation();

            GetDeviceOrientationCommand = new Command(() => GetOrientationDevice(orientation));
        }

        private void GetOrientationDevice(DeviceOrientation orientation) => OrientationLabel = orientation.ToString();
        
    }
}
