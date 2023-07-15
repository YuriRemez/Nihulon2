namespace Nihulon2.RelationsList
{
    partial class RelationsList_View
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
            this.cbo_ItemType = new System.Windows.Forms.ComboBox();
            this.btn_Disable = new System.Windows.Forms.Button();
            this.txtAddNewItem = new System.Windows.Forms.TextBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.cbShowDisabled = new System.Windows.Forms.CheckBox();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.txtAddNewCourse = new System.Windows.Forms.TextBox();
            this.btnAddNewCourse = new System.Windows.Forms.Button();
            this.lableDivisionsRooms = new System.Windows.Forms.Label();
            this.labelCourses = new System.Windows.Forms.Label();
            this.btnDisableCourse = new System.Windows.Forms.Button();
            this.btnChangeDiv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_ItemType
            // 
            this.cbo_ItemType.FormattingEnabled = true;
            this.cbo_ItemType.Location = new System.Drawing.Point(714, 43);
            this.cbo_ItemType.Name = "cbo_ItemType";
            this.cbo_ItemType.Size = new System.Drawing.Size(180, 21);
            this.cbo_ItemType.TabIndex = 3;
            this.cbo_ItemType.SelectedIndexChanged += new System.EventHandler(this.cbo_ItemType_SelectedIndexChanged);
            // 
            // btn_Disable
            // 
            this.btn_Disable.Location = new System.Drawing.Point(816, 448);
            this.btn_Disable.Name = "btn_Disable";
            this.btn_Disable.Size = new System.Drawing.Size(78, 54);
            this.btn_Disable.TabIndex = 5;
            this.btn_Disable.Text = "סמן כמבוטל\\לא מבוטל";
            this.btn_Disable.UseVisualStyleBackColor = true;
            this.btn_Disable.Click += new System.EventHandler(this.btn_Disable_Click);
            // 
            // txtAddNewItem
            // 
            this.txtAddNewItem.Location = new System.Drawing.Point(714, 104);
            this.txtAddNewItem.Name = "txtAddNewItem";
            this.txtAddNewItem.Size = new System.Drawing.Size(180, 20);
            this.txtAddNewItem.TabIndex = 8;
            this.txtAddNewItem.TextChanged += new System.EventHandler(this.txtAddNewItem_TextChanged);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Enabled = false;
            this.btnAddNewItem.Location = new System.Drawing.Point(633, 87);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(75, 37);
            this.btnAddNewItem.TabIndex = 9;
            this.btnAddNewItem.Text = "יצרת עצם חדש";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeColumns = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(473, 140);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(421, 302);
            this.dgvItems.TabIndex = 10;
            this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
            // 
            // cbShowDisabled
            // 
            this.cbShowDisabled.AutoSize = true;
            this.cbShowDisabled.Location = new System.Drawing.Point(595, 47);
            this.cbShowDisabled.Name = "cbShowDisabled";
            this.cbShowDisabled.Size = new System.Drawing.Size(94, 17);
            this.cbShowDisabled.TabIndex = 11;
            this.cbShowDisabled.Text = "הצג מבוטלים";
            this.cbShowDisabled.UseVisualStyleBackColor = true;
            this.cbShowDisabled.CheckedChanged += new System.EventHandler(this.cbShowDisabled_CheckedChanged);
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.AllowUserToResizeColumns = false;
            this.dgvCourses.AllowUserToResizeRows = false;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(46, 140);
            this.dgvCourses.MultiSelect = false;
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(421, 302);
            this.dgvCourses.TabIndex = 12;
            // 
            // txtAddNewCourse
            // 
            this.txtAddNewCourse.Location = new System.Drawing.Point(287, 104);
            this.txtAddNewCourse.Name = "txtAddNewCourse";
            this.txtAddNewCourse.Size = new System.Drawing.Size(180, 20);
            this.txtAddNewCourse.TabIndex = 13;
            this.txtAddNewCourse.TextChanged += new System.EventHandler(this.txtAddNewCourse_TextChanged);
            // 
            // btnAddNewCourse
            // 
            this.btnAddNewCourse.Enabled = false;
            this.btnAddNewCourse.Location = new System.Drawing.Point(206, 87);
            this.btnAddNewCourse.Name = "btnAddNewCourse";
            this.btnAddNewCourse.Size = new System.Drawing.Size(75, 37);
            this.btnAddNewCourse.TabIndex = 14;
            this.btnAddNewCourse.Text = "יצרת עצם חדש";
            this.btnAddNewCourse.UseVisualStyleBackColor = true;
            this.btnAddNewCourse.Click += new System.EventHandler(this.btnAddNewCourse_Click);
            // 
            // lableDivisionsRooms
            // 
            this.lableDivisionsRooms.AutoSize = true;
            this.lableDivisionsRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableDivisionsRooms.Location = new System.Drawing.Point(554, 103);
            this.lableDivisionsRooms.Name = "lableDivisionsRooms";
            this.lableDivisionsRooms.Size = new System.Drawing.Size(54, 18);
            this.lableDivisionsRooms.TabIndex = 15;
            this.lableDivisionsRooms.Text = "חטיבות";
            // 
            // labelCourses
            // 
            this.labelCourses.AutoSize = true;
            this.labelCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCourses.Location = new System.Drawing.Point(110, 103);
            this.labelCourses.Name = "labelCourses";
            this.labelCourses.Size = new System.Drawing.Size(46, 18);
            this.labelCourses.TabIndex = 16;
            this.labelCourses.Text = "מגמות";
            // 
            // btnDisableCourse
            // 
            this.btnDisableCourse.Location = new System.Drawing.Point(389, 448);
            this.btnDisableCourse.Name = "btnDisableCourse";
            this.btnDisableCourse.Size = new System.Drawing.Size(78, 54);
            this.btnDisableCourse.TabIndex = 17;
            this.btnDisableCourse.Text = "סמן כמבוטל\\לא מבוטל";
            this.btnDisableCourse.UseVisualStyleBackColor = true;
            this.btnDisableCourse.Click += new System.EventHandler(this.btnDisableCourse_Click);
            // 
            // btnChangeDiv
            // 
            this.btnChangeDiv.Location = new System.Drawing.Point(287, 448);
            this.btnChangeDiv.Name = "btnChangeDiv";
            this.btnChangeDiv.Size = new System.Drawing.Size(78, 54);
            this.btnChangeDiv.TabIndex = 18;
            this.btnChangeDiv.Text = "להעביר לחטיבה אחרת";
            this.btnChangeDiv.UseVisualStyleBackColor = true;
            this.btnChangeDiv.Click += new System.EventHandler(this.btnChangeDiv_Click);
            // 
            // RelationsList_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnChangeDiv);
            this.Controls.Add(this.btnDisableCourse);
            this.Controls.Add(this.labelCourses);
            this.Controls.Add(this.lableDivisionsRooms);
            this.Controls.Add(this.btnAddNewCourse);
            this.Controls.Add(this.txtAddNewCourse);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.cbShowDisabled);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.txtAddNewItem);
            this.Controls.Add(this.btn_Disable);
            this.Controls.Add(this.cbo_ItemType);
            this.Name = "RelationsList_View";
            this.Size = new System.Drawing.Size(934, 569);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_ItemType;
        private System.Windows.Forms.Button btn_Disable;
        private System.Windows.Forms.TextBox txtAddNewItem;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.CheckBox cbShowDisabled;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.TextBox txtAddNewCourse;
        private System.Windows.Forms.Button btnAddNewCourse;
        private System.Windows.Forms.Label lableDivisionsRooms;
        private System.Windows.Forms.Label labelCourses;
        private System.Windows.Forms.Button btnDisableCourse;
        private System.Windows.Forms.Button btnChangeDiv;
    }
}
