using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace miniAccess2018_V1_0
{
    public partial class mainForm : Form
    {
        StartAppForm stapp;
        public mainForm()
        {                                  
            stapp = new StartAppForm();
            stapp.Show();

            // Create an Event Handler to manage the action when timer tick 
            stapp.timerRun.Tick += new EventHandler(closePresentation);
            this.StartPosition = FormStartPosition.CenterScreen;

            for (int i = 0; i <= 3000; i++)
                stapp.startingBar.Increment(1);
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
                        
            
        }
        private void closePresentation(object sender, EventArgs e)
        {
            // Inizialize this form and close the presentation form
            InitializeComponent();
            stapp.Close();

            //WizardWelcome wizwelc = new WizardWelcome();

            //wizwelc.MdiParent = this;

            //wizwelc.Show();

        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to extit?.", "Quit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void openWizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frmAbout;
            //if (About.ActiveForm != null)
            //{
            //    About.ActiveForm.Close();
            //}
            frmAbout = new About(menuAbout , menuFile);
            frmAbout.MdiParent = mainForm.ActiveForm;
            frmAbout.StartPosition = FormStartPosition.CenterScreen;
            menuAbout.Enabled = false;
            menuFile.Enabled = false;
            frmAbout.Show();
        }

        private void submenuOpenWiz_Click(object sender, EventArgs e)
        {
            WizardWelcome wizWelcome = new WizardWelcome();
            wizWelcome.Show();
        }

        private void openDBDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            try
            {
                DBEngine dbeng = new DBEngine();

                openDiagDBFile.ShowDialog();
                                
                Database mydb = dbeng.OpenDatabase(openDiagDBFile.FileName);

                wizardTable openTables = new wizardTable(openDiagDBFile.FileName, mydb, true);
                openTables.MdiParent = this;
                openTables.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Access 2016(*.accdb)|*.accdb|Access 2003-(*.mdb)|*.mdb";
            openFile.ShowDialog();

            if (openFile.FileName.Length > 0)
            {
                frmTablesRecordset dbTab = new frmTablesRecordset(openFile.FileName);

                dbTab.MdiParent = mainForm.ActiveForm;
                dbTab.Show();
            }
        }

        private void openDiagDBFile_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            submenuOpenWiz.PerformClick();
        }

        private void openToolMStrip_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem.PerformClick();
        }

        private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
