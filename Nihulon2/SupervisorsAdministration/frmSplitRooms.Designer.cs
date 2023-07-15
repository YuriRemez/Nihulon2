namespace Nihulon2.SupervisorsAdministration
{
    partial class frmSplitRooms
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
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.txtRoom1 = new System.Windows.Forms.TextBox();
            this.txtRoom2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRoom1 = new System.Windows.Forms.Label();
            this.lblRoom2 = new System.Windows.Forms.Label();
            this.lblRoom3 = new System.Windows.Forms.Label();
            this.txtRoom3 = new System.Windows.Forms.TextBox();
            this.lblRoom4 = new System.Windows.Forms.Label();
            this.txtRoom4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(28, 74);
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOriginal.Size = new System.Drawing.Size(354, 20);
            this.txtOriginal.TabIndex = 0;
            // 
            // txtRoom1
            // 
            this.txtRoom1.Location = new System.Drawing.Point(227, 115);
            this.txtRoom1.Name = "txtRoom1";
            this.txtRoom1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRoom1.Size = new System.Drawing.Size(150, 20);
            this.txtRoom1.TabIndex = 1;
            // 
            // txtRoom2
            // 
            this.txtRoom2.Location = new System.Drawing.Point(227, 141);
            this.txtRoom2.Name = "txtRoom2";
            this.txtRoom2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRoom2.Size = new System.Drawing.Size(150, 20);
            this.txtRoom2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(96, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "המערכת לא הצליחה להפריד חדרים בזמן שיכפול מבחנים";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(139, 187);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 35);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "אישור";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "ביטול טעינה";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(285, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "נא להפריד אותם ידנית";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "מקור";
            // 
            // lblRoom1
            // 
            this.lblRoom1.AutoSize = true;
            this.lblRoom1.Location = new System.Drawing.Point(384, 118);
            this.lblRoom1.Name = "lblRoom1";
            this.lblRoom1.Size = new System.Drawing.Size(36, 13);
            this.lblRoom1.TabIndex = 8;
            this.lblRoom1.Text = "חדר 1";
            // 
            // lblRoom2
            // 
            this.lblRoom2.AutoSize = true;
            this.lblRoom2.Location = new System.Drawing.Point(384, 144);
            this.lblRoom2.Name = "lblRoom2";
            this.lblRoom2.Size = new System.Drawing.Size(36, 13);
            this.lblRoom2.TabIndex = 9;
            this.lblRoom2.Text = "חדר 2";
            // 
            // lblRoom3
            // 
            this.lblRoom3.AutoSize = true;
            this.lblRoom3.Location = new System.Drawing.Point(185, 118);
            this.lblRoom3.Name = "lblRoom3";
            this.lblRoom3.Size = new System.Drawing.Size(36, 13);
            this.lblRoom3.TabIndex = 11;
            this.lblRoom3.Text = "חדר 3";
            this.lblRoom3.Visible = false;
            // 
            // txtRoom3
            // 
            this.txtRoom3.Location = new System.Drawing.Point(28, 115);
            this.txtRoom3.Name = "txtRoom3";
            this.txtRoom3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRoom3.Size = new System.Drawing.Size(150, 20);
            this.txtRoom3.TabIndex = 10;
            this.txtRoom3.Visible = false;
            // 
            // lblRoom4
            // 
            this.lblRoom4.AutoSize = true;
            this.lblRoom4.Location = new System.Drawing.Point(185, 144);
            this.lblRoom4.Name = "lblRoom4";
            this.lblRoom4.Size = new System.Drawing.Size(36, 13);
            this.lblRoom4.TabIndex = 13;
            this.lblRoom4.Text = "חדר 4";
            this.lblRoom4.Visible = false;
            // 
            // txtRoom4
            // 
            this.txtRoom4.Location = new System.Drawing.Point(28, 141);
            this.txtRoom4.Name = "txtRoom4";
            this.txtRoom4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRoom4.Size = new System.Drawing.Size(150, 20);
            this.txtRoom4.TabIndex = 12;
            this.txtRoom4.Visible = false;
            // 
            // frmSplitRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 234);
            this.Controls.Add(this.lblRoom4);
            this.Controls.Add(this.txtRoom4);
            this.Controls.Add(this.lblRoom3);
            this.Controls.Add(this.txtRoom3);
            this.Controls.Add(this.lblRoom2);
            this.Controls.Add(this.lblRoom1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoom2);
            this.Controls.Add(this.txtRoom1);
            this.Controls.Add(this.txtOriginal);
            this.Name = "frmSplitRooms";
            this.Text = "frmSplitRooms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.TextBox txtRoom1;
        private System.Windows.Forms.TextBox txtRoom2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRoom1;
        private System.Windows.Forms.Label lblRoom2;
        private System.Windows.Forms.Label lblRoom3;
        private System.Windows.Forms.TextBox txtRoom3;
        private System.Windows.Forms.Label lblRoom4;
        private System.Windows.Forms.TextBox txtRoom4;
    }
}