namespace Database_Project2
{
    partial class Main_interface
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainEntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bcostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLabServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLabServiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addLabServiceToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.queriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainEntToolStripMenuItem,
            this.queriesToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainEntToolStripMenuItem
            // 
            this.mainEntToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.departmentToolStripMenuItem,
            this.bedToolStripMenuItem,
            this.labServiceToolStripMenuItem});
            this.mainEntToolStripMenuItem.Name = "mainEntToolStripMenuItem";
            this.mainEntToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.mainEntToolStripMenuItem.Text = "Main Entities";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDoctorToolStripMenuItem,
            this.manageDoctorToolStripMenuItem,
            this.updateDoctorToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.employeeToolStripMenuItem.Text = "Doctor";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // addDoctorToolStripMenuItem
            // 
            this.addDoctorToolStripMenuItem.Name = "addDoctorToolStripMenuItem";
            this.addDoctorToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.addDoctorToolStripMenuItem.Text = "Add Doctor";
            // 
            // manageDoctorToolStripMenuItem
            // 
            this.manageDoctorToolStripMenuItem.Name = "manageDoctorToolStripMenuItem";
            this.manageDoctorToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.manageDoctorToolStripMenuItem.Text = "Delete Doctor";
            // 
            // updateDoctorToolStripMenuItem
            // 
            this.updateDoctorToolStripMenuItem.Name = "updateDoctorToolStripMenuItem";
            this.updateDoctorToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.updateDoctorToolStripMenuItem.Text = "Update Doctor";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatientToolStripMenuItem,
            this.mangeToolStripMenuItem,
            this.deletePatientToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.patientToolStripMenuItem.Text = "Patient";
            this.patientToolStripMenuItem.Click += new System.EventHandler(this.patientToolStripMenuItem_Click);
            // 
            // addPatientToolStripMenuItem
            // 
            this.addPatientToolStripMenuItem.Name = "addPatientToolStripMenuItem";
            this.addPatientToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.addPatientToolStripMenuItem.Text = "Add  Patient";
            // 
            // mangeToolStripMenuItem
            // 
            this.mangeToolStripMenuItem.Name = "mangeToolStripMenuItem";
            this.mangeToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.mangeToolStripMenuItem.Text = "Update Patient";
            this.mangeToolStripMenuItem.Click += new System.EventHandler(this.mangeToolStripMenuItem_Click);
            // 
            // deletePatientToolStripMenuItem
            // 
            this.deletePatientToolStripMenuItem.Name = "deletePatientToolStripMenuItem";
            this.deletePatientToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.deletePatientToolStripMenuItem.Text = "Delete Patient";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateDepartmentToolStripMenuItem,
            this.deleteDepartmentToolStripMenuItem});
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.addToolStripMenuItem.Text = "Add Department";
            // 
            // updateDepartmentToolStripMenuItem
            // 
            this.updateDepartmentToolStripMenuItem.Name = "updateDepartmentToolStripMenuItem";
            this.updateDepartmentToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.updateDepartmentToolStripMenuItem.Text = "Update Department";
            // 
            // deleteDepartmentToolStripMenuItem
            // 
            this.deleteDepartmentToolStripMenuItem.Name = "deleteDepartmentToolStripMenuItem";
            this.deleteDepartmentToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.deleteDepartmentToolStripMenuItem.Text = "Delete Department";
            // 
            // bedToolStripMenuItem
            // 
            this.bedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bToolStripMenuItem,
            this.bcostToolStripMenuItem,
            this.deleteBedToolStripMenuItem});
            this.bedToolStripMenuItem.Name = "bedToolStripMenuItem";
            this.bedToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.bedToolStripMenuItem.Text = "bed";
            this.bedToolStripMenuItem.Click += new System.EventHandler(this.bedToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.bToolStripMenuItem.Text = "Add Bed";
            // 
            // bcostToolStripMenuItem
            // 
            this.bcostToolStripMenuItem.Name = "bcostToolStripMenuItem";
            this.bcostToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.bcostToolStripMenuItem.Text = "Update Bed";
            this.bcostToolStripMenuItem.Click += new System.EventHandler(this.bcostToolStripMenuItem_Click);
            // 
            // deleteBedToolStripMenuItem
            // 
            this.deleteBedToolStripMenuItem.Name = "deleteBedToolStripMenuItem";
            this.deleteBedToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.deleteBedToolStripMenuItem.Text = "Delete Bed";
            // 
            // labServiceToolStripMenuItem
            // 
            this.labServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLabServiceToolStripMenuItem,
            this.addLabServiceToolStripMenuItem1,
            this.addLabServiceToolStripMenuItem2});
            this.labServiceToolStripMenuItem.Name = "labServiceToolStripMenuItem";
            this.labServiceToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.labServiceToolStripMenuItem.Text = "Lab Service";
            this.labServiceToolStripMenuItem.Click += new System.EventHandler(this.labServiceToolStripMenuItem_Click);
            // 
            // addLabServiceToolStripMenuItem
            // 
            this.addLabServiceToolStripMenuItem.Name = "addLabServiceToolStripMenuItem";
            this.addLabServiceToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.addLabServiceToolStripMenuItem.Text = "Add Lab Service";
            // 
            // addLabServiceToolStripMenuItem1
            // 
            this.addLabServiceToolStripMenuItem1.Name = "addLabServiceToolStripMenuItem1";
            this.addLabServiceToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.addLabServiceToolStripMenuItem1.Text = "Update Lab Service";
            this.addLabServiceToolStripMenuItem1.Click += new System.EventHandler(this.addLabServiceToolStripMenuItem1_Click);
            // 
            // addLabServiceToolStripMenuItem2
            // 
            this.addLabServiceToolStripMenuItem2.Name = "addLabServiceToolStripMenuItem2";
            this.addLabServiceToolStripMenuItem2.Size = new System.Drawing.Size(220, 26);
            this.addLabServiceToolStripMenuItem2.Text = "Delete Lab Service";
            // 
            // queriesToolStripMenuItem
            // 
            this.queriesToolStripMenuItem.Name = "queriesToolStripMenuItem";
            this.queriesToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.queriesToolStripMenuItem.Text = "Search";
            this.queriesToolStripMenuItem.Click += new System.EventHandler(this.queriesToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 69);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital Managment";
            // 
            // Main_interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = global::Database_Project2.Properties.Resources.h3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_interface";
            this.Text = "Main_interface";
            this.Load += new System.EventHandler(this.Main_interface_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainEntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDepartmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bcostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLabServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLabServiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addLabServiceToolStripMenuItem2;
        private System.Windows.Forms.Label label1;
    }
}