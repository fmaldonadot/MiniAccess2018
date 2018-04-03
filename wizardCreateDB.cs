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
using System.IO;

namespace miniAccess2018_V1_0
{
    public partial class wizardCreateDB : Form
    {
        public wizardCreateDB()
        {
            InitializeComponent();
            
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            diagFolder.ShowDialog();
            txtFolderPath.Text = diagFolder.SelectedPath;
        }

        private void txtFPath_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void wizardCreateDB_Load(object sender, EventArgs e)
        {
            txtFolderPath.Text = diagFolder.SelectedPath;
        }

        private void bntCancel_Click(object sender, EventArgs e)
        {
            WizardWelcome wizwelcome = new WizardWelcome();
            this.Close();
            wizwelcome.Show();

        }

        private void bntCancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to abandon the Wizard?.", "Wizard Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text + ".accdb";
            string folderpath = txtFolderPath.Text + "/";

            try
            {
                DBEngine dbeng = new DBEngine();
                Database mydb;

                mydb = dbeng.CreateDatabase(folderpath + fileName, DAO.LanguageConstants.dbLangGeneral);
                
                MessageBox.Show("Data Base file " + fileName + " has been created", "Creation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

                wizardTable wiztable = new wizardTable(fileName , mydb, false);
                wiztable.MdiParent = mainForm.ActiveForm;
                
                wiztable.Show();
                
            }
            catch
            {
                MessageBox.Show("Data Base " + fileName + " exist\nSelect other filename","File Exist" , MessageBoxButtons.OK , MessageBoxIcon.Error );
                txtFileName.Text = "";
            }
            
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
