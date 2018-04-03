namespace miniAccess2018_V1_0
{
    partial class wizardRelationships
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wizardRelationships));
            this.lblDBName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLeftTable = new System.Windows.Forms.ComboBox();
            this.cmbRightTable = new System.Windows.Forms.ComboBox();
            this.cmbRightField = new System.Windows.Forms.ComboBox();
            this.cmbLeftField = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btmAddRelation = new System.Windows.Forms.Button();
            this.lstViewRelations = new System.Windows.Forms.ListView();
            this.colLeftTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLeftField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRightTable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRightField = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRelationName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSaveRel = new System.Windows.Forms.Button();
            this.btnDeleteRelations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDBName
            // 
            this.lblDBName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDBName.AutoSize = true;
            this.lblDBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBName.ForeColor = System.Drawing.Color.Wheat;
            this.lblDBName.Location = new System.Drawing.Point(159, 16);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(98, 24);
            this.lblDBName.TabIndex = 7;
            this.lblDBName.Text = "DB Name";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(10, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Left Table";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(229, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Right Table";
            // 
            // cmbLeftTable
            // 
            this.cmbLeftTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLeftTable.Font = new System.Drawing.Font("Dubai", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLeftTable.FormattingEnabled = true;
            this.cmbLeftTable.Location = new System.Drawing.Point(97, 62);
            this.cmbLeftTable.Name = "cmbLeftTable";
            this.cmbLeftTable.Size = new System.Drawing.Size(126, 33);
            this.cmbLeftTable.TabIndex = 10;
            this.cmbLeftTable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbRightTable
            // 
            this.cmbRightTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRightTable.Font = new System.Drawing.Font("Dubai", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRightTable.FormattingEnabled = true;
            this.cmbRightTable.Location = new System.Drawing.Point(326, 62);
            this.cmbRightTable.Name = "cmbRightTable";
            this.cmbRightTable.Size = new System.Drawing.Size(126, 33);
            this.cmbRightTable.TabIndex = 11;
            this.cmbRightTable.SelectedIndexChanged += new System.EventHandler(this.cmbRightTable_SelectedIndexChanged);
            // 
            // cmbRightField
            // 
            this.cmbRightField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbRightField.Font = new System.Drawing.Font("Dubai", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRightField.FormattingEnabled = true;
            this.cmbRightField.Location = new System.Drawing.Point(326, 102);
            this.cmbRightField.Name = "cmbRightField";
            this.cmbRightField.Size = new System.Drawing.Size(126, 33);
            this.cmbRightField.TabIndex = 15;
            this.cmbRightField.SelectedIndexChanged += new System.EventHandler(this.cmbRightField_SelectedIndexChanged);
            // 
            // cmbLeftField
            // 
            this.cmbLeftField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbLeftField.Font = new System.Drawing.Font("Dubai", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLeftField.FormattingEnabled = true;
            this.cmbLeftField.Location = new System.Drawing.Point(97, 104);
            this.cmbLeftField.Name = "cmbLeftField";
            this.cmbLeftField.Size = new System.Drawing.Size(126, 33);
            this.cmbLeftField.TabIndex = 14;
            this.cmbLeftField.SelectedIndexChanged += new System.EventHandler(this.cmbLeftField_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Wheat;
            this.label3.Location = new System.Drawing.Point(229, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Right Field";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Wheat;
            this.label4.Location = new System.Drawing.Point(10, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Left Field";
            // 
            // btmAddRelation
            // 
            this.btmAddRelation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmAddRelation.Font = new System.Drawing.Font("Dubai", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmAddRelation.Location = new System.Drawing.Point(15, 152);
            this.btmAddRelation.Name = "btmAddRelation";
            this.btmAddRelation.Size = new System.Drawing.Size(99, 31);
            this.btmAddRelation.TabIndex = 16;
            this.btmAddRelation.Text = "Add Relation";
            this.btmAddRelation.UseVisualStyleBackColor = true;
            this.btmAddRelation.Click += new System.EventHandler(this.btmAddRelation_Click);
            // 
            // lstViewRelations
            // 
            this.lstViewRelations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstViewRelations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLeftTable,
            this.colLeftField,
            this.colRightTable,
            this.colRightField,
            this.colRelationName});
            this.lstViewRelations.Font = new System.Drawing.Font("Dubai", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstViewRelations.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstViewRelations.FullRowSelect = true;
            this.lstViewRelations.GridLines = true;
            this.lstViewRelations.Location = new System.Drawing.Point(15, 189);
            this.lstViewRelations.MultiSelect = false;
            this.lstViewRelations.Name = "lstViewRelations";
            this.lstViewRelations.Size = new System.Drawing.Size(437, 190);
            this.lstViewRelations.TabIndex = 17;
            this.lstViewRelations.UseCompatibleStateImageBehavior = false;
            this.lstViewRelations.View = System.Windows.Forms.View.Details;
            // 
            // colLeftTable
            // 
            this.colLeftTable.Text = "Left Table";
            this.colLeftTable.Width = 85;
            // 
            // colLeftField
            // 
            this.colLeftField.Text = "LeftField";
            this.colLeftField.Width = 85;
            // 
            // colRightTable
            // 
            this.colRightTable.Text = "Right Table";
            this.colRightTable.Width = 85;
            // 
            // colRightField
            // 
            this.colRightField.Text = "Right Field";
            this.colRightField.Width = 85;
            // 
            // colRelationName
            // 
            this.colRelationName.Text = "Rel. Name";
            this.colRelationName.Width = 85;
            // 
            // btnSaveRel
            // 
            this.btnSaveRel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveRel.Font = new System.Drawing.Font("Dubai", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRel.Location = new System.Drawing.Point(326, 152);
            this.btnSaveRel.Name = "btnSaveRel";
            this.btnSaveRel.Size = new System.Drawing.Size(126, 31);
            this.btnSaveRel.TabIndex = 18;
            this.btnSaveRel.Text = "Save Relations";
            this.btnSaveRel.UseVisualStyleBackColor = true;
            this.btnSaveRel.Visible = false;
            this.btnSaveRel.Click += new System.EventHandler(this.btnSaveRel_Click);
            // 
            // btnDeleteRelations
            // 
            this.btnDeleteRelations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteRelations.Font = new System.Drawing.Font("Dubai", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRelations.Location = new System.Drawing.Point(154, 152);
            this.btnDeleteRelations.Name = "btnDeleteRelations";
            this.btnDeleteRelations.Size = new System.Drawing.Size(128, 31);
            this.btnDeleteRelations.TabIndex = 19;
            this.btnDeleteRelations.Text = "Delete Relation";
            this.btnDeleteRelations.UseVisualStyleBackColor = true;
            this.btnDeleteRelations.Visible = false;
            this.btnDeleteRelations.Click += new System.EventHandler(this.btnDeleteRelations_Click);
            // 
            // wizardRelationships
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(468, 393);
            this.Controls.Add(this.btnDeleteRelations);
            this.Controls.Add(this.btnSaveRel);
            this.Controls.Add(this.lstViewRelations);
            this.Controls.Add(this.btmAddRelation);
            this.Controls.Add(this.cmbRightField);
            this.Controls.Add(this.cmbLeftField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRightTable);
            this.Controls.Add(this.cmbLeftTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDBName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "wizardRelationships";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Table\'s Relationships";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.wizardRelationships_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLeftTable;
        private System.Windows.Forms.ComboBox cmbRightTable;
        private System.Windows.Forms.ComboBox cmbRightField;
        private System.Windows.Forms.ComboBox cmbLeftField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmAddRelation;
        private System.Windows.Forms.ListView lstViewRelations;
        private System.Windows.Forms.ColumnHeader colLeftTable;
        private System.Windows.Forms.ColumnHeader colLeftField;
        private System.Windows.Forms.ColumnHeader colRightTable;
        private System.Windows.Forms.ColumnHeader colRightField;
        private System.Windows.Forms.Button btnSaveRel;
        private System.Windows.Forms.Button btnDeleteRelations;
        private System.Windows.Forms.ColumnHeader colRelationName;
    }
}