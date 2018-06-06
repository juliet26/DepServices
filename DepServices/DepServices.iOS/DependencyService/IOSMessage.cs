using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DepServices.DependencyServices;
using Dservices.iOS.DependencyServices;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency( typeof(iOSMessage)) ]
namespace Dservices.iOS.DependencyServices
{
    public class iOSMessage : IPlatMessage
    {
        public string GetMessage()
        {
            return "Estoy desde  iOS";
        }
    }
}