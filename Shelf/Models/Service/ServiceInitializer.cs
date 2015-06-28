using Shelf.GoodRead;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Resources;
using Windows.ApplicationModel.Resources.Core;
using Windows.UI.Xaml.Controls;

namespace Shelf.Models.Navigation
{
    public static class ServiceInitializer
    {
        private static bool _working;

        public static void BeginInitialization()
        {
            if (_working) throw new Exception("Invalid reinitialization"); //You can't initialize this twice.

            _working = true;
            Task.Run(() =>
            {
                ResourceLoader loader = new ResourceLoader();
                string key = loader.GetString("ApiKey");
                string secret = loader.GetString("ApiSecret");
                ServiceKey serviceKey = ServiceKey.AcquireKey(key, secret);

                App.ApiAccessKey = serviceKey;
                _working = false;
            });
        }
    }
}
