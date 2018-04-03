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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace miniAccess2018_V1_0
{
    public partial class wizardTable : Form
    {
        Database mydb;
        List<DataGridView> dgridList = new List<DataGridView>();

        // For future Open DB implementation
        bool opflag; 

        // Event handler to control the refresh Relation Form Event;
        public EventHandler<RelationFormUpdateEventArgs> relationRefresh;

        // InteropServices errors codes
        const int FieldExistErrorCode = -2146825097;
        const int FieldUnamedErrorCode = -2146825287;

        // Receive DB Name, Database and a open flag from previous Form
        // openflag to future Open functionaliity implementation 
        // using the same forms
        public wizardTable(string dbname , Database db , bool openFlag )
        {
            InitializeComponent();

            // To show DB file name in Form
            lblDBName.Text = "Data Base " + dbname;            
            mydb = db;
            btnCreateTables.Hide();
                        
        }

        private void wizardTable_Load(object sender, EventArgs e)
        {
            // Charge DataGridView comboboxes
            int i = 1;
            foreach (DataTypeEnum temp in Enum.GetValues(typeof(DataTypeEnum)))
            {
                if ( i < 16 ) // Only including 15 Data Types
                    colDataType.Items.Add(temp.ToString());
                i++;
            }

            // Add the first Grid to saved list
            /////////////////////////////////////////////
            // If include to perform soon Open DB Functionality
            /////////////////////////////////////////////
            if (!opflag)
            {
                dGridFields1.Rows.Add();
                dGridFields1.Rows[0].Cells["Key"].Value = "true";
                dGridFields1.Rows[0].Cells["colField"].Value = "ID";
                dGridFields1.Rows[0].Cells["colDataType"].Value = "dbLong";
                dgridList.Add(dGridFields1);
            }

        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string tabname = txtTableName.Text;

            // Assure that the table has a name
            if (txtTableName.Text == "")
            {
                MessageBox.Show("Table must has a name", "Table Name required" ,  MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // check if the name doesn't exist in DB
            foreach (TreeNode node in treeTables.Nodes)
            {
                if ( node.Text == txtTableName.Text)
                {
                    MessageBox.Show("Table name already exist in DB.\nChoice another name", "Table Name conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTableName.Text = "";
                    return;
                }
                
            }
            // Add node to Tree
            treeTables.Nodes.Add(txtTableName.Text);
            
            if (tabcontFields.Enabled == false)
            {
                tabcontFields.Enabled = true;
                tabcontFields.SelectedTab.Text = txtTableName.Text;
                dGridFields1.Visible = true;
                btnCreateTables.Show();
            }
            else
            {            
                // Create a Tabpage to Add    
                TabPage tpg = new TabPage(txtTableName.Text);
                // Create a cloned DataGridView
                DataGridView dgv = cloneDataGridView();
                
                // Add DataGridView control into tabpage created
                tpg.Controls.Add(dgv);

                //Add tabPage to TabControl
                tabcontFields.Controls.Add(tpg);
                dgv.Rows.Add();
                dgv.Name = "dGridFields" + tabcontFields.TabCount.ToString();
                
                // First field at each table will be called ID and will be defined as PK
                // This Field can be changed on the DataGridview if user wants
                dgv.Rows[0].Cells["Key"].Value = "true";
                dgv.Rows[0].Cells["colField"].Value = "ID";
                dgv.Rows[0].Cells["colDataType"].Value = "dbLong";

                // Save each DataGridview refferences in a list to create the DB tables later by one loop.
                dgridList.Add(dgv);

                
            }
                        

        }        
          
        private void btnCreateTables_Click(object sender, EventArgs e)
        {
            TableDef mytdef = null;
            Field myfield = null , indexfield;
            Index myInd = null;
            int j = 0;
            List<Field> flist = new List<Field>();
            
            try
            {
                // Delete all the tables from DB to avoid Table's conflicts
                //DeleteAllTables(mydb);
                
                foreach (TabPage tbtemp in tabcontFields.TabPages)
                {
                    // check if Table exist in DB
                    if (tableExist(mydb, tbtemp.Text) == false)
                    {
                        ////////////////////////////
                        // Table and Fields Creation
                        ////////////////////////////

                        mytdef = mydb.CreateTableDef(tbtemp.Text);

                        for (int i = 0; i < dgridList[j].RowCount - 1; i++)
                        {
                            myfield = mytdef.CreateField(dgridList[j].Rows[i].Cells["colField"].Value, (DataTypeEnum)Enum.Parse(typeof(DataTypeEnum), dgridList[j].Rows[i].Cells["colDataType"].Value.ToString()));

                            if (i == 0)
                                // Add autoincrement attribute to first field "ID"
                                myfield.Attributes = (Int32)DAO.FieldAttributeEnum.dbAutoIncrField;

                            // Add Field to TableDef
                            mytdef.Fields.Append(myfield);
                            flist.Add(myfield);
                        }

                        /////////////////////////////////////
                        ////Create an Index and Primary Key
                        /////////////////////////////////////
                        myInd = mytdef.CreateIndex(dgridList[j].Rows[0].Cells["colField"].Value.ToString());
                        myInd.Primary = true;

                        //////////////////////////////////
                        // Add field ID to index as ass Primary Key by default
                        //Creation of indexed fields
                        indexfield = myInd.CreateField(dgridList[j].Rows[0].Cells["colField"].Value);
                        //Add field in index
                        ((IndexFields)(myInd.Fields)).Append(indexfield);

                        // Creation of associated PK and indexes defined by the user
                        for (int i = 1; i < dgridList[j].RowCount - 1; i++)
                        {
                            // Verify if PK check Box is checked to create an index and Primary Key
                            if ((string)(dgridList[j].Rows[i].Cells["Key"]).Value == "true")
                            {
                                //Creation of indexed fields
                                indexfield = myInd.CreateField(dgridList[j].Rows[i].Cells["colField"].Value);

                                //Add field in index
                                ((IndexFields)(myInd.Fields)).Append(indexfield);

                            }
                        }
                        //Add index in the table
                        mytdef.Indexes.Append(myInd);

                        //Add table into DB
                        mydb.TableDefs.Append(mytdef);


                        // Add the Field's description to each field adding a new property to each cell
                        Property prt = null;
                        int rindex;
                        rindex = 0;
                        foreach (Field ftemp in flist)
                        {
                            if (dgridList[j].Rows[rindex].Cells["colDescription"].Value != null)
                            {
                                //Cretion of new porperty called Description in each Cell
                                prt = ftemp.CreateProperty("Description", DataTypeEnum.dbText, dgridList[j].Rows[rindex].Cells["colDescription"].Value);
                                ftemp.Properties.Append(prt);
                            }
                            rindex++;
                        }

                        flist.Clear();
                        j++;
                    }
                    else
                        j++;               
                }
                MessageBox.Show("Tables have been Created in DB " + mydb.Name, "Tables Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGoRelations.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("All fields must have a Data type selected in the table " + mytdef.Name, "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Runtime.InteropServices.COMException daoErr)
            {
                if (daoErr.ErrorCode == FieldExistErrorCode) // Field exist Error Code
                    MessageBox.Show("There are repeated fields in table " + mytdef.Name + "\nField's name must be unique", "Repeated Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (daoErr.ErrorCode == FieldUnamedErrorCode) // Field unamed Error Code
                    MessageBox.Show("All Fields must have a name in table " + mytdef.Name, "Unnamed Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else // Other Errors related to Interpot Services
                    MessageBox.Show( daoErr.Message , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)  // General Exceptions
            {
                MessageBox.Show(ex.ToString(), "Table Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        // Clone DataGridView made in Designer
        public DataGridView cloneDataGridView()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            DataGridView dGridFields2 = new DataGridView();
            DataGridViewCheckBoxColumn Key = new DataGridViewCheckBoxColumn();
            DataGridViewTextBoxColumn colField = new DataGridViewTextBoxColumn();
            DataGridViewComboBoxColumn colDataType = new DataGridViewComboBoxColumn();
            DataGridViewTextBoxColumn colDescription = new DataGridViewTextBoxColumn();

            // 
            // dGridFields2
            // 
            dGridFields2.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dGridFields2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dGridFields2.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            dGridFields2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGridFields2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dGridFields2.BackgroundColor = SystemColors.Info;
            dGridFields2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dGridFields2.Columns.AddRange(new DataGridViewColumn[] {
            Key,
            colField,
            colDataType,
            colDescription});
            dGridFields2.Location = new Point(0, 0);
            dGridFields2.Name = "dGridFields2";
            dGridFields2.Size = new Size(357, 192);
            dGridFields2.TabIndex = 0;
            dGridFields2.Visible = true;
            // 
            // Key
            // 
            Key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            Key.FalseValue = "false";
            Key.HeaderText = "PK";
            Key.Name = "Key";
            Key.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Key.TrueValue = "true";
            Key.Width = 46;
            // 
            // colField
            // 
            colField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            colField.HeaderText = "Field Name";
            colField.Name = "colField";
            colField.Width = 85;
            // 
            // colDataType
            // 
            colDataType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            colDataType.HeaderText = "Data Type";
            colDataType.Name = "colDataType";
            colDataType.Width = 63;
            // Charge DataGridView comboboxes
            int i = 1;
            foreach (DataTypeEnum temp in Enum.GetValues(typeof(DataTypeEnum)))
            {
                if (i < 16) // Only including 15 Data Types Supported
                    colDataType.Items.Add(temp.ToString());

                i++;
            }
            // 
            // colDescription
            // 
            colDescription.HeaderText = "Description";
            colDescription.Name = "colDescription";

            return dGridFields2;

        }

        // Delete all user tables from a DB
        public void DeleteAllTables(Database tmpDB)
        {            
            for( int i = tmpDB.TableDefs.Count - 1; i >= 0; i--)
            {                
                if (tmpDB.TableDefs[i].Attributes == 0)
                {
                    tmpDB.TableDefs.Delete(tmpDB.TableDefs[i].Name);                    
                }
            }
        }

        // To change Control Tab pressing trees nodes
        private void treeTables_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tabcontFields.SelectedTab = tabcontFields.TabPages[treeTables.SelectedNode.Index];
        }

        // To go to Relation's Form after created the tables into DB
        private void btnGoRelations_Click(object sender, EventArgs e)
        {
            bool flag = true;
            
            try
            {
                // Search if there is a Relationship Form active
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    // Relationship Form found
                    if (Application.OpenForms[i].GetType() == typeof(wizardRelationships))
                    {
                        flag = false;  // Flag to avoid to create a new Relationship form

                        //////////////// Invoque Event /////////////////////////////////////
                        EventHandler<RelationFormUpdateEventArgs> handler = relationRefresh;
                        if (handler != null)
                        {
                            handler(this, new RelationFormUpdateEventArgs()
                            {
                                relRefresh = true
                            });
                        }
                        ////////////////////////////////////////////////////////////////////
                    }

                }
                if (flag == true) // When the Relationship form is not active is created a new form
                {
                    wizardRelationships wizrel = new wizardRelationships(lblDBName.Text, mydb );
                    wizrel.MdiParent = mainForm.ActiveForm;
                    wizrel.Show();
                    mainForm.ActiveForm.LayoutMdi(MdiLayout.TileVertical);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

       public static ListView CloneListView(ListView sourceList)
        {
            ListView tmplist = new ListView();
            
            foreach (ListViewItem tmpitem in sourceList.Items)
            {
                tmplist.Items.Add((ListViewItem)tmpitem.Clone());
            }
            return tmplist;
        }

        // Class inherit from EventArgs to send an Event to reload Relation forms with new tables defs 
        // information added in Table Form when button RelationsShips is clicked
        public class RelationFormUpdateEventArgs : EventArgs
        {
            public bool relRefresh { get; set; }
        }

        // Method for verity if table exist in DB
        public bool tableExist(Database mydb, string tablename)
        {
            foreach( TableDef tmp in mydb.TableDefs )
            {
                if (tmp.Name == tablename)
                    return true;
            }
            return false;
        }

        private void lblDBName_Click(object sender, EventArgs e)
        {

        }
        private void dGridFields_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
    
}
