using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace HelloService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
        }
        internal static void Start()
        {
            string msg = "Hello";
            string[] keys = ConfigurationManager.AppSettings.AllKeys;
            foreach (var item in keys)
            {
                if (item == "console")
                {
                    SendConsole sendConsole = new SendConsole();
                    sendConsole.Notify(msg);
                }
                else
                {
                    SendEmail sendEmail = new SendEmail();
                    sendEmail.Notify(msg);
                }
            }
        }

        internal static void Stop()
        {
            Console.WriteLine("hello");
        }
    }
}
