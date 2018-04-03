using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADODB;
using System.Data.OleDb;

namespace miniAccess2018_V1_0
{
    public partial class frmTablesRecordset : Form
    {
        OleDbConnection mycon;
        DataTable dbTable = new DataTable();
        DataSet dSetDB = new DataSet("openDB");
        OleDbDataAdapter daDB;

        string filePath;


        public frmTablesRecordset(string fname)
        {
            filePath = fname;
            
            InitializeComponent();
        }

        private void frmTablesRecordset_Load(object sender, EventArgs e)
        {
            mycon = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + filePath);
            mycon.Open();

            lblDBName.Text = filePath;
            // Get the Tables Names
            string[] restriction = new string[4];
            restriction[3] = "Table";            
            DataTable tempdt = mycon.GetSchema("Tables" , restriction);

            // Assign Table's Name to Tree Tables

            for (int i = 0; i< tempdt.Rows.Count; i++)
            {
                treeTables.Nodes.Add(tempdt.Rows[i][2].ToString());
            }

            // Get all DB Tables
            //getTables();

            getTablesWithDataSet();
        }

        //public void getTables()
        //{
        //    OleDbCommand command;
        //    OleDbDataReader reader;
        //    DataGridView tgrid = null;
        //    DataTable tmpdt;

        //    for (int i = 0; i < treeTables.Nodes.Count; i++)
        //    {
        //        tmpdt = new DataTable();

        //        // Add new Tab page
        //        TabPage tbtmp = new TabPage(treeTables.Nodes[i].Text);
        //        tbtmp.Width = tabTables.Width;
        //        tbtmp.Height = tabTables.Height;


        //        //New Data Grid
        //        tgrid = new DataGridView();
        //        tgrid.DataSource = tmpdt;
        //        tgrid.Width = tabTables.Width;
        //        tgrid.Height = tabTables.Height;
        //        tgrid.ScrollBars = ScrollBars.Both;
        //        tgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //        tgrid.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
        //                        | AnchorStyles.Left)
        //                        | AnchorStyles.Right)));

        //        //Get Recordsets of Tables
        //        command = new OleDbCommand("SELECT * FROM " + treeTables.Nodes[i].Text, mycon);
        //        reader = command.ExecuteReader();
        //        tmpdt.Load(reader);

        //        // Insert Data Grid into Tab Page                
        //        tbtmp.Controls.Add(tgrid);
        //        tabTables.Controls.Add(tbtmp);


        //    }
        //}

        public void getTablesWithDataSet()
        {
            DataTable tmpdt;
            DataGridView tgrid = null;

            for (int i = 0; i < treeTables.Nodes.Count; i++)
            {
                // Create a Data adapter to get each table
                daDB = new OleDbDataAdapter("SELECT * FROM " + treeTables.Nodes[i].Text, mycon);
                // Fill Data Set Schema
                daDB.FillSchema(dSetDB, SchemaType.Source, treeTables.Nodes[i].Text);
                // Fill Data Set Tables
                daDB.Fill(dSetDB, treeTables.Nodes[i].Text);
                // Instance the Object Data Table to work with Data grid view
                tmpdt = dSetDB.Tables[treeTables.Nodes[i].Text];

                // Add new Tab page
                TabPage tbtmp = new TabPage(treeTables.Nodes[i].Text);
                tbtmp.Width = tabTables.Width;
                tbtmp.Height = tabTables.Height;


                //New Data Grid
                tgrid = new DataGridView();
                tgrid.DataSource = tmpdt;
                tgrid.Width = tabTables.Width;
                tgrid.Height = tabTables.Height;
                tgrid.ScrollBars = ScrollBars.Both;
                tgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tgrid.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
                                | AnchorStyles.Left)
                                | AnchorStyles.Right)));

                
                // Insert Data Grid into Tab Page                
                tbtmp.Controls.Add(tgrid);
                tabTables.Controls.Add(tbtmp);
            }
        }

        private void lblDBName_Click(object sender, EventArgs e)
        {

        }

        private void treeTables_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tabTables.SelectedTab = tabTables.TabPages[treeTables.SelectedNode.Index];
        }

        private void tabTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
       
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            daDB = new OleDbDataAdapter();
            // Create a Command Builder to manage the Data Adapter
            OleDbCommandBuilder comBtmp = new OleDbCommandBuilder(daDB);


            foreach (TreeNode tmp in treeTables.Nodes)
            {
                MessageBox.Show(tmp.Text+"xxx");
                daDB.SelectCommand = new OleDbCommand("SELECT * FROM " + tmp.Text, mycon);
                // Update DB with the Data set Info with the Data adapter
                daDB.Update(dSetDB, tmp.Text);
            }

            MessageBox.Show("DB Updated");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
