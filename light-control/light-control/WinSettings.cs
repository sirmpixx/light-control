using System;
using System.Windows.Forms;

namespace light_control
{
    public partial class WinSettings : Form
    {
        public WinSettings()
        {
            InitializeComponent();
        }

        private void WinSettings_Load(object sender, EventArgs e)
        {

        }

        private void btnNoSave_Click(object sender, EventArgs e)
        {
            // Source - https://stackoverflow.com/a
            // Posted by Mikael Svenson
            // Retrieved 2026-01-14, License - CC BY-SA 2.5

            DialogResult dialogResult = MessageBox.Show("Wollen Sie wirklich nicht Speicher?", "Nicht Speichern", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //To-Do: Save Settings
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
