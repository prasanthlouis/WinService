using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WinService
{
    public partial class TestService : ServiceBase
    {
        public TestService()
        {
            InitializeComponent();
            eventLog1.Source = "Event Log Source";
            eventLog1.Log = "Event Log";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("We've reached the OnStart Method");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("We've reached the OnStop Method");
        }

        protected override void OnContinue()
        {
            eventLog1.WriteEntry("Inside the OnContinue Method");
        }
    }
}
