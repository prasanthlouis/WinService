using System.ServiceProcess;
using System.Timers;

namespace Test_Service
{
    public partial class Service1 : ServiceBase
    {
        Timer timer1 = new Timer();

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Methods.WriteMessage("Starting This Up");
            timer1.Interval = 6000;
            timer1.Enabled = true;
            timer1.Elapsed += new ElapsedEventHandler(Timer1_Elapsed);

        }

        private void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            Methods.WriteMessage("Time Elapsed. Writing Message");
        }

        protected override void OnStop()
        {
            timer1.Enabled = false;
            Methods.WriteMessage("Service Has Stopped");
        }
    }
}
