namespace Nihulon2.SupervisorsAdministration
{
    partial class frmChangeExam
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
            this.pnlAddingForm = new System.Windows.Forms.Panel();
            this.btnCancelChanging = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbExtraTime = new System.Windows.Forms.CheckBox();
            this.ToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.txtSupervisor = new System.Windows.Forms.TextBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.cboDivision = new System.Windows.Forms.ComboBox();
            this.txtDiscipline = new System.Windows.Forms.TextBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.pnlAddingForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddingForm
            // 
            this.pnlAddingForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddingForm.Controls.Add(this.btnCancelChanging);
            this.pnlAddingForm.Controls.Add(this.btnSaveChanges);
            this.pnlAddingForm.Controls.Add(this.label10);
            this.pnlAddingForm.Controls.Add(this.label9);
            this.pnlAddingForm.Controls.Add(this.label8);
            this.pnlAddingForm.Controls.Add(this.label7);
            this.pnlAddingForm.Controls.Add(this.label6);
            this.pnlAddingForm.Controls.Add(this.label5);
            this.pnlAddingForm.Controls.Add(this.label4);
            this.pnlAddingForm.Controls.Add(this.label3);
            this.pnlAddingForm.Controls.Add(this.label1);
            this.pnlAddingForm.Controls.Add(this.cbExtraTime);
            this.pnlAddingForm.Controls.Add(this.ToTimePicker);
            this.pnlAddingForm.Controls.Add(this.FromTimePicker);
            this.pnlAddingForm.Controls.Add(this.cboCourse);
            this.pnlAddingForm.Controls.Add(this.txtSupervisor);
            this.pnlAddingForm.Controls.Add(this.txtGroup);
            this.pnlAddingForm.Controls.Add(this.cboRoom);
            this.pnlAddingForm.Controls.Add(this.cboDivision);
            this.pnlAddingForm.Controls.Add(this.txtDiscipline);
            this.pnlAddingForm.Controls.Add(this.DatePicker);
            this.pnlAddingForm.Location = new System.Drawing.Point(12, 12);
            this.pnlAddingForm.Name = "pnlAddingForm";
            this.pnlAddingForm.Size = new System.Drawing.Size(455, 227);
            this.pnlAddingForm.TabIndex = 22;
            // 
            // btnCancelChanging
            // 
            this.btnCancelChanging.Location = new System.Drawing.Point(128, 177);
            this.btnCancelChanging.Name = "btnCancelChanging";
            this.btnCancelChanging.Size = new System.Drawing.Size(88, 35);
            this.btnCancelChanging.TabIndex = 42;
            this.btnCancelChanging.Text = "ביטול";
            this.btnCancelChanging.UseVisualStyleBackColor = true;
            this.btnCancelChanging.Click += new System.EventHandler(this.btnCancelChanging_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(34, 177);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(88, 35);
            this.btnSaveChanges.TabIndex = 41;
            this.btnSaveChanges.Text = "לשמור שינוים";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(161, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "חדר";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "מקצוע";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "קבוצה";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "שם משגיח";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "מגמה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "חטיבה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "שעת סיום";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "שעת התיצבות";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "תאריך";
            // 
            // cbExtraTime
            // 
            this.cbExtraTime.AutoSize = true;
            this.cbExtraTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbExtraTime.Location = new System.Drawing.Point(34, 122);
            this.cbExtraTime.Name = "cbExtraTime";
            this.cbExtraTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbExtraTime.Size = new System.Drawing.Size(79, 17);
            this.cbExtraTime.TabIndex = 31;
            this.cbExtraTime.Text = "תוספת זמן";
            this.cbExtraTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbExtraTime.UseVisualStyleBackColor = true;
            // 
            // ToTimePicker
            // 
            this.ToTimePicker.CustomFormat = "HH:mm";
            this.ToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ToTimePicker.Location = new System.Drawing.Point(241, 69);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.ShowUpDown = true;
            this.ToTimePicker.Size = new System.Drawing.Size(121, 20);
            this.ToTimePicker.TabIndex = 30;
            this.ToTimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // FromTimePicker
            // 
            this.FromTimePicker.CustomFormat = "HH:mm";
            this.FromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FromTimePicker.Location = new System.Drawing.Point(241, 43);
            this.FromTimePicker.Name = "FromTimePicker";
            this.FromTimePicker.ShowUpDown = true;
            this.FromTimePicker.Size = new System.Drawing.Size(121, 20);
            this.FromTimePicker.TabIndex = 29;
            this.FromTimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // cboCourse
            // 
            this.cboCourse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCourse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(241, 122);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboCourse.Size = new System.Drawing.Size(121, 21);
            this.cboCourse.TabIndex = 28;
            this.cboCourse.TextChanged += new System.EventHandler(this.comboBoxes_TextChanged);
            // 
            // txtSupervisor
            // 
            this.txtSupervisor.Location = new System.Drawing.Point(34, 16);
            this.txtSupervisor.Name = "txtSupervisor";
            this.txtSupervisor.Size = new System.Drawing.Size(121, 20);
            this.txtSupervisor.TabIndex = 27;
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(34, 42);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(121, 20);
            this.txtGroup.TabIndex = 26;
            // 
            // cboRoom
            // 
            this.cboRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(34, 95);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboRoom.Size = new System.Drawing.Size(121, 21);
            this.cboRoom.TabIndex = 25;
            this.cboRoom.TextChanged += new System.EventHandler(this.comboBoxes_TextChanged);
            // 
            // cboDivision
            // 
            this.cboDivision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDivision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDivision.FormattingEnabled = true;
            this.cboDivision.Location = new System.Drawing.Point(241, 95);
            this.cboDivision.Name = "cboDivision";
            this.cboDivision.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboDivision.Size = new System.Drawing.Size(121, 21);
            this.cboDivision.TabIndex = 24;
            this.cboDivision.SelectedIndexChanged += new System.EventHandler(this.cboDivision_SelectedIndexChanged);
            this.cboDivision.TextChanged += new System.EventHandler(this.comboBoxes_TextChanged);
            // 
            // txtDiscipline
            // 
            this.txtDiscipline.Location = new System.Drawing.Point(34, 69);
            this.txtDiscipline.Name = "txtDiscipline";
            this.txtDiscipline.Size = new System.Drawing.Size(121, 20);
            this.txtDiscipline.TabIndex = 23;
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "";
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DatePicker.Location = new System.Drawing.Point(241, 16);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(121, 20);
            this.DatePicker.TabIndex = 22;
            // 
            // frmChangeExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 250);
            this.Controls.Add(this.pnlAddingForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangeExam";
            this.Text = "שינוי מבחן";
            this.pnlAddingForm.ResumeLayout(false);
            this.pnlAddingForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddingForm;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbExtraTime;
        private System.Windows.Forms.DateTimePicker ToTimePicker;
        private System.Windows.Forms.DateTimePicker FromTimePicker;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.TextBox txtSupervisor;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.ComboBox cboDivision;
        private System.Windows.Forms.TextBox txtDiscipline;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Button btnCancelChanging;
    }
}