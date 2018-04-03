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
    public partial class About : Form
    {
        ToolStripMenuItem tstAbout, tstFile;
        public About(ToolStripMenuItem tmpMAbout , ToolStripMenuItem tmpMFile)
        {
            tstAbout = tmpMAbout;
            tstFile = tmpMFile;
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tstAbout.Enabled = true;
            tstFile.Enabled = true;
            
            this.Close();
        }
    }
}
