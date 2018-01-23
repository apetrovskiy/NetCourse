using System.ServiceProcess;

namespace WindowsServiceSampleApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            if (System.Environment.UserInteractive)
                RunInteractive();
            else
                RunAsService();
        }

        private static void RunInteractive()
        {
            var service = new MyService();
            service.RunMe();
        }

        private static void RunAsService()
        {
            var servicesToRun = new ServiceBase[]
            {
                new MyService()
            };
            ServiceBase.Run(servicesToRun);
        }
    }
}
