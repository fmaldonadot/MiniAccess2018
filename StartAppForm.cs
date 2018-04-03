using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniAccess2018_V1_0
{
    public partial class StartAppForm : Form
    {
        public StartAppForm()
        {
            InitializeComponent();
            
        }

        private void StartAppForm_Load(object sender, EventArgs e)
        {
            // Enable the timer of 3 sec
            timerRun.Enabled = true;
        }

        private void timerRun_Tick(object sender, EventArgs e)
        {
            // Disable timer when tick event is received
            timerRun.Enabled = false;

        }

        private void startingBar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
