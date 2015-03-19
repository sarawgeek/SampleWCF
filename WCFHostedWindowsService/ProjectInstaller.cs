﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WCFHostedWindowsService
{
    [RunInstaller(true)]
    public class ProjectInstaller:Installer
    {
        private ServiceProcessInstaller process;
        private ServiceInstaller service;

        public ProjectInstaller()
        {
            process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.User;
            service = new ServiceInstaller();
            service.ServiceName = "WCFWindowsServiceSample"; service.Description = "Sample Service By Gaurav";
            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
