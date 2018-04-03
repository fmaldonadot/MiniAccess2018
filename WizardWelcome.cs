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
    public partial class WizardWelcome : Form
    {
        public WizardWelcome()
        {
            InitializeComponent();
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to abandon the Wizard?.", "Wizard Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            wizardCreateDB wizCreate = new wizardCreateDB();
            this.Close();

            wizCreate.MdiParent = mainForm.ActiveForm;
            wizCreate.Show();

        }

        private void WizardWelcome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
