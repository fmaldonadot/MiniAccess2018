namespace miniAccess2018_V1_0
{
    partial class wizardTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wizardTable));
            this.treeTables = new System.Windows.Forms.TreeView();
            this.btnAddTname = new System.Windows.Forms.Button();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFields = new System.Windows.Forms.TabPage();
            this.dGridFields1 = new System.Windows.Forms.DataGridView();
            this.Key = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabcontFields = new System.Windows.Forms.TabControl();
            this.lblDBName = new System.Windows.Forms.Label();
            this.btnCreateTables = new System.Windows.Forms.Button();
            this.btnGoRelations = new System.Windows.Forms.Button();
            this.tabFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridFields1)).BeginInit();
            this.tabcontFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeTables
            // 
            this.treeTables.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeTables.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.treeTables.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeTables.Indent = 30;
            this.treeTables.Location = new System.Drawing.Point(14, 149);
            this.treeTables.Name = "treeTables";
            this.treeTables.ShowLines = false;
            this.treeTables.ShowPlusMinus = false;
            this.treeTables.ShowRootLines = false;
            this.treeTables.Size = new System.Drawing.Size(203, 151);
            this.treeTables.TabIndex = 0;
            this.treeTables.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeTables_AfterSelect);
            // 
            // btnAddTname
            // 
            this.btnAddTname.AutoSize = true;
            this.btnAddTname.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddTname.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTname.Location = new System.Drawing.Point(15, 107);
            this.btnAddTname.Name = "btnAddTname";
            this.btnAddTname.Size = new System.Drawing.Size(80, 34);
            this.btnAddTname.TabIndex = 3;
            this.btnAddTname.Text = "Add Name";
            this.btnAddTname.UseVisualStyleBackColor = true;
            this.btnAddTname.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // txtTableName
            // 
            this.txtTableName.AllowDrop = true;
            this.txtTableName.BackColor = System.Drawing.SystemColors.Window;
            this.txtTableName.Location = new System.Drawing.Point(15, 81);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(146, 20);
            this.txtTableName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Table Name:";
            // 
            // tabFields
            // 
            this.tabFields.AutoScroll = true;
            this.tabFields.Controls.Add(this.dGridFields1);
            this.tabFields.Location = new System.Drawing.Point(4, 22);
            this.tabFields.Name = "tabFields";
            this.tabFields.Padding = new System.Windows.Forms.Padding(3);
            this.tabFields.Size = new System.Drawing.Size(367, 149);
            this.tabFields.TabIndex = 0;
            this.tabFields.Text = "tabPage1";
            this.tabFields.UseVisualStyleBackColor = true;
            // 
            // dGridFields1
            // 
            this.dGridFields1.AllowDrop = true;
            this.dGridFields1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dGridFields1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGridFields1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGridFields1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGridFields1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGridFields1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGridFields1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGridFields1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Key,
            this.colField,
            this.colDataType,
            this.colDescription});
            this.dGridFields1.Location = new System.Drawing.Point(0, 0);
            this.dGridFields1.Name = "dGridFields1";
            this.dGridFields1.Size = new System.Drawing.Size(364, 153);
            this.dGridFields1.TabIndex = 0;
            this.dGridFields1.Visible = false;
            this.dGridFields1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridFields_CellContentClick);
            // 
            // Key
            // 
            this.Key.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Key.FalseValue = "false";
            this.Key.HeaderText = "PK";
            this.Key.Name = "Key";
            this.Key.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Key.TrueValue = "true";
            this.Key.Width = 46;
            // 
            // colField
            // 
            this.colField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colField.HeaderText = "Field Name";
            this.colField.Name = "colField";
            this.colField.Width = 85;
            // 
            // colDataType
            // 
            this.colDataType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDataType.HeaderText = "Data Type";
            this.colDataType.Name = "colDataType";
            this.colDataType.Width = 63;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            // 
            // tabcontFields
            // 
            this.tabcontFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcontFields.Controls.Add(this.tabFields);
            this.tabcontFields.Enabled = false;
            this.tabcontFields.Location = new System.Drawing.Point(225, 125);
            this.tabcontFields.Name = "tabcontFields";
            this.tabcontFields.SelectedIndex = 0;
            this.tabcontFields.Size = new System.Drawing.Size(375, 175);
            this.tabcontFields.TabIndex = 2;
            // 
            // lblDBName
            // 
            this.lblDBName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDBName.AutoSize = true;
            this.lblDBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBName.ForeColor = System.Drawing.Color.Wheat;
            this.lblDBName.Location = new System.Drawing.Point(195, 20);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(98, 24);
            this.lblDBName.TabIndex = 6;
            this.lblDBName.Text = "DB Name";
            this.lblDBName.Click += new System.EventHandler(this.lblDBName_Click);
            // 
            // btnCreateTables
            // 
            this.btnCreateTables.AutoSize = true;
            this.btnCreateTables.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateTables.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTables.Location = new System.Drawing.Point(225, 81);
            this.btnCreateTables.Name = "btnCreateTables";
            this.btnCreateTables.Size = new System.Drawing.Size(97, 34);
            this.btnCreateTables.TabIndex = 7;
            this.btnCreateTables.Text = "Create Tables";
            this.btnCreateTables.UseVisualStyleBackColor = true;
            this.btnCreateTables.Click += new System.EventHandler(this.btnCreateTables_Click);
            // 
            // btnGoRelations
            // 
            this.btnGoRelations.AutoSize = true;
            this.btnGoRelations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGoRelations.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoRelations.Location = new System.Drawing.Point(482, 85);
            this.btnGoRelations.Name = "btnGoRelations";
            this.btnGoRelations.Size = new System.Drawing.Size(111, 34);
            this.btnGoRelations.TabIndex = 8;
            this.btnGoRelations.Text = "Relationships>>";
            this.btnGoRelations.UseVisualStyleBackColor = true;
            this.btnGoRelations.Visible = false;
            this.btnGoRelations.Click += new System.EventHandler(this.btnGoRelations_Click);
            // 
            // wizardTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(612, 312);
            this.Controls.Add(this.btnGoRelations);
            this.Controls.Add(this.btnCreateTables);
            this.Controls.Add(this.lblDBName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.btnAddTname);
            this.Controls.Add(this.tabcontFields);
            this.Controls.Add(this.treeTables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "wizardTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create DB Tables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.wizardTable_Load);
            this.tabFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGridFields1)).EndInit();
            this.tabcontFields.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeTables;
        private System.Windows.Forms.Button btnAddTname;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabcontFields;
        public System.Windows.Forms.TabPage tabFields;
        public System.Windows.Forms.DataGridView dGridFields1;
        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.Button btnCreateTables;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn colField;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.Button btnGoRelations;
    }
}