using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace Test_Service
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
            this.AfterInstall += new InstallEventHandler(AfterInstallMethod);
        }

        private void AfterInstallMethod(object sender, InstallEventArgs e)
        {
            using (var serviceController = new ServiceController(serviceInstaller1.ServiceName))
            {
                serviceController.Start();
            }
        }
    }
}
