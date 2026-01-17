using System.Windows.Forms;

namespace light_control
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, System.EventArgs e)
        {
            var WinSettings = new WinSettings();
            WinSettings.Show();
        }

        private void mainWindow_Load(object sender, System.EventArgs e)
        {

        }

        private void lblTest_Click(object sender, System.EventArgs e)
        {

        }
    }
}
