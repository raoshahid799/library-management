namespace WindowsFormsApplication1
{
    partial class account_manage
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
            this.login_button = new System.Windows.Forms.Button();
            this.new_pass = new System.Windows.Forms.TextBox();
            this.new_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.current_user = new System.Windows.Forms.TextBox();
            this.current_pass = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.ForeColor = System.Drawing.Color.Black;
            this.login_button.Location = new System.Drawing.Point(201, 185);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Save";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // new_pass
            // 
            this.new_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.new_pass.Location = new System.Drawing.Point(180, 140);
            this.new_pass.MaxLength = 14;
            this.new_pass.Name = "new_pass";
            this.new_pass.PasswordChar = '*';
            this.new_pass.Size = new System.Drawing.Size(143, 24);
            this.new_pass.TabIndex = 4;
            this.new_pass.UseSystemPasswordChar = true;
            // 
            // new_user
            // 
            this.new_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.new_user.Location = new System.Drawing.Point(180, 105);
            this.new_user.MaxLength = 14;
            this.new_user.Name = "new_user";
            this.new_user.Size = new System.Drawing.Size(143, 24);
            this.new_user.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(22, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(176, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome User !";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(22, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "New User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(22, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Current User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(22, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Current Password";
            // 
            // current_user
            // 
            this.current_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.current_user.Location = new System.Drawing.Point(180, 36);
            this.current_user.MaxLength = 14;
            this.current_user.Name = "current_user";
            this.current_user.Size = new System.Drawing.Size(143, 24);
            this.current_user.TabIndex = 1;
            // 
            // current_pass
            // 
            this.current_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.current_pass.Location = new System.Drawing.Point(180, 71);
            this.current_pass.MaxLength = 14;
            this.current_pass.Name = "current_pass";
            this.current_pass.PasswordChar = '*';
            this.current_pass.Size = new System.Drawing.Size(143, 24);
            this.current_pass.TabIndex = 2;
            this.current_pass.UseSystemPasswordChar = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.login_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.current_pass);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.new_pass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.current_user);
            this.groupBox1.Controls.Add(this.new_user);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(79, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 241);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // account_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(525, 423);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "account_manage";
            this.Text = "Account Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox new_pass;
        private System.Windows.Forms.TextBox new_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox current_user;
        private System.Windows.Forms.TextBox current_pass;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}