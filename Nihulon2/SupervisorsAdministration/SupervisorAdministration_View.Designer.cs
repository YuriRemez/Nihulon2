namespace Nihulon2.SupervisorsAdministration
{
    partial class SupervisorAdministration_View
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupervisorAdministration_View));
            this.dgvExamTable = new System.Windows.Forms.DataGridView();
            this.txt_Comments = new System.Windows.Forms.TextBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_ExportToExcel = new System.Windows.Forms.Button();
            this.btn_ImportFromExcel = new System.Windows.Forms.Button();
            this.btn_CopyRow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom_Filter = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo_Filter = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.txtDiscipline_NewExam = new System.Windows.Forms.TextBox();
            this.pnlAddingForm = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClearAddingForm = new System.Windows.Forms.Button();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbExtraTime_NewExam = new System.Windows.Forms.CheckBox();
            this.ToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cboCourse_NewExam = new System.Windows.Forms.ComboBox();
            this.txtSupervisor_NewExam = new System.Windows.Forms.TextBox();
            this.txtGroup_NewExam = new System.Windows.Forms.TextBox();
            this.cboRoom_NewExam = new System.Windows.Forms.ComboBox();
            this.cboDivision_NewExam = new System.Windows.Forms.ComboBox();
            this.lbl_CourseFilter = new System.Windows.Forms.Label();
            this.lbl_DivisionFilter = new System.Windows.Forms.Label();
            this.lblRoomFilter = new System.Windows.Forms.Label();
            this.cbShowDisabledExams = new System.Windows.Forms.CheckBox();
            this.cboDivisionFilter = new System.Windows.Forms.ComboBox();
            this.cboCourseFilter = new System.Windows.Forms.ComboBox();
            this.cboRoomFilter = new System.Windows.Forms.ComboBox();
            this.btnChangeExam = new System.Windows.Forms.Button();
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerOneDay_Filter = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonShowNew = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.btnShowExams = new System.Windows.Forms.Button();
            this.radioButtonShowAll = new System.Windows.Forms.RadioButton();
            this.radioButtonPeriod = new System.Windows.Forms.RadioButton();
            this.radioButtonOneDay = new System.Windows.Forms.RadioButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnOrbit = new System.Windows.Forms.Button();
            this.btnCheckOverlaps = new System.Windows.Forms.Button();
            this.btnOverlaps = new System.Windows.Forms.Button();
            this.labelOverlaps = new System.Windows.Forms.Label();
            this.btnIgnoreOverlaps = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamTable)).BeginInit();
            this.pnlAddingForm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExamTable
            // 
            this.dgvExamTable.AllowUserToAddRows = false;
            this.dgvExamTable.AllowUserToDeleteRows = false;
            this.dgvExamTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExamTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamTable.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExamTable.Location = new System.Drawing.Point(19, 319);
            this.dgvExamTable.Name = "dgvExamTable";
            this.dgvExamTable.RowHeadersVisible = false;
            this.dgvExamTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExamTable.Size = new System.Drawing.Size(986, 313);
            this.dgvExamTable.TabIndex = 3;
            this.dgvExamTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExamTable_CellDoubleClick);
            this.dgvExamTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExamTable_CellValueChanged);
            this.dgvExamTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvExamTable_DataBindingComplete);
            this.dgvExamTable.SelectionChanged += new System.EventHandler(this.dgvExamTable_SelectionChanged);
            // 
            // txt_Comments
            // 
            this.txt_Comments.Location = new System.Drawing.Point(257, 651);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Comments.Size = new System.Drawing.Size(748, 45);
            this.txt_Comments.TabIndex = 10;
            this.txt_Comments.Leave += new System.EventHandler(this.txt_Comments_Leave);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(900, 711);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(105, 40);
            this.btn_Print.TabIndex = 11;
            this.btn_Print.Text = "הדפסה";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_ExportToExcel
            // 
            this.btn_ExportToExcel.Location = new System.Drawing.Point(780, 711);
            this.btn_ExportToExcel.Name = "btn_ExportToExcel";
            this.btn_ExportToExcel.Size = new System.Drawing.Size(105, 40);
            this.btn_ExportToExcel.TabIndex = 12;
            this.btn_ExportToExcel.Text = "יצוא לאקסל";
            this.btn_ExportToExcel.UseVisualStyleBackColor = true;
            this.btn_ExportToExcel.Click += new System.EventHandler(this.btn_ExportToExcel_Click);
            // 
            // btn_ImportFromExcel
            // 
            this.btn_ImportFromExcel.Location = new System.Drawing.Point(660, 711);
            this.btn_ImportFromExcel.Name = "btn_ImportFromExcel";
            this.btn_ImportFromExcel.Size = new System.Drawing.Size(105, 40);
            this.btn_ImportFromExcel.TabIndex = 13;
            this.btn_ImportFromExcel.Text = "טעינה מאקסל ";
            this.btn_ImportFromExcel.UseVisualStyleBackColor = true;
            this.btn_ImportFromExcel.Click += new System.EventHandler(this.btn_ImportFromExcel_Click);
            // 
            // btn_CopyRow
            // 
            this.btn_CopyRow.Location = new System.Drawing.Point(182, 651);
            this.btn_CopyRow.Name = "btn_CopyRow";
            this.btn_CopyRow.Size = new System.Drawing.Size(64, 45);
            this.btn_CopyRow.TabIndex = 14;
            this.btn_CopyRow.Text = "שכפול מבחן";
            this.btn_CopyRow.UseVisualStyleBackColor = true;
            this.btn_CopyRow.Click += new System.EventHandler(this.btn_CopyRow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(910, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "הערות למשגיח/ה";
            // 
            // dateTimePickerFrom_Filter
            // 
            this.dateTimePickerFrom_Filter.CustomFormat = "";
            this.dateTimePickerFrom_Filter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFrom_Filter.Location = new System.Drawing.Point(216, 98);
            this.dateTimePickerFrom_Filter.Name = "dateTimePickerFrom_Filter";
            this.dateTimePickerFrom_Filter.Size = new System.Drawing.Size(154, 20);
            this.dateTimePickerFrom_Filter.TabIndex = 17;
            this.dateTimePickerFrom_Filter.ValueChanged += new System.EventHandler(this.dateTimePickerFilter_ValueChanged);
            // 
            // dateTimePickerTo_Filter
            // 
            this.dateTimePickerTo_Filter.CustomFormat = "";
            this.dateTimePickerTo_Filter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTo_Filter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerTo_Filter.Location = new System.Drawing.Point(216, 133);
            this.dateTimePickerTo_Filter.Name = "dateTimePickerTo_Filter";
            this.dateTimePickerTo_Filter.Size = new System.Drawing.Size(154, 20);
            this.dateTimePickerTo_Filter.TabIndex = 18;
            this.dateTimePickerTo_Filter.ValueChanged += new System.EventHandler(this.dateTimePickerFilter_ValueChanged);
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(376, 100);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(47, 13);
            this.lblDateFrom.TabIndex = 19;
            this.lblDateFrom.Text = "מתאריך";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(376, 133);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(64, 13);
            this.lblDateTo.TabIndex = 20;
            this.lblDateTo.Text = "עד לתאריך";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DatePicker.Location = new System.Drawing.Point(232, 58);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(121, 20);
            this.DatePicker.TabIndex = 22;
            // 
            // txtDiscipline_NewExam
            // 
            this.txtDiscipline_NewExam.Location = new System.Drawing.Point(25, 111);
            this.txtDiscipline_NewExam.Name = "txtDiscipline_NewExam";
            this.txtDiscipline_NewExam.Size = new System.Drawing.Size(121, 20);
            this.txtDiscipline_NewExam.TabIndex = 23;
            this.txtDiscipline_NewExam.TextChanged += new System.EventHandler(this.creationFormChanged);
            // 
            // pnlAddingForm
            // 
            this.pnlAddingForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddingForm.Controls.Add(this.label12);
            this.pnlAddingForm.Controls.Add(this.btnClearAddingForm);
            this.pnlAddingForm.Controls.Add(this.btnAddExam);
            this.pnlAddingForm.Controls.Add(this.label10);
            this.pnlAddingForm.Controls.Add(this.label9);
            this.pnlAddingForm.Controls.Add(this.label8);
            this.pnlAddingForm.Controls.Add(this.label7);
            this.pnlAddingForm.Controls.Add(this.label6);
            this.pnlAddingForm.Controls.Add(this.label5);
            this.pnlAddingForm.Controls.Add(this.label4);
            this.pnlAddingForm.Controls.Add(this.label3);
            this.pnlAddingForm.Controls.Add(this.label1);
            this.pnlAddingForm.Controls.Add(this.cbExtraTime_NewExam);
            this.pnlAddingForm.Controls.Add(this.ToTimePicker);
            this.pnlAddingForm.Controls.Add(this.FromTimePicker);
            this.pnlAddingForm.Controls.Add(this.cboCourse_NewExam);
            this.pnlAddingForm.Controls.Add(this.txtSupervisor_NewExam);
            this.pnlAddingForm.Controls.Add(this.txtGroup_NewExam);
            this.pnlAddingForm.Controls.Add(this.cboRoom_NewExam);
            this.pnlAddingForm.Controls.Add(this.cboDivision_NewExam);
            this.pnlAddingForm.Controls.Add(this.txtDiscipline_NewExam);
            this.pnlAddingForm.Controls.Add(this.DatePicker);
            this.pnlAddingForm.Location = new System.Drawing.Point(19, 25);
            this.pnlAddingForm.Name = "pnlAddingForm";
            this.pnlAddingForm.Size = new System.Drawing.Size(455, 278);
            this.pnlAddingForm.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(195, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "יצירת מבחן";
            // 
            // btnClearAddingForm
            // 
            this.btnClearAddingForm.Enabled = false;
            this.btnClearAddingForm.Location = new System.Drawing.Point(124, 227);
            this.btnClearAddingForm.Name = "btnClearAddingForm";
            this.btnClearAddingForm.Size = new System.Drawing.Size(88, 35);
            this.btnClearAddingForm.TabIndex = 42;
            this.btnClearAddingForm.Text = "ניקוי טופס";
            this.btnClearAddingForm.UseVisualStyleBackColor = true;
            this.btnClearAddingForm.Click += new System.EventHandler(this.btnClearAddingForm_Click);
            // 
            // btnAddExam
            // 
            this.btnAddExam.Enabled = false;
            this.btnAddExam.Location = new System.Drawing.Point(25, 227);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(88, 35);
            this.btnAddExam.TabIndex = 41;
            this.btnAddExam.Text = "הוספת מבחן";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(152, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "חדר";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "מקצוע";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "קבוצה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "שם משגיח";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "מגמה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "חטיבה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "שעת סיום";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "שעת התיצבות";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "תאריך";
            // 
            // cbExtraTime_NewExam
            // 
            this.cbExtraTime_NewExam.AutoSize = true;
            this.cbExtraTime_NewExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbExtraTime_NewExam.Location = new System.Drawing.Point(25, 164);
            this.cbExtraTime_NewExam.Name = "cbExtraTime_NewExam";
            this.cbExtraTime_NewExam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbExtraTime_NewExam.Size = new System.Drawing.Size(79, 17);
            this.cbExtraTime_NewExam.TabIndex = 31;
            this.cbExtraTime_NewExam.Text = "תוספת זמן";
            this.cbExtraTime_NewExam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbExtraTime_NewExam.UseVisualStyleBackColor = true;
            // 
            // ToTimePicker
            // 
            this.ToTimePicker.CustomFormat = "HH:mm";
            this.ToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ToTimePicker.Location = new System.Drawing.Point(232, 111);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.ShowUpDown = true;
            this.ToTimePicker.Size = new System.Drawing.Size(121, 20);
            this.ToTimePicker.TabIndex = 30;
            this.ToTimePicker.Value = new System.DateTime(2019, 10, 19, 12, 0, 0, 0);
            this.ToTimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // FromTimePicker
            // 
            this.FromTimePicker.CustomFormat = "HH:mm";
            this.FromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FromTimePicker.Location = new System.Drawing.Point(232, 85);
            this.FromTimePicker.Name = "FromTimePicker";
            this.FromTimePicker.ShowUpDown = true;
            this.FromTimePicker.Size = new System.Drawing.Size(121, 20);
            this.FromTimePicker.TabIndex = 29;
            this.FromTimePicker.Value = new System.DateTime(2019, 10, 19, 12, 0, 0, 0);
            this.FromTimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // cboCourse_NewExam
            // 
            this.cboCourse_NewExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCourse_NewExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCourse_NewExam.DropDownWidth = 220;
            this.cboCourse_NewExam.FormattingEnabled = true;
            this.cboCourse_NewExam.Location = new System.Drawing.Point(232, 164);
            this.cboCourse_NewExam.Name = "cboCourse_NewExam";
            this.cboCourse_NewExam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboCourse_NewExam.Size = new System.Drawing.Size(121, 21);
            this.cboCourse_NewExam.TabIndex = 28;
            this.cboCourse_NewExam.SelectedIndexChanged += new System.EventHandler(this.creationFormChanged);
            this.cboCourse_NewExam.TextChanged += new System.EventHandler(this.comboBoxes_NewExam_TextChanged);
            // 
            // txtSupervisor_NewExam
            // 
            this.txtSupervisor_NewExam.Location = new System.Drawing.Point(25, 58);
            this.txtSupervisor_NewExam.Name = "txtSupervisor_NewExam";
            this.txtSupervisor_NewExam.Size = new System.Drawing.Size(121, 20);
            this.txtSupervisor_NewExam.TabIndex = 27;
            this.txtSupervisor_NewExam.TextChanged += new System.EventHandler(this.creationFormChanged);
            // 
            // txtGroup_NewExam
            // 
            this.txtGroup_NewExam.Location = new System.Drawing.Point(25, 84);
            this.txtGroup_NewExam.Name = "txtGroup_NewExam";
            this.txtGroup_NewExam.Size = new System.Drawing.Size(121, 20);
            this.txtGroup_NewExam.TabIndex = 26;
            this.txtGroup_NewExam.TextChanged += new System.EventHandler(this.creationFormChanged);
            // 
            // cboRoom_NewExam
            // 
            this.cboRoom_NewExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRoom_NewExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRoom_NewExam.DropDownWidth = 220;
            this.cboRoom_NewExam.FormattingEnabled = true;
            this.cboRoom_NewExam.Location = new System.Drawing.Point(25, 137);
            this.cboRoom_NewExam.Name = "cboRoom_NewExam";
            this.cboRoom_NewExam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboRoom_NewExam.Size = new System.Drawing.Size(121, 21);
            this.cboRoom_NewExam.TabIndex = 25;
            this.cboRoom_NewExam.SelectedIndexChanged += new System.EventHandler(this.creationFormChanged);
            this.cboRoom_NewExam.TextChanged += new System.EventHandler(this.comboBoxes_NewExam_TextChanged);
            // 
            // cboDivision_NewExam
            // 
            this.cboDivision_NewExam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDivision_NewExam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDivision_NewExam.DropDownWidth = 220;
            this.cboDivision_NewExam.FormattingEnabled = true;
            this.cboDivision_NewExam.Location = new System.Drawing.Point(232, 137);
            this.cboDivision_NewExam.Name = "cboDivision_NewExam";
            this.cboDivision_NewExam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboDivision_NewExam.Size = new System.Drawing.Size(121, 21);
            this.cboDivision_NewExam.TabIndex = 24;
            this.cboDivision_NewExam.SelectedIndexChanged += new System.EventHandler(this.creationFormChanged);
            this.cboDivision_NewExam.SelectedValueChanged += new System.EventHandler(this.cboDivision_NewExam_SelectedValueChanged_1);
            this.cboDivision_NewExam.TextChanged += new System.EventHandler(this.comboBoxes_NewExam_TextChanged);
            // 
            // lbl_CourseFilter
            // 
            this.lbl_CourseFilter.AutoSize = true;
            this.lbl_CourseFilter.Location = new System.Drawing.Point(156, 99);
            this.lbl_CourseFilter.Name = "lbl_CourseFilter";
            this.lbl_CourseFilter.Size = new System.Drawing.Size(34, 13);
            this.lbl_CourseFilter.TabIndex = 5;
            this.lbl_CourseFilter.Text = "מגמה";
            // 
            // lbl_DivisionFilter
            // 
            this.lbl_DivisionFilter.AutoSize = true;
            this.lbl_DivisionFilter.Location = new System.Drawing.Point(150, 59);
            this.lbl_DivisionFilter.Name = "lbl_DivisionFilter";
            this.lbl_DivisionFilter.Size = new System.Drawing.Size(40, 13);
            this.lbl_DivisionFilter.TabIndex = 4;
            this.lbl_DivisionFilter.Text = "חטיבה";
            // 
            // lblRoomFilter
            // 
            this.lblRoomFilter.AutoSize = true;
            this.lblRoomFilter.Location = new System.Drawing.Point(163, 140);
            this.lblRoomFilter.Name = "lblRoomFilter";
            this.lblRoomFilter.Size = new System.Drawing.Size(27, 13);
            this.lblRoomFilter.TabIndex = 9;
            this.lblRoomFilter.Text = "חדר";
            // 
            // cbShowDisabledExams
            // 
            this.cbShowDisabledExams.AutoSize = true;
            this.cbShowDisabledExams.Checked = true;
            this.cbShowDisabledExams.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowDisabledExams.Location = new System.Drawing.Point(23, 164);
            this.cbShowDisabledExams.Name = "cbShowDisabledExams";
            this.cbShowDisabledExams.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbShowDisabledExams.Size = new System.Drawing.Size(94, 17);
            this.cbShowDisabledExams.TabIndex = 12;
            this.cbShowDisabledExams.Text = "הצג מבוטלים";
            this.cbShowDisabledExams.UseVisualStyleBackColor = true;
            // 
            // cboDivisionFilter
            // 
            this.cboDivisionFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDivisionFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDivisionFilter.DropDownWidth = 220;
            this.cboDivisionFilter.FormattingEnabled = true;
            this.cboDivisionFilter.Location = new System.Drawing.Point(23, 55);
            this.cboDivisionFilter.Name = "cboDivisionFilter";
            this.cboDivisionFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboDivisionFilter.Size = new System.Drawing.Size(121, 21);
            this.cboDivisionFilter.TabIndex = 43;
            this.cboDivisionFilter.SelectedValueChanged += new System.EventHandler(this.cboDivisionFilter_SelectedValueChanged);
            // 
            // cboCourseFilter
            // 
            this.cboCourseFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCourseFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCourseFilter.DropDownWidth = 220;
            this.cboCourseFilter.FormattingEnabled = true;
            this.cboCourseFilter.Location = new System.Drawing.Point(23, 94);
            this.cboCourseFilter.Name = "cboCourseFilter";
            this.cboCourseFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboCourseFilter.Size = new System.Drawing.Size(121, 21);
            this.cboCourseFilter.TabIndex = 43;
            // 
            // cboRoomFilter
            // 
            this.cboRoomFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRoomFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRoomFilter.DropDownWidth = 220;
            this.cboRoomFilter.FormattingEnabled = true;
            this.cboRoomFilter.Location = new System.Drawing.Point(23, 132);
            this.cboRoomFilter.Name = "cboRoomFilter";
            this.cboRoomFilter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboRoomFilter.Size = new System.Drawing.Size(121, 21);
            this.cboRoomFilter.TabIndex = 43;
            // 
            // btnChangeExam
            // 
            this.btnChangeExam.Location = new System.Drawing.Point(112, 651);
            this.btnChangeExam.Name = "btnChangeExam";
            this.btnChangeExam.Size = new System.Drawing.Size(64, 45);
            this.btnChangeExam.TabIndex = 45;
            this.btnChangeExam.Text = "עריכת מבחן";
            this.btnChangeExam.UseVisualStyleBackColor = true;
            this.btnChangeExam.Click += new System.EventHandler(this.btnChangeExam_Click);
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.Location = new System.Drawing.Point(42, 651);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(64, 45);
            this.btnDeleteExam.TabIndex = 46;
            this.btnDeleteExam.Text = "מחיקת מבחנים";
            this.btnDeleteExam.UseVisualStyleBackColor = true;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteExam_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(376, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "תאריך";
            // 
            // dateTimePickerOneDay_Filter
            // 
            this.dateTimePickerOneDay_Filter.CustomFormat = "";
            this.dateTimePickerOneDay_Filter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOneDay_Filter.Location = new System.Drawing.Point(216, 55);
            this.dateTimePickerOneDay_Filter.Name = "dateTimePickerOneDay_Filter";
            this.dateTimePickerOneDay_Filter.Size = new System.Drawing.Size(154, 20);
            this.dateTimePickerOneDay_Filter.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButtonShowNew);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.btnShowExams);
            this.panel2.Controls.Add(this.radioButtonShowAll);
            this.panel2.Controls.Add(this.radioButtonPeriod);
            this.panel2.Controls.Add(this.radioButtonOneDay);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cboRoomFilter);
            this.panel2.Controls.Add(this.dateTimePickerOneDay_Filter);
            this.panel2.Controls.Add(this.cboCourseFilter);
            this.panel2.Controls.Add(this.lblDateFrom);
            this.panel2.Controls.Add(this.cboDivisionFilter);
            this.panel2.Controls.Add(this.dateTimePickerFrom_Filter);
            this.panel2.Controls.Add(this.cbShowDisabledExams);
            this.panel2.Controls.Add(this.dateTimePickerTo_Filter);
            this.panel2.Controls.Add(this.lblDateTo);
            this.panel2.Controls.Add(this.lblRoomFilter);
            this.panel2.Controls.Add(this.lbl_DivisionFilter);
            this.panel2.Controls.Add(this.lbl_CourseFilter);
            this.panel2.Location = new System.Drawing.Point(480, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 278);
            this.panel2.TabIndex = 50;
            // 
            // radioButtonShowNew
            // 
            this.radioButtonShowNew.AutoSize = true;
            this.radioButtonShowNew.Location = new System.Drawing.Point(441, 226);
            this.radioButtonShowNew.Name = "radioButtonShowNew";
            this.radioButtonShowNew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonShowNew.Size = new System.Drawing.Size(60, 17);
            this.radioButtonShowNew.TabIndex = 57;
            this.radioButtonShowNew.Text = "חדשים";
            this.radioButtonShowNew.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(214, 208);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(293, 1);
            this.panel5.TabIndex = 56;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(214, 166);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 1);
            this.panel4.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(214, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 1);
            this.panel1.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 4);
            this.panel3.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "פילטרים";
            // 
            // btnShowExams
            // 
            this.btnShowExams.Location = new System.Drawing.Point(23, 227);
            this.btnShowExams.Name = "btnShowExams";
            this.btnShowExams.Size = new System.Drawing.Size(88, 35);
            this.btnShowExams.TabIndex = 43;
            this.btnShowExams.Text = "הצגת מבחנים";
            this.btnShowExams.UseVisualStyleBackColor = true;
            this.btnShowExams.Click += new System.EventHandler(this.btnShowExams_Click);
            // 
            // radioButtonShowAll
            // 
            this.radioButtonShowAll.AutoSize = true;
            this.radioButtonShowAll.Location = new System.Drawing.Point(441, 185);
            this.radioButtonShowAll.Name = "radioButtonShowAll";
            this.radioButtonShowAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonShowAll.Size = new System.Drawing.Size(68, 17);
            this.radioButtonShowAll.TabIndex = 51;
            this.radioButtonShowAll.Text = "עתידיים";
            this.radioButtonShowAll.UseVisualStyleBackColor = true;
            this.radioButtonShowAll.CheckedChanged += new System.EventHandler(this.radioButtonShowAll_CheckedChanged);
            // 
            // radioButtonPeriod
            // 
            this.radioButtonPeriod.AutoSize = true;
            this.radioButtonPeriod.Location = new System.Drawing.Point(441, 114);
            this.radioButtonPeriod.Name = "radioButtonPeriod";
            this.radioButtonPeriod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonPeriod.Size = new System.Drawing.Size(58, 17);
            this.radioButtonPeriod.TabIndex = 50;
            this.radioButtonPeriod.Text = "תקופה";
            this.radioButtonPeriod.UseVisualStyleBackColor = true;
            this.radioButtonPeriod.CheckedChanged += new System.EventHandler(this.radioButtonPeriod_CheckedChanged);
            // 
            // radioButtonOneDay
            // 
            this.radioButtonOneDay.AutoSize = true;
            this.radioButtonOneDay.Location = new System.Drawing.Point(441, 56);
            this.radioButtonOneDay.Name = "radioButtonOneDay";
            this.radioButtonOneDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButtonOneDay.Size = new System.Drawing.Size(67, 17);
            this.radioButtonOneDay.TabIndex = 49;
            this.radioButtonOneDay.Text = "יום אחד";
            this.radioButtonOneDay.UseVisualStyleBackColor = true;
            this.radioButtonOneDay.CheckedChanged += new System.EventHandler(this.radioButtonOneDay_CheckedChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnOrbit
            // 
            this.btnOrbit.Location = new System.Drawing.Point(535, 711);
            this.btnOrbit.Name = "btnOrbit";
            this.btnOrbit.Size = new System.Drawing.Size(105, 40);
            this.btnOrbit.TabIndex = 51;
            this.btnOrbit.Text = "טעינה מאורביט";
            this.btnOrbit.UseVisualStyleBackColor = true;
            this.btnOrbit.Click += new System.EventHandler(this.btnOrbit_Click);
            // 
            // btnCheckOverlaps
            // 
            this.btnCheckOverlaps.Location = new System.Drawing.Point(408, 711);
            this.btnCheckOverlaps.Name = "btnCheckOverlaps";
            this.btnCheckOverlaps.Size = new System.Drawing.Size(105, 40);
            this.btnCheckOverlaps.TabIndex = 54;
            this.btnCheckOverlaps.Text = "בדיקת התנגשויות";
            this.btnCheckOverlaps.UseVisualStyleBackColor = true;
            this.btnCheckOverlaps.Click += new System.EventHandler(this.btnCheckOverlaps_Click);
            // 
            // btnOverlaps
            // 
            this.btnOverlaps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOverlaps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOverlaps.Location = new System.Drawing.Point(112, 717);
            this.btnOverlaps.Name = "btnOverlaps";
            this.btnOverlaps.Size = new System.Drawing.Size(64, 28);
            this.btnOverlaps.TabIndex = 52;
            this.btnOverlaps.Text = "להציג";
            this.btnOverlaps.UseVisualStyleBackColor = true;
            this.btnOverlaps.Click += new System.EventHandler(this.btnOverlaps_Click);
            // 
            // labelOverlaps
            // 
            this.labelOverlaps.AutoSize = true;
            this.labelOverlaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOverlaps.ForeColor = System.Drawing.Color.Firebrick;
            this.labelOverlaps.Location = new System.Drawing.Point(179, 723);
            this.labelOverlaps.Name = "labelOverlaps";
            this.labelOverlaps.Size = new System.Drawing.Size(171, 16);
            this.labelOverlaps.TabIndex = 53;
            this.labelOverlaps.Text = "קימים התנגשויות בין מבחנים";
            // 
            // btnIgnoreOverlaps
            // 
            this.btnIgnoreOverlaps.Location = new System.Drawing.Point(42, 717);
            this.btnIgnoreOverlaps.Name = "btnIgnoreOverlaps";
            this.btnIgnoreOverlaps.Size = new System.Drawing.Size(64, 28);
            this.btnIgnoreOverlaps.TabIndex = 55;
            this.btnIgnoreOverlaps.Text = "להתעלם";
            this.btnIgnoreOverlaps.UseVisualStyleBackColor = true;
            this.btnIgnoreOverlaps.Click += new System.EventHandler(this.btnIgnoreOverlaps_Click);
            // 
            // SupervisorAdministration_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnIgnoreOverlaps);
            this.Controls.Add(this.btnCheckOverlaps);
            this.Controls.Add(this.labelOverlaps);
            this.Controls.Add(this.btnOverlaps);
            this.Controls.Add(this.btnOrbit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDeleteExam);
            this.Controls.Add(this.btnChangeExam);
            this.Controls.Add(this.pnlAddingForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_CopyRow);
            this.Controls.Add(this.btn_ImportFromExcel);
            this.Controls.Add(this.btn_ExportToExcel);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.txt_Comments);
            this.Controls.Add(this.dgvExamTable);
            this.Name = "SupervisorAdministration_View";
            this.Size = new System.Drawing.Size(1017, 768);
            this.Load += new System.EventHandler(this.SupervisorAdministration_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamTable)).EndInit();
            this.pnlAddingForm.ResumeLayout(false);
            this.pnlAddingForm.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvExamTable;
        private System.Windows.Forms.TextBox txt_Comments;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_ExportToExcel;
        private System.Windows.Forms.Button btn_ImportFromExcel;
        private System.Windows.Forms.Button btn_CopyRow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom_Filter;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo_Filter;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox txtDiscipline_NewExam;
        private System.Windows.Forms.Panel pnlAddingForm;
        private System.Windows.Forms.CheckBox cbExtraTime_NewExam;
        private System.Windows.Forms.DateTimePicker ToTimePicker;
        private System.Windows.Forms.DateTimePicker FromTimePicker;
        private System.Windows.Forms.ComboBox cboCourse_NewExam;
        private System.Windows.Forms.TextBox txtSupervisor_NewExam;
        private System.Windows.Forms.TextBox txtGroup_NewExam;
        private System.Windows.Forms.ComboBox cboRoom_NewExam;
        private System.Windows.Forms.ComboBox cboDivision_NewExam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.Button btnClearAddingForm;
        private System.Windows.Forms.Label lbl_CourseFilter;
        private System.Windows.Forms.Label lbl_DivisionFilter;
        private System.Windows.Forms.Label lblRoomFilter;
        private System.Windows.Forms.CheckBox cbShowDisabledExams;
        private System.Windows.Forms.ComboBox cboDivisionFilter;
        private System.Windows.Forms.ComboBox cboCourseFilter;
        private System.Windows.Forms.ComboBox cboRoomFilter;
        private System.Windows.Forms.Button btnChangeExam;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerOneDay_Filter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonShowAll;
        private System.Windows.Forms.RadioButton radioButtonPeriod;
        private System.Windows.Forms.RadioButton radioButtonOneDay;
        private System.Windows.Forms.Button btnShowExams;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnOrbit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonShowNew;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCheckOverlaps;
        private System.Windows.Forms.Button btnOverlaps;
        private System.Windows.Forms.Label labelOverlaps;
        private System.Windows.Forms.Button btnIgnoreOverlaps;
    }
}
