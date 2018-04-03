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
    public partial class wizardRelationships : Form
    {
        Database mydb = null;
       
                
        // Receive DB Name, Database from previous Form
        public wizardRelationships(string dbname, Database db )
        {
            InitializeComponent();
            lblDBName.Text = dbname;
            mydb = db;
                        
            wizardTable wt = null;
            // Search RelationShip Form already active
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].GetType() == typeof(wizardTable))
                    wt = (wizardTable)Application.OpenForms[i];
            }
            if ( wt != null)
                wt.relationRefresh += refreshThis;
            
            wizardTable.ActiveForm.WindowState = FormWindowState.Maximized;
        }

        public void wizardRelationships_Load(object sender, EventArgs e)
        {
            cmbLeftTable.Items.Clear();
            cmbRightTable.Items.Clear();
            // Fill the Combo boxes with each table name
            foreach (TableDef tmptable in mydb.TableDefs)
            {
                if (tmptable.Attributes == 0)
                {
                    cmbLeftTable.Items.Add(tmptable.Name);
                    cmbRightTable.Items.Add(tmptable.Name);
                }
            }
            
        }        
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clean the Combo Box
            cmbLeftField.Items.Clear();
            cmbLeftField.Text = "";

            // Fill the Combo Box according to table selected
            foreach (Field tmpField in mydb.TableDefs[cmbLeftTable.SelectedItem.ToString()].Fields)
            {
                cmbLeftField.Items.Add(tmpField.Name);
            }
        }

        private void cmbRightTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clean the Combo Box
            cmbRightField.Items.Clear();
            cmbRightField.Text = "";

            // Fill the Combo Box according to table selected
            foreach (Field tmpField in mydb.TableDefs[cmbRightTable.SelectedItem.ToString()].Fields)
            {
                cmbRightField.Items.Add(tmpField.Name);
            }
        }

         // To Add the defined relation to Listview after checking is the relation
        // defined is correct
        private void btmAddRelation_Click(object sender, EventArgs e)
        {
            ListViewItem tmpItem = new ListViewItem();

            try
            {
                if (!RelationExist((cmbLeftTable.SelectedItem.ToString() + cmbRightTable.SelectedItem.ToString()))&&
                    !RelationExist((cmbRightTable.SelectedItem.ToString() + cmbLeftTable.SelectedItem.ToString())))
                {
                    tmpItem.SubItems[0].Text = cmbLeftTable.SelectedItem.ToString();
                    tmpItem.SubItems.Add(cmbLeftField.SelectedItem.ToString());
                    tmpItem.SubItems.Add(cmbRightTable.SelectedItem.ToString());
                    tmpItem.SubItems.Add(cmbRightField.SelectedItem.ToString());
                    tmpItem.SubItems.Add(cmbLeftTable.SelectedItem.ToString() + cmbRightTable.SelectedItem.ToString());

                    lstViewRelations.Items.Add(tmpItem);
                    btnSaveRel.Visible = true;
                    btnDeleteRelations.Visible = true;
                }
                else
                    MessageBox.Show("Can't to add the Relation because there is an existing relation between the tables selected", "Imposible create a Relation", MessageBoxButtons.OK, MessageBoxIcon.Error);                          

            }
            catch
            {
                MessageBox.Show("All fields are required to created a relationship", "Combobox empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                        
        }

        // To Add the right relations listed in ListView to DB in a loop 
        private void btnSaveRel_Click(object sender, EventArgs e)
        {
            Relation myRel;
            Field myField , indexfield;
            Index myInd = null;
            TableDef mytdef;
            ListViewItem saveItem = null;
            try
            {
                // Delete all existing relations to avoid conflicts
                DeleteAllRelations(mydb);

                // Read listview and created all relations in DB
                
                foreach (ListViewItem tmp in lstViewRelations.Items)
                {
                    // Save item in case to remove from list view in a catch exception
                    saveItem = tmp;                    

                    /////////////////////////////////////////////////////////////
                    // Create an unique index to make the relation if is not a Primary Key Index
                    /////////////////////////////////////
                    mytdef = mydb.TableDefs[tmp.SubItems[0].Text];
                    //Remove all non Primary Indexes
                    DeleteIndexes(mytdef);
                    myInd = mytdef.CreateIndex("IdxRel" + tmp.SubItems[0].Text + tmp.SubItems[2].Text);
                    myInd.Primary = false;
                    myInd.Unique = true;
                    //////////////////////////////////
                    //Created indexed field
                    indexfield = myInd.CreateField(tmp.SubItems[1].Text);
                    //Add Index field to index
                    ((IndexFields)(myInd.Fields)).Append(indexfield);
                    //Add Index to left table       
                    mytdef.Indexes.Append(myInd);
                    /////////////////////////////////////////////////////////////    

                    // Create the Relation
                    myRel = (Relation)mydb.CreateRelation(tmp.SubItems[0].Text + tmp.SubItems[2].Text,
                                tmp.SubItems[0].Text, tmp.SubItems[2].Text);

                    // Create the Relation's Field
                    myField = myRel.CreateField(tmp.SubItems[1].Text);

                    // Indicate the foreign field that has the relation
                    myField.ForeignName = tmp.SubItems[3].Text;

                    //Add field tu Relation
                    myRel.Fields.Append(myField);

                    //Add relation to DB
                    mydb.Relations.Append(myRel);
                }
                MessageBox.Show("Relations created", "Relations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                saveItem.Remove();
                MessageBox.Show(ex.Message);
            }
        }

        // Delete all created Relations
        public void DeleteAllRelations(Database tmpdb)
        {
            if (tmpdb.Relations.Count > 0)
            {
                for (int i = tmpdb.Relations.Count - 1; i >= 0; i--)
                {
                    tmpdb.Relations.Delete(tmpdb.Relations[i].Name);
                }
            }
            
        }

        // Delete the indexes created
        public void DeleteIndexes(TableDef tmptdef)
        {
            if (tmptdef.Indexes.Count > 1)
            {
                for (int i = tmptdef.Indexes.Count - 1; i >= 1; i--)
                {
                    if (tmptdef.Indexes[tmptdef.Indexes[i].Name].Primary == false)
                        tmptdef.Indexes.Delete(tmptdef.Indexes[i].Name);
                }
            }
        }

        // Check if the Relation Exist in DB
        public bool RelationExist(string relname)
        {
            foreach (ListViewItem tmpitem in lstViewRelations.Items)
            {
                if (relname == (tmpitem.SubItems[0].Text + tmpitem.SubItems[2].Text))
                    return true;
            }
            return false;
        }

        // Delete a Relation selected by the user in the Listview
        private void btnDeleteRelations_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstViewRelations.Items.Count > 0)
                {                 
                    if (mydb.Relations.Count > 0)
                        mydb.Relations.Delete(lstViewRelations.SelectedItems[0].SubItems[0].Text + lstViewRelations.SelectedItems[0].SubItems[2].Text);
                    if (lstViewRelations.SelectedItems.Count > 0)
                        lstViewRelations.Items.Remove(lstViewRelations.SelectedItems[0]);
                }
                if (lstViewRelations.Items.Count == 0)
                    btnDeleteRelations.Visible = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        // Wait for an Event RelationFormUpdateEventArgs to call the Load method to refresh the comboboxes
        // with new information
        public void refreshThis(object sender , wizardTable.RelationFormUpdateEventArgs e)
        {
            if (e.relRefresh == true)
            {
                this.wizardRelationships_Load(null,null);
            }
        }
        private void cmbRightField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void cmbLeftField_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
