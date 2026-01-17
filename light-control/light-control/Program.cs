using DotNetEnv;
using System;
using System.Windows.Forms;

namespace light_control
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]


        static void Main()
        {
            Env.Load(); // lädt .env automatisch

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new mainWindow());

        }
        private static string GetHueApiUrl()
        {
            string strHueIP = Environment.GetEnvironmentVariable("HUE_IP");
            string strHueAPI = Environment.GetEnvironmentVariable("HUE_API_KEY");
            return "http://" + strHueIP + "/api/" + strHueAPI;
        }
    }
}
