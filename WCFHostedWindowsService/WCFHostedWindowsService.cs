using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WCFHostedWindowsService
{
    public partial class WCFHostedWindowsService : ServiceBase
    {
        public ServiceHost serviceHost = null;

        public WCFHostedWindowsService()
        {
            ServiceName = "WCFHelloService";
        }
        //public static void Main()
        //{
        //    ServiceBase.Run(new WCFHostedWindowsService());
        //}

        protected override void OnStart(string[] args)
        {
            if (serviceHost!=null)
            {
                serviceHost.Close();
            }
            serviceHost = new ServiceHost(typeof(HelloWorldServiceNS.HelloWorldService));
            serviceHost.Open();

        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
