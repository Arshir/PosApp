namespace PosAPP.Forms.System_Setup_Form
{
    partial class frmItemSetup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboItemType = new System.Windows.Forms.ComboBox();
            this.txtIssuePerPresentation = new System.Windows.Forms.TextBox();
            this.cboDisable = new System.Windows.Forms.ComboBox();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboStockType = new System.Windows.Forms.ComboBox();
            this.cboIssueUnit = new System.Windows.Forms.ComboBox();
            this.cboPresentation = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAverageCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboManufacture = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboExpirable = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbcItemSetup = new System.Windows.Forms.TabControl();
            this.tbpInitialStock = new System.Windows.Forms.TabPage();
            this.gridInitialStock = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpInventory = new System.Windows.Forms.TabPage();
            this.gridInventoryControl = new System.Windows.Forms.DataGridView();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cboitemCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbcItemSetup.SuspendLayout();
            this.tbpInitialStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInitialStock)).BeginInit();
            this.tbpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInventoryControl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboitemCategory);
            this.groupBox1.Controls.Add(this.cboItemType);
            this.groupBox1.Controls.Add(this.txtIssuePerPresentation);
            this.groupBox1.Controls.Add(this.cboDisable);
            this.groupBox1.Controls.Add(this.cboAge);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(this.cboStockType);
            this.groupBox1.Controls.Add(this.cboIssueUnit);
            this.groupBox1.Controls.Add(this.cboPresentation);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAverageCost);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboManufacture);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboExpirable);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboItemType
            // 
            this.cboItemType.FormattingEnabled = true;
            this.cboItemType.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboItemType.Location = new System.Drawing.Point(494, 19);
            this.cboItemType.Name = "cboItemType";
            this.cboItemType.Size = new System.Drawing.Size(96, 21);
            this.cboItemType.TabIndex = 27;
            // 
            // txtIssuePerPresentation
            // 
            this.txtIssuePerPresentation.Location = new System.Drawing.Point(136, 171);
            this.txtIssuePerPresentation.Name = "txtIssuePerPresentation";
            this.txtIssuePerPresentation.Size = new System.Drawing.Size(100, 20);
            this.txtIssuePerPresentation.TabIndex = 26;
            // 
            // cboDisable
            // 
            this.cboDisable.FormattingEnabled = true;
            this.cboDisable.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboDisable.Location = new System.Drawing.Point(136, 260);
            this.cboDisable.Name = "cboDisable";
            this.cboDisable.Size = new System.Drawing.Size(69, 21);
            this.cboDisable.TabIndex = 25;
            // 
            // cboAge
            // 
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Location = new System.Drawing.Point(500, 214);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(107, 21);
            this.cboAge.TabIndex = 24;
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Location = new System.Drawing.Point(136, 214);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(141, 21);
            this.cboGender.TabIndex = 23;
            // 
            // cboStockType
            // 
            this.cboStockType.FormattingEnabled = true;
            this.cboStockType.Items.AddRange(new object[] {
            "STOCK",
            "NON-STOCK"});
            this.cboStockType.Location = new System.Drawing.Point(497, 171);
            this.cboStockType.Name = "cboStockType";
            this.cboStockType.Size = new System.Drawing.Size(93, 21);
            this.cboStockType.TabIndex = 22;
            // 
            // cboIssueUnit
            // 
            this.cboIssueUnit.FormattingEnabled = true;
            this.cboIssueUnit.Location = new System.Drawing.Point(497, 134);
            this.cboIssueUnit.Name = "cboIssueUnit";
            this.cboIssueUnit.Size = new System.Drawing.Size(110, 21);
            this.cboIssueUnit.TabIndex = 20;
            // 
            // cboPresentation
            // 
            this.cboPresentation.FormattingEnabled = true;
            this.cboPresentation.Location = new System.Drawing.Point(136, 134);
            this.cboPresentation.Name = "cboPresentation";
            this.cboPresentation.Size = new System.Drawing.Size(141, 21);
            this.cboPresentation.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(78, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Disable:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(411, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Age Category:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Gender Category:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Stock Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Issue Unit /Presentation:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Issue Unit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Presentation Unit:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtAverageCost
            // 
            this.txtAverageCost.Location = new System.Drawing.Point(497, 95);
            this.txtAverageCost.Name = "txtAverageCost";
            this.txtAverageCost.Size = new System.Drawing.Size(96, 20);
            this.txtAverageCost.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Average Cost:";
            // 
            // cboManufacture
            // 
            this.cboManufacture.FormattingEnabled = true;
            this.cboManufacture.Location = new System.Drawing.Point(136, 92);
            this.cboManufacture.Name = "cboManufacture";
            this.cboManufacture.Size = new System.Drawing.Size(141, 21);
            this.cboManufacture.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Manufacture:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(136, 55);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(205, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description:";
            // 
            // cboExpirable
            // 
            this.cboExpirable.FormattingEnabled = true;
            this.cboExpirable.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboExpirable.Location = new System.Drawing.Point(494, 56);
            this.cboExpirable.Name = "cboExpirable";
            this.cboExpirable.Size = new System.Drawing.Size(96, 21);
            this.cboExpirable.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expirable:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Category:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbcItemSetup);
            this.groupBox2.Location = new System.Drawing.Point(12, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbcItemSetup
            // 
            this.tbcItemSetup.Controls.Add(this.tbpInitialStock);
            this.tbcItemSetup.Controls.Add(this.tbpInventory);
            this.tbcItemSetup.Location = new System.Drawing.Point(0, 10);
            this.tbcItemSetup.Name = "tbcItemSetup";
            this.tbcItemSetup.SelectedIndex = 0;
            this.tbcItemSetup.Size = new System.Drawing.Size(624, 122);
            this.tbcItemSetup.TabIndex = 0;
            // 
            // tbpInitialStock
            // 
            this.tbpInitialStock.Controls.Add(this.gridInitialStock);
            this.tbpInitialStock.Location = new System.Drawing.Point(4, 22);
            this.tbpInitialStock.Name = "tbpInitialStock";
            this.tbpInitialStock.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInitialStock.Size = new System.Drawing.Size(616, 96);
            this.tbpInitialStock.TabIndex = 0;
            this.tbpInitialStock.Text = "Initial Stock";
            this.tbpInitialStock.UseVisualStyleBackColor = true;
            // 
            // gridInitialStock
            // 
            this.gridInitialStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInitialStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.gridInitialStock.Location = new System.Drawing.Point(-4, 0);
            this.gridInitialStock.Name = "gridInitialStock";
            this.gridInitialStock.Size = new System.Drawing.Size(620, 84);
            this.gridInitialStock.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Store";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Stock Level";
            this.Column2.Name = "Column2";
            this.Column2.Width = 87;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Batch #";
            this.Column3.Name = "Column3";
            this.Column3.Width = 68;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column4.HeaderText = "Expiry Date";
            this.Column4.Name = "Column4";
            this.Column4.Width = 86;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.HeaderText = "Unit Cost";
            this.Column5.Name = "Column5";
            this.Column5.Width = 75;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Suppliers";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column7.HeaderText = "StoreID";
            this.Column7.Name = "Column7";
            this.Column7.Width = 68;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column8.HeaderText = "ItemID";
            this.Column8.Name = "Column8";
            this.Column8.Width = 63;
            // 
            // tbpInventory
            // 
            this.tbpInventory.Controls.Add(this.gridInventoryControl);
            this.tbpInventory.Location = new System.Drawing.Point(4, 22);
            this.tbpInventory.Name = "tbpInventory";
            this.tbpInventory.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInventory.Size = new System.Drawing.Size(616, 96);
            this.tbpInventory.TabIndex = 1;
            this.tbpInventory.Text = "Inventory Control Setup";
            this.tbpInventory.UseVisualStyleBackColor = true;
            // 
            // gridInventoryControl
            // 
            this.gridInventoryControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInventoryControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewComboBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gridInventoryControl.Location = new System.Drawing.Point(-2, 3);
            this.gridInventoryControl.Name = "gridInventoryControl";
            this.gridInventoryControl.Size = new System.Drawing.Size(620, 97);
            this.gridInventoryControl.TabIndex = 1;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.HeaderText = "Store";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "Reorder Level";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 91;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "Lead Time(Days)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 103;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "Demand(Per Day)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 106;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn4.HeaderText = "EOQ";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 55;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewComboBoxColumn2.HeaderText = "Minimum Level";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn2.Width = 94;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.HeaderText = "Maximum Level";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 96;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.HeaderText = "StoreID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 68;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 462);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(435, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(554, 462);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Pricing";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // cboitemCategory
            // 
            this.cboitemCategory.FormattingEnabled = true;
            this.cboitemCategory.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboitemCategory.Location = new System.Drawing.Point(136, 19);
            this.cboitemCategory.Name = "cboitemCategory";
            this.cboitemCategory.Size = new System.Drawing.Size(96, 21);
            this.cboitemCategory.TabIndex = 28;
            this.cboitemCategory.DropDown += new System.EventHandler(this.cboitemCategory_DropDown);
            // 
            // frmItemSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(648, 485);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmItemSetup";
            this.Text = "Item Setup";
            this.Load += new System.EventHandler(this.frmItemSetup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tbcItemSetup.ResumeLayout(false);
            this.tbpInitialStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInitialStock)).EndInit();
            this.tbpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInventoryControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAverageCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboManufacture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboExpirable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDisable;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboStockType;
        private System.Windows.Forms.ComboBox cboIssueUnit;
        private System.Windows.Forms.ComboBox cboPresentation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIssuePerPresentation;
        private System.Windows.Forms.TabControl tbcItemSetup;
        private System.Windows.Forms.TabPage tbpInitialStock;
        private System.Windows.Forms.TabPage tbpInventory;
        private System.Windows.Forms.DataGridView gridInitialStock;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridView gridInventoryControl;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cboItemType;
        private System.Windows.Forms.ComboBox cboitemCategory;
    }
}