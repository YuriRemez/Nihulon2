namespace Nihulon2.SupervisorsAdministration
{
    partial class frmDataForLoadingFromOrbit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDivisions = new System.Windows.Forms.ComboBox();
            this.cboCourses = new System.Windows.Forms.ComboBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "חטיבה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "מגמה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "קבוצה";
            // 
            // cboDivisions
            // 
            this.cboDivisions.FormattingEnabled = true;
            this.cboDivisions.Location = new System.Drawing.Point(24, 85);
            this.cboDivisions.Name = "cboDivisions";
            this.cboDivisions.Size = new System.Drawing.Size(148, 21);
            this.cboDivisions.TabIndex = 5;
            this.cboDivisions.SelectedIndexChanged += new System.EventHandler(this.cboDivisions_SelectedIndexChanged);
            // 
            // cboCourses
            // 
            this.cboCourses.FormattingEnabled = true;
            this.cboCourses.Location = new System.Drawing.Point(24, 113);
            this.cboCourses.Name = "cboCourses";
            this.cboCourses.Size = new System.Drawing.Size(148, 21);
            this.cboCourses.TabIndex = 6;
            this.cboCourses.SelectedIndexChanged += new System.EventHandler(this.cboCourses_SelectedIndexChanged);
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(24, 141);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(148, 20);
            this.txtGroup.TabIndex = 7;
            this.txtGroup.TextChanged += new System.EventHandler(this.txtGroup_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(80, 191);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 34);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "אישור";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 191);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "ביטול";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(264, 24);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(65, 38);
            this.btnChooseFile.TabIndex = 13;
            this.btnChooseFile.Text = "בחירת קןבץ";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(24, 24);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPath.Size = new System.Drawing.Size(220, 38);
            this.txtPath.TabIndex = 14;
            // 
            // frmDataForLoadingFromOrbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 252);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.cboCourses);
            this.Controls.Add(this.cboDivisions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDataForLoadingFromOrbit";
            this.Text = "frmDataForLoadingFromOrbit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDivisions;
        private System.Windows.Forms.ComboBox cboCourses;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.TextBox txtPath;
    }
}