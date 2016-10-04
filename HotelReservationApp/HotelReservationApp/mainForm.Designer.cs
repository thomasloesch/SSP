namespace HotelReservationApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboBxRmType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmboBxBedType = new System.Windows.Forms.ComboBox();
            this.cmboBxNumBeds = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radBtnMultiple = new System.Windows.Forms.RadioButton();
            this.radBtnSingle = new System.Windows.Forms.RadioButton();
            this.dataGridViewSSP = new System.Windows.Forms.DataGridView();
            this.roomTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSSPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSSPDataSet = new HotelReservationApp.dbSSPDataSet();
            this.roomTblTableAdapter = new HotelReservationApp.dbSSPDataSetTableAdapters.roomTblTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookedTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookedTblTableAdapter = new HotelReservationApp.dbSSPDataSetTableAdapters.bookedTblTableAdapter();
            this.roomNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRooms = new System.Windows.Forms.Label();
            this.lblBooked = new System.Windows.Forms.Label();
            this.roomIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSSPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSSPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Location = new System.Drawing.Point(6, 70);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFrom.TabIndex = 0;
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Enabled = false;
            this.dateTimeTo.Location = new System.Drawing.Point(6, 109);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimeTo.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room Type";
            // 
            // cmboBxRmType
            // 
            this.cmboBxRmType.BackColor = System.Drawing.Color.White;
            this.cmboBxRmType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxRmType.FormattingEnabled = true;
            this.cmboBxRmType.Items.AddRange(new object[] {
            "None",
            "Standard",
            "Suite",
            "Penthouse"});
            this.cmboBxRmType.Location = new System.Drawing.Point(11, 63);
            this.cmboBxRmType.Name = "cmboBxRmType";
            this.cmboBxRmType.Size = new System.Drawing.Size(111, 21);
            this.cmboBxRmType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of Beds";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dates to Book";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "From";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "To";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(212, 57);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.cmboBxBedType);
            this.groupBox1.Controls.Add(this.cmboBxNumBeds);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmboBxRmType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 143);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Preferences";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(146, 94);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmboBxBedType
            // 
            this.cmboBxBedType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxBedType.FormattingEnabled = true;
            this.cmboBxBedType.Items.AddRange(new object[] {
            "None",
            "Twin",
            "Full",
            "Queen",
            "King"});
            this.cmboBxBedType.Location = new System.Drawing.Point(245, 63);
            this.cmboBxBedType.Name = "cmboBxBedType";
            this.cmboBxBedType.Size = new System.Drawing.Size(111, 21);
            this.cmboBxBedType.TabIndex = 11;
            // 
            // cmboBxNumBeds
            // 
            this.cmboBxNumBeds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBxNumBeds.FormattingEnabled = true;
            this.cmboBxNumBeds.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4"});
            this.cmboBxNumBeds.Location = new System.Drawing.Point(128, 63);
            this.cmboBxNumBeds.Name = "cmboBxNumBeds";
            this.cmboBxNumBeds.Size = new System.Drawing.Size(111, 21);
            this.cmboBxNumBeds.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(47, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Keep \'None\' if no preference";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(242, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Type of Beds";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(212, 12);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 14;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radBtnMultiple);
            this.groupBox2.Controls.Add(this.radBtnSingle);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnCheck);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dateTimeFrom);
            this.groupBox2.Controls.Add(this.btnBook);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dateTimeTo);
            this.groupBox2.Location = new System.Drawing.Point(477, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 143);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Booking";
            // 
            // radBtnMultiple
            // 
            this.radBtnMultiple.AutoSize = true;
            this.radBtnMultiple.Location = new System.Drawing.Point(88, 18);
            this.radBtnMultiple.Name = "radBtnMultiple";
            this.radBtnMultiple.Size = new System.Drawing.Size(88, 17);
            this.radBtnMultiple.TabIndex = 16;
            this.radBtnMultiple.Text = "Multiple Days";
            this.radBtnMultiple.UseVisualStyleBackColor = true;
            this.radBtnMultiple.CheckedChanged += new System.EventHandler(this.radBtnMultiple_CheckedChanged);
            // 
            // radBtnSingle
            // 
            this.radBtnSingle.AutoSize = true;
            this.radBtnSingle.Checked = true;
            this.radBtnSingle.Location = new System.Drawing.Point(6, 18);
            this.radBtnSingle.Name = "radBtnSingle";
            this.radBtnSingle.Size = new System.Drawing.Size(76, 17);
            this.radBtnSingle.TabIndex = 15;
            this.radBtnSingle.TabStop = true;
            this.radBtnSingle.Text = "Single Day";
            this.radBtnSingle.UseVisualStyleBackColor = true;
            this.radBtnSingle.CheckedChanged += new System.EventHandler(this.radBtnSingle_CheckedChanged);
            // 
            // dataGridViewSSP
            // 
            this.dataGridViewSSP.AllowUserToAddRows = false;
            this.dataGridViewSSP.AllowUserToDeleteRows = false;
            this.dataGridViewSSP.AllowUserToResizeColumns = false;
            this.dataGridViewSSP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewSSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSSP.AutoGenerateColumns = false;
            this.dataGridViewSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.bedsDataGridViewTextBoxColumn,
            this.bedTypeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewSSP.DataSource = this.roomTblBindingSource;
            this.dataGridViewSSP.Location = new System.Drawing.Point(14, 176);
            this.dataGridViewSSP.Name = "dataGridViewSSP";
            this.dataGridViewSSP.ReadOnly = true;
            this.dataGridViewSSP.RowHeadersVisible = false;
            this.dataGridViewSSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSSP.Size = new System.Drawing.Size(459, 263);
            this.dataGridViewSSP.TabIndex = 16;
            this.dataGridViewSSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSSP_CellContentClick);
            // 
            // roomTblBindingSource
            // 
            this.roomTblBindingSource.DataMember = "roomTbl";
            this.roomTblBindingSource.DataSource = this.dbSSPDataSetBindingSource;
            // 
            // dbSSPDataSetBindingSource
            // 
            this.dbSSPDataSetBindingSource.DataSource = this.dbSSPDataSet;
            this.dbSSPDataSetBindingSource.Position = 0;
            // 
            // dbSSPDataSet
            // 
            this.dbSSPDataSet.DataSetName = "dbSSPDataSet";
            this.dbSSPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomTblTableAdapter
            // 
            this.roomTblTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomIdDataGridViewTextBoxColumn,
            this.fromDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookedTblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(477, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(315, 263);
            this.dataGridView1.TabIndex = 17;
            // 
            // bookedTblBindingSource
            // 
            this.bookedTblBindingSource.DataMember = "bookedTbl";
            this.bookedTblBindingSource.DataSource = this.dbSSPDataSetBindingSource;
            // 
            // bookedTblTableAdapter
            // 
            this.bookedTblTableAdapter.ClearBeforeFill = true;
            // 
            // roomNumDataGridViewTextBoxColumn
            // 
            this.roomNumDataGridViewTextBoxColumn.DataPropertyName = "RoomNum";
            this.roomNumDataGridViewTextBoxColumn.HeaderText = "Room #";
            this.roomNumDataGridViewTextBoxColumn.Name = "roomNumDataGridViewTextBoxColumn";
            this.roomNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomNumDataGridViewTextBoxColumn.Width = 70;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomTypeDataGridViewTextBoxColumn.Width = 87;
            // 
            // bedsDataGridViewTextBoxColumn
            // 
            this.bedsDataGridViewTextBoxColumn.DataPropertyName = "Beds";
            this.bedsDataGridViewTextBoxColumn.HeaderText = "Beds";
            this.bedsDataGridViewTextBoxColumn.Name = "bedsDataGridViewTextBoxColumn";
            this.bedsDataGridViewTextBoxColumn.ReadOnly = true;
            this.bedsDataGridViewTextBoxColumn.Width = 56;
            // 
            // bedTypeDataGridViewTextBoxColumn
            // 
            this.bedTypeDataGridViewTextBoxColumn.DataPropertyName = "BedType";
            this.bedTypeDataGridViewTextBoxColumn.HeaderText = "Bed Type";
            this.bedTypeDataGridViewTextBoxColumn.Name = "bedTypeDataGridViewTextBoxColumn";
            this.bedTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bedTypeDataGridViewTextBoxColumn.Width = 78;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 56;
            // 
            // lblRooms
            // 
            this.lblRooms.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRooms.Location = new System.Drawing.Point(146, 238);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(194, 139);
            this.lblRooms.TabIndex = 18;
            this.lblRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRooms.Visible = false;
            // 
            // lblBooked
            // 
            this.lblBooked.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBooked.Location = new System.Drawing.Point(537, 238);
            this.lblBooked.Name = "lblBooked";
            this.lblBooked.Size = new System.Drawing.Size(194, 139);
            this.lblBooked.TabIndex = 19;
            this.lblBooked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBooked.Visible = false;
            // 
            // roomIdDataGridViewTextBoxColumn
            // 
            this.roomIdDataGridViewTextBoxColumn.DataPropertyName = "RoomId";
            this.roomIdDataGridViewTextBoxColumn.HeaderText = "Room #";
            this.roomIdDataGridViewTextBoxColumn.Name = "roomIdDataGridViewTextBoxColumn";
            this.roomIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            this.fromDataGridViewTextBoxColumn.HeaderText = "From";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            this.fromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "To";
            this.toDataGridViewTextBoxColumn.HeaderText = "To";
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            this.toDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 453);
            this.Controls.Add(this.lblBooked);
            this.Controls.Add(this.lblRooms);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridViewSSP);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSP Room Reservation";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSSPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSSPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookedTblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmboBxRmType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmboBxBedType;
        private System.Windows.Forms.ComboBox cmboBxNumBeds;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBtnMultiple;
        private System.Windows.Forms.RadioButton radBtnSingle;
        private System.Windows.Forms.DataGridView dataGridViewSSP;
        private System.Windows.Forms.BindingSource dbSSPDataSetBindingSource;
        private dbSSPDataSet dbSSPDataSet;
        private System.Windows.Forms.BindingSource roomTblBindingSource;
        private dbSSPDataSetTableAdapters.roomTblTableAdapter roomTblTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bookedTblBindingSource;
        private dbSSPDataSetTableAdapters.bookedTblTableAdapter bookedTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Label lblBooked;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
    }
}

