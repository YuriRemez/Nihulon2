using System.Windows.Forms;

using Nihulon2.RelationsList;
using Nihulon2.SupervisorsAdministration;

namespace Nihulon2
{
    partial class Main_View
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
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_GotoRelationsList = new System.Windows.Forms.Button();
            this.btn_GotoSupervisorsAdministration = new System.Windows.Forms.Button();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.Controls.Add(this.monthCalendar1);
            this.pnl_Buttons.Controls.Add(this.btn_Exit);
            this.pnl_Buttons.Controls.Add(this.btn_Refresh);
            this.pnl_Buttons.Controls.Add(this.btn_GotoRelationsList);
            this.pnl_Buttons.Controls.Add(this.btn_GotoSupervisorsAdministration);
            this.pnl_Buttons.Location = new System.Drawing.Point(12, 12);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(243, 569);
            this.pnl_Buttons.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Exit.Location = new System.Drawing.Point(62, 499);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(123, 52);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "יציאה";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Refresh.Location = new System.Drawing.Point(62, 441);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(123, 52);
            this.btn_Refresh.TabIndex = 3;
            this.btn_Refresh.Text = "רענן";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_GotoRelationsList
            // 
            this.btn_GotoRelationsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_GotoRelationsList.Location = new System.Drawing.Point(62, 232);
            this.btn_GotoRelationsList.Name = "btn_GotoRelationsList";
            this.btn_GotoRelationsList.Size = new System.Drawing.Size(123, 52);
            this.btn_GotoRelationsList.TabIndex = 1;
            this.btn_GotoRelationsList.Text = "עצמים הקשורים למבחנים";
            this.btn_GotoRelationsList.UseVisualStyleBackColor = true;
            this.btn_GotoRelationsList.Click += new System.EventHandler(this.btn_GotoRelationsList_Click);
            // 
            // btn_GotoSupervisorsAdministration
            // 
            this.btn_GotoSupervisorsAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_GotoSupervisorsAdministration.Location = new System.Drawing.Point(62, 174);
            this.btn_GotoSupervisorsAdministration.Name = "btn_GotoSupervisorsAdministration";
            this.btn_GotoSupervisorsAdministration.Size = new System.Drawing.Size(123, 52);
            this.btn_GotoSupervisorsAdministration.TabIndex = 0;
            this.btn_GotoSupervisorsAdministration.Text = "ניהול משגיחים";
            this.btn_GotoSupervisorsAdministration.UseVisualStyleBackColor = true;
            this.btn_GotoSupervisorsAdministration.Click += new System.EventHandler(this.btn_GotoSupervisorsAdministration_Click);
            // 
            // Main_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 807);
            this.Controls.Add(this.pnl_Buttons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_View";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ניהולון 2";
            this.pnl_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_GotoRelationsList;
        private System.Windows.Forms.Button btn_GotoSupervisorsAdministration;
        private MonthCalendar monthCalendar1;
    }
}

