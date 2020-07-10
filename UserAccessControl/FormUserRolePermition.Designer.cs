namespace UserAccessControl
{
    partial class FormUserRolePermition
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
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxUserPermition = new System.Windows.Forms.CheckBox();
            this.checkBoxUser = new System.Windows.Forms.CheckBox();
            this.checkBoxCreate = new System.Windows.Forms.CheckBox();
            this.checkBoxExit = new System.Windows.Forms.CheckBox();
            this.checkBoxFile = new System.Windows.Forms.CheckBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelAddRole = new System.Windows.Forms.Label();
            this.panelAddRole = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridViewRole = new System.Windows.Forms.DataGridView();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRoleMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panelAddRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Role Access Permition";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(200, 62);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(143, 27);
            this.comboBoxRole.TabIndex = 0;
            this.comboBoxRole.SelectedIndexChanged += new System.EventHandler(this.comboBoxRole_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxStatus);
            this.groupBox1.Controls.Add(this.checkBoxUserPermition);
            this.groupBox1.Controls.Add(this.checkBoxUser);
            this.groupBox1.Controls.Add(this.checkBoxCreate);
            this.groupBox1.Controls.Add(this.checkBoxExit);
            this.groupBox1.Controls.Add(this.checkBoxFile);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 299);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu List";
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(27, 187);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(65, 23);
            this.checkBoxStatus.TabIndex = 2;
            this.checkBoxStatus.Text = "Status";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // checkBoxUserPermition
            // 
            this.checkBoxUserPermition.AutoSize = true;
            this.checkBoxUserPermition.Location = new System.Drawing.Point(27, 157);
            this.checkBoxUserPermition.Name = "checkBoxUserPermition";
            this.checkBoxUserPermition.Size = new System.Drawing.Size(118, 23);
            this.checkBoxUserPermition.TabIndex = 1;
            this.checkBoxUserPermition.Text = "User Permition";
            this.checkBoxUserPermition.UseVisualStyleBackColor = true;
            // 
            // checkBoxUser
            // 
            this.checkBoxUser.AutoSize = true;
            this.checkBoxUser.Location = new System.Drawing.Point(46, 127);
            this.checkBoxUser.Name = "checkBoxUser";
            this.checkBoxUser.Size = new System.Drawing.Size(57, 23);
            this.checkBoxUser.TabIndex = 0;
            this.checkBoxUser.Text = "User";
            this.checkBoxUser.UseVisualStyleBackColor = true;
            this.checkBoxUser.CheckedChanged += new System.EventHandler(this.checkBoxUser_CheckedChanged);
            // 
            // checkBoxCreate
            // 
            this.checkBoxCreate.AutoSize = true;
            this.checkBoxCreate.Location = new System.Drawing.Point(27, 97);
            this.checkBoxCreate.Name = "checkBoxCreate";
            this.checkBoxCreate.Size = new System.Drawing.Size(69, 23);
            this.checkBoxCreate.TabIndex = 5;
            this.checkBoxCreate.Text = "Create";
            this.checkBoxCreate.UseVisualStyleBackColor = true;
            this.checkBoxCreate.CheckedChanged += new System.EventHandler(this.checkBoxCreate_CheckedChanged);
            // 
            // checkBoxExit
            // 
            this.checkBoxExit.AutoSize = true;
            this.checkBoxExit.Location = new System.Drawing.Point(46, 67);
            this.checkBoxExit.Name = "checkBoxExit";
            this.checkBoxExit.Size = new System.Drawing.Size(51, 23);
            this.checkBoxExit.TabIndex = 4;
            this.checkBoxExit.Text = "Exit";
            this.checkBoxExit.UseVisualStyleBackColor = true;
            this.checkBoxExit.CheckedChanged += new System.EventHandler(this.checkBoxExit_CheckedChanged);
            // 
            // checkBoxFile
            // 
            this.checkBoxFile.AutoSize = true;
            this.checkBoxFile.Location = new System.Drawing.Point(27, 38);
            this.checkBoxFile.Name = "checkBoxFile";
            this.checkBoxFile.Size = new System.Drawing.Size(50, 23);
            this.checkBoxFile.TabIndex = 3;
            this.checkBoxFile.Text = "File";
            this.checkBoxFile.UseVisualStyleBackColor = true;
            this.checkBoxFile.CheckedChanged += new System.EventHandler(this.checkBoxFile_CheckedChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(385, 404);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 42);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelAddRole
            // 
            this.labelAddRole.AutoSize = true;
            this.labelAddRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAddRole.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddRole.Location = new System.Drawing.Point(354, 62);
            this.labelAddRole.Name = "labelAddRole";
            this.labelAddRole.Size = new System.Drawing.Size(24, 26);
            this.labelAddRole.TabIndex = 3;
            this.labelAddRole.Text = "+";
            this.labelAddRole.Click += new System.EventHandler(this.labelAddRole_Click);
            // 
            // panelAddRole
            // 
            this.panelAddRole.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelAddRole.Controls.Add(this.buttonAdd);
            this.panelAddRole.Controls.Add(this.dataGridViewRole);
            this.panelAddRole.Controls.Add(this.textBoxRole);
            this.panelAddRole.Controls.Add(this.label3);
            this.panelAddRole.Location = new System.Drawing.Point(163, 91);
            this.panelAddRole.Name = "panelAddRole";
            this.panelAddRole.Size = new System.Drawing.Size(215, 233);
            this.panelAddRole.TabIndex = 4;
            this.panelAddRole.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(122, 59);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 26);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridViewRole
            // 
            this.dataGridViewRole.AllowUserToAddRows = false;
            this.dataGridViewRole.AllowUserToDeleteRows = false;
            this.dataGridViewRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRole.Location = new System.Drawing.Point(18, 102);
            this.dataGridViewRole.Name = "dataGridViewRole";
            this.dataGridViewRole.ReadOnly = true;
            this.dataGridViewRole.Size = new System.Drawing.Size(179, 113);
            this.dataGridViewRole.TabIndex = 2;
            // 
            // textBoxRole
            // 
            this.textBoxRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRole.Location = new System.Drawing.Point(57, 27);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(140, 26);
            this.textBoxRole.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Role";
            // 
            // labelRoleMessage
            // 
            this.labelRoleMessage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoleMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.labelRoleMessage.Location = new System.Drawing.Point(75, 427);
            this.labelRoleMessage.Name = "labelRoleMessage";
            this.labelRoleMessage.Size = new System.Drawing.Size(301, 19);
            this.labelRoleMessage.TabIndex = 0;
            this.labelRoleMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormUserRolePermition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 458);
            this.Controls.Add(this.panelAddRole);
            this.Controls.Add(this.labelAddRole);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRoleMessage);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormUserRolePermition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelAddRole.ResumeLayout(false);
            this.panelAddRole.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxUserPermition;
        private System.Windows.Forms.CheckBox checkBoxUser;
        private System.Windows.Forms.CheckBox checkBoxCreate;
        private System.Windows.Forms.CheckBox checkBoxExit;
        private System.Windows.Forms.CheckBox checkBoxFile;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelAddRole;
        private System.Windows.Forms.Panel panelAddRole;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewRole;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRoleMessage;
    }
}