namespace WindowsServiceSampleApp
{
    using System;
    using System.IO;
    using System.ServiceProcess;

    public partial class MyService : ServiceBase
    {
        private StreamWriter writer;

        public MyService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var suffix = $"{DateTime.Now.Hour}{DateTime.Now.Minute}{DateTime.Now.Second}";
            using (writer = new StreamWriter(@"d:\projects\log_" + suffix + ".txt"))
            {
                writer.WriteLine("our service has started...");
                writer.Close();
            }
        }

        public void RunMe()
        {
            this.OnStart(new string[]{});
        }

        protected override void OnStop()
        {
        }
    }
}
