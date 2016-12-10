namespace UHAC4._0
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCLose = new System.Windows.Forms.Button();
            this.openTimer = new System.Windows.Forms.Timer(this.components);
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cboCourse = new MetroFramework.Controls.MetroComboBox();
            this.btnAddStudent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnClearFields = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.txtStudentNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboGender = new MetroFramework.Controls.MetroComboBox();
            this.cboYearAndSection = new MetroFramework.Controls.MetroComboBox();
            this.txtGuardianName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtGuardianValidContactNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboChooseOption = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnScanNFC = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.txtNFCSerialNumber = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtStudentFullName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 17F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Student Information";
            // 
            // btnCLose
            // 
            this.btnCLose.BackColor = System.Drawing.Color.Transparent;
            this.btnCLose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCLose.BackgroundImage")));
            this.btnCLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCLose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCLose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCLose.FlatAppearance.BorderSize = 0;
            this.btnCLose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLose.Location = new System.Drawing.Point(0, 0);
            this.btnCLose.Name = "btnCLose";
            this.btnCLose.Size = new System.Drawing.Size(60, 60);
            this.btnCLose.TabIndex = 24;
            this.btnCLose.UseVisualStyleBackColor = false;
            this.btnCLose.Click += new System.EventHandler(this.btnCLose_Click);
            // 
            // openTimer
            // 
            this.openTimer.Interval = 1;
            this.openTimer.Tick += new System.EventHandler(this.openTimer_Tick);
            // 
            // closeTimer
            // 
            this.closeTimer.Interval = 1;
            this.closeTimer.Tick += new System.EventHandler(this.closeTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCLose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 60);
            this.panel1.TabIndex = 37;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-3, 70);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(625, 10);
            this.materialDivider1.TabIndex = 40;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // cboCourse
            // 
            this.cboCourse.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.ItemHeight = 19;
            this.cboCourse.Items.AddRange(new object[] {
            "BSIT",
            "ASCT",
            "TRM",
            "HRS",
            "HRM",
            "BM"});
            this.cboCourse.Location = new System.Drawing.Point(35, 276);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.PromptText = "Course";
            this.cboCourse.Size = new System.Drawing.Size(365, 25);
            this.cboCourse.TabIndex = 55;
            this.metroToolTip1.SetToolTip(this.cboCourse, "Product Sub-Category.");
            this.cboCourse.UseSelectable = true;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.AutoSize = true;
            this.btnAddStudent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddStudent.Depth = 0;
            this.btnAddStudent.Icon = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Icon")));
            this.btnAddStudent.Location = new System.Drawing.Point(241, 550);
            this.btnAddStudent.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Primary = true;
            this.btnAddStudent.Size = new System.Drawing.Size(140, 36);
            this.btnAddStudent.TabIndex = 62;
            this.btnAddStudent.Text = "Add Student";
            this.metroToolTip1.SetToolTip(this.btnAddStudent, "Add Product to Inventory.");
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.AutoSize = true;
            this.btnClearFields.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearFields.Depth = 0;
            this.btnClearFields.Icon = ((System.Drawing.Image)(resources.GetObject("btnClearFields.Icon")));
            this.btnClearFields.Location = new System.Drawing.Point(242, 498);
            this.btnClearFields.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Primary = true;
            this.btnClearFields.Size = new System.Drawing.Size(138, 36);
            this.btnClearFields.TabIndex = 63;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Depth = 0;
            this.txtStudentNumber.Hint = "Student Number";
            this.txtStudentNumber.Location = new System.Drawing.Point(35, 178);
            this.txtStudentNumber.MaxLength = 32767;
            this.txtStudentNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.PasswordChar = '\0';
            this.txtStudentNumber.SelectedText = "";
            this.txtStudentNumber.SelectionLength = 0;
            this.txtStudentNumber.SelectionStart = 0;
            this.txtStudentNumber.Size = new System.Drawing.Size(365, 23);
            this.txtStudentNumber.TabIndex = 41;
            this.txtStudentNumber.TabStop = false;
            this.metroToolTip1.SetToolTip(this.txtStudentNumber, "Product Description.");
            this.txtStudentNumber.UseSystemPasswordChar = false;
            // 
            // cboGender
            // 
            this.cboGender.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.ItemHeight = 19;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(36, 229);
            this.cboGender.Name = "cboGender";
            this.cboGender.PromptText = "Gender";
            this.cboGender.Size = new System.Drawing.Size(364, 25);
            this.cboGender.TabIndex = 66;
            this.metroToolTip1.SetToolTip(this.cboGender, "Product Category");
            this.cboGender.UseSelectable = true;
            // 
            // cboYearAndSection
            // 
            this.cboYearAndSection.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboYearAndSection.FormattingEnabled = true;
            this.cboYearAndSection.ItemHeight = 19;
            this.cboYearAndSection.Items.AddRange(new object[] {
            "1.1 A",
            "1.2 A",
            "1.1 B",
            "1.2 B",
            "2.1 A",
            "2.2 A",
            "2.1 B",
            "2.2 B",
            "3.1 A",
            "3.2 A",
            "3.1 B",
            "3.2 B",
            "4.1 A",
            "4.2 A",
            "4.1 B",
            "4.2 B"});
            this.cboYearAndSection.Location = new System.Drawing.Point(36, 328);
            this.cboYearAndSection.Name = "cboYearAndSection";
            this.cboYearAndSection.PromptText = "Year / Section";
            this.cboYearAndSection.Size = new System.Drawing.Size(365, 25);
            this.cboYearAndSection.TabIndex = 68;
            this.metroToolTip1.SetToolTip(this.cboYearAndSection, "Product Sub-Category.");
            this.cboYearAndSection.UseSelectable = true;
            // 
            // txtGuardianName
            // 
            this.txtGuardianName.Depth = 0;
            this.txtGuardianName.Hint = "Guardian Name";
            this.txtGuardianName.Location = new System.Drawing.Point(36, 386);
            this.txtGuardianName.MaxLength = 32767;
            this.txtGuardianName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGuardianName.Name = "txtGuardianName";
            this.txtGuardianName.PasswordChar = '\0';
            this.txtGuardianName.SelectedText = "";
            this.txtGuardianName.SelectionLength = 0;
            this.txtGuardianName.SelectionStart = 0;
            this.txtGuardianName.Size = new System.Drawing.Size(365, 23);
            this.txtGuardianName.TabIndex = 70;
            this.txtGuardianName.TabStop = false;
            this.metroToolTip1.SetToolTip(this.txtGuardianName, "Product Description.");
            this.txtGuardianName.UseSystemPasswordChar = false;
            // 
            // txtGuardianValidContactNumber
            // 
            this.txtGuardianValidContactNumber.Depth = 0;
            this.txtGuardianValidContactNumber.Hint = "Guardian Valid Contact Number";
            this.txtGuardianValidContactNumber.Location = new System.Drawing.Point(35, 442);
            this.txtGuardianValidContactNumber.MaxLength = 32767;
            this.txtGuardianValidContactNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGuardianValidContactNumber.Name = "txtGuardianValidContactNumber";
            this.txtGuardianValidContactNumber.PasswordChar = '\0';
            this.txtGuardianValidContactNumber.SelectedText = "";
            this.txtGuardianValidContactNumber.SelectionLength = 0;
            this.txtGuardianValidContactNumber.SelectionStart = 0;
            this.txtGuardianValidContactNumber.Size = new System.Drawing.Size(365, 23);
            this.txtGuardianValidContactNumber.TabIndex = 72;
            this.txtGuardianValidContactNumber.TabStop = false;
            this.metroToolTip1.SetToolTip(this.txtGuardianValidContactNumber, "Product Description.");
            this.txtGuardianValidContactNumber.UseSystemPasswordChar = false;
            // 
            // cboChooseOption
            // 
            this.cboChooseOption.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboChooseOption.FormattingEnabled = true;
            this.cboChooseOption.ItemHeight = 19;
            this.cboChooseOption.Items.AddRange(new object[] {
            "Choose a Picture"});
            this.cboChooseOption.Location = new System.Drawing.Point(430, 254);
            this.cboChooseOption.Name = "cboChooseOption";
            this.cboChooseOption.PromptText = "Choose Options";
            this.cboChooseOption.Size = new System.Drawing.Size(169, 25);
            this.cboChooseOption.TabIndex = 74;
            this.metroToolTip1.SetToolTip(this.cboChooseOption, "Product Category");
            this.cboChooseOption.UseSelectable = true;
            this.cboChooseOption.SelectedIndexChanged += new System.EventHandler(this.cboChooseOption_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(-1, 271);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.TabIndex = 54;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(0, 323);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 67;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(0, 379);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.TabIndex = 69;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(-1, 435);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.TabIndex = 71;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox8.Location = new System.Drawing.Point(430, 103);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(169, 151);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 73;
            this.pictureBox8.TabStop = false;
            // 
            // btnScanNFC
            // 
            this.btnScanNFC.AutoSize = true;
            this.btnScanNFC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnScanNFC.Depth = 0;
            this.btnScanNFC.Icon = ((System.Drawing.Image)(resources.GetObject("btnScanNFC.Icon")));
            this.btnScanNFC.Location = new System.Drawing.Point(359, 124);
            this.btnScanNFC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnScanNFC.Name = "btnScanNFC";
            this.btnScanNFC.Primary = true;
            this.btnScanNFC.Size = new System.Drawing.Size(44, 36);
            this.btnScanNFC.TabIndex = 77;
            this.btnScanNFC.UseVisualStyleBackColor = true;
            this.btnScanNFC.Click += new System.EventHandler(this.btnScanNFC_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox9.BackgroundImage")));
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(-1, 129);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(30, 30);
            this.pictureBox9.TabIndex = 79;
            this.pictureBox9.TabStop = false;
            // 
            // txtNFCSerialNumber
            // 
            this.txtNFCSerialNumber.Depth = 0;
            this.txtNFCSerialNumber.Hint = "NFC Serial Number";
            this.txtNFCSerialNumber.Location = new System.Drawing.Point(35, 137);
            this.txtNFCSerialNumber.MaxLength = 32767;
            this.txtNFCSerialNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNFCSerialNumber.Name = "txtNFCSerialNumber";
            this.txtNFCSerialNumber.PasswordChar = '\0';
            this.txtNFCSerialNumber.SelectedText = "";
            this.txtNFCSerialNumber.SelectionLength = 0;
            this.txtNFCSerialNumber.SelectionStart = 0;
            this.txtNFCSerialNumber.Size = new System.Drawing.Size(318, 23);
            this.txtNFCSerialNumber.TabIndex = 78;
            this.txtNFCSerialNumber.TabStop = false;
            this.metroToolTip1.SetToolTip(this.txtNFCSerialNumber, "Product Description.");
            this.txtNFCSerialNumber.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // txtStudentFullName
            // 
            this.txtStudentFullName.Depth = 0;
            this.txtStudentFullName.Hint = "Student Full Name";
            this.txtStudentFullName.Location = new System.Drawing.Point(35, 95);
            this.txtStudentFullName.MaxLength = 32767;
            this.txtStudentFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStudentFullName.Name = "txtStudentFullName";
            this.txtStudentFullName.PasswordChar = '\0';
            this.txtStudentFullName.SelectedText = "";
            this.txtStudentFullName.SelectionLength = 0;
            this.txtStudentFullName.SelectionStart = 0;
            this.txtStudentFullName.Size = new System.Drawing.Size(365, 23);
            this.txtStudentFullName.TabIndex = 80;
            this.txtStudentFullName.TabStop = false;
            this.metroToolTip1.SetToolTip(this.txtStudentFullName, "Product Name.");
            this.txtStudentFullName.UseSystemPasswordChar = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(623, 598);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtStudentFullName);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.txtNFCSerialNumber);
            this.Controls.Add(this.cboChooseOption);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.txtGuardianValidContactNumber);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txtGuardianName);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.cboYearAndSection);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.cboCourse);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnScanNFC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(623, 598);
            this.MinimumSize = new System.Drawing.Size(623, 598);
            this.Name = "AddStudent";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAccount";
            this.Load += new System.EventHandler(this.ManageAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCLose;
        public System.Windows.Forms.Timer openTimer;
        private System.Windows.Forms.Timer closeTimer;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroComboBox cboCourse;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddStudent;
        private MaterialSkin.Controls.MaterialRaisedButton btnClearFields;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStudentNumber;
        private MetroFramework.Controls.MetroComboBox cboGender;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MetroFramework.Controls.MetroComboBox cboYearAndSection;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGuardianName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGuardianValidContactNumber;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private MetroFramework.Controls.MetroComboBox cboChooseOption;
        private MaterialSkin.Controls.MaterialRaisedButton btnScanNFC;
        private System.Windows.Forms.PictureBox pictureBox9;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNFCSerialNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtStudentFullName;
    }
}