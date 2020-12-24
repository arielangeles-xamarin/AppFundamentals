using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Fundamentals.Services
{
    public interface IDeviceOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
