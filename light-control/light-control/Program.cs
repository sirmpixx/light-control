using DotNetEnv;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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

            SetHueStateAsync(true).GetAwaiter().GetResult();
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

        public static async Task SetHueStateAsync(bool on)
        {
            string baseUrl = GetHueApiUrl();
            string url = baseUrl + "/lights/6/state";
            string json = "{ \"on\": " + on.ToString().ToLower() + " }";

            using (HttpClient client = new HttpClient())
            using (StringContent content = new StringContent(json, Encoding.UTF8, "application/json"))
            {
                await client.PutAsync(url, content);
            }
        }

    }
}
