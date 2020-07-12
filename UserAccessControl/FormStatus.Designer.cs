namespace UserAccessControl
{
    partial class FormStatus
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxCurrentPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelUserRole = new System.Windows.Forms.Label();
            this.labelUpdateMessage = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.checkBoxChangePassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Update User Information";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(156, 85);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(247, 26);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(156, 117);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.ReadOnly = true;
            this.textBoxUserName.Size = new System.Drawing.Size(247, 26);
            this.textBoxUserName.TabIndex = 1;
            // 
            // textBoxCurrentPassword
            // 
            this.textBoxCurrentPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentPassword.Location = new System.Drawing.Point(156, 180);
            this.textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            this.textBoxCurrentPassword.PasswordChar = '!';
            this.textBoxCurrentPassword.Size = new System.Drawing.Size(247, 26);
            this.textBoxCurrentPassword.TabIndex = 2;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(156, 212);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '!';
            this.textBoxNewPassword.ReadOnly = true;
            this.textBoxNewPassword.Size = new System.Drawing.Size(247, 26);
            this.textBoxNewPassword.TabIndex = 3;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(156, 244);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '!';
            this.textBoxConfirmPassword.ReadOnly = true;
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(247, 26);
            this.textBoxConfirmPassword.TabIndex = 4;
            this.textBoxConfirmPassword.TextChanged += new System.EventHandler(this.textBoxConfirmPassword_TextChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(159, 325);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(117, 34);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelUserRole
            // 
            this.labelUserRole.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserRole.Location = new System.Drawing.Point(232, 63);
            this.labelUserRole.Name = "labelUserRole";
            this.labelUserRole.Size = new System.Drawing.Size(171, 19);
            this.labelUserRole.TabIndex = 6;
            this.labelUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUpdateMessage
            // 
            this.labelUpdateMessage.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdateMessage.ForeColor = System.Drawing.Color.DarkRed;
            this.labelUpdateMessage.Location = new System.Drawing.Point(60, 295);
            this.labelUpdateMessage.Name = "labelUpdateMessage";
            this.labelUpdateMessage.Size = new System.Drawing.Size(315, 20);
            this.labelUpdateMessage.TabIndex = 7;
            this.labelUpdateMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.Location = new System.Drawing.Point(159, 273);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(244, 16);
            this.labelConfirmPassword.TabIndex = 8;
            this.labelConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxChangePassword
            // 
            this.checkBoxChangePassword.AutoSize = true;
            this.checkBoxChangePassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxChangePassword.Location = new System.Drawing.Point(281, 154);
            this.checkBoxChangePassword.Name = "checkBoxChangePassword";
            this.checkBoxChangePassword.Size = new System.Drawing.Size(122, 19);
            this.checkBoxChangePassword.TabIndex = 9;
            this.checkBoxChangePassword.Text = "Change Password";
            this.checkBoxChangePassword.UseVisualStyleBackColor = true;
            this.checkBoxChangePassword.CheckedChanged += new System.EventHandler(this.checkBoxChangePassword_CheckedChanged);
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 370);
            this.Controls.Add(this.checkBoxChangePassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelUpdateMessage);
            this.Controls.Add(this.labelUserRole);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxCurrentPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxCurrentPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelUserRole;
        private System.Windows.Forms.Label labelUpdateMessage;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.CheckBox checkBoxChangePassword;
    }
}