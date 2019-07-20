namespace WindowsFormsApplication1
{
    partial class viewBookRequest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.set_status = new System.Windows.Forms.ComboBox();
            this.mem_id = new System.Windows.Forms.TextBox();
            this.book_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.member_type = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.member_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.member_type);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.report);
            this.groupBox1.Controls.Add(this.member_id);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(28, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 530);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.update);
            this.groupBox2.Controls.Add(this.set_status);
            this.groupBox2.Controls.Add(this.mem_id);
            this.groupBox2.Controls.Add(this.book_name);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(33, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 73);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // update
            // 
            this.update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Location = new System.Drawing.Point(525, 27);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 3;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // set_status
            // 
            this.set_status.FormattingEnabled = true;
            this.set_status.Items.AddRange(new object[] {
            "Pending",
            "Approved"});
            this.set_status.Location = new System.Drawing.Point(396, 29);
            this.set_status.Name = "set_status";
            this.set_status.Size = new System.Drawing.Size(112, 21);
            this.set_status.TabIndex = 5;
            this.set_status.Text = "Select Status";
            this.set_status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.status_KeyPress);
            // 
            // mem_id
            // 
            this.mem_id.Location = new System.Drawing.Point(94, 30);
            this.mem_id.Name = "mem_id";
            this.mem_id.ReadOnly = true;
            this.mem_id.Size = new System.Drawing.Size(95, 20);
            this.mem_id.TabIndex = 2;
            // 
            // book_name
            // 
            this.book_name.Location = new System.Drawing.Point(281, 31);
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
            this.book_name.Size = new System.Drawing.Size(95, 20);
            this.book_name.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Name";
            // 
            // member_type
            // 
            this.member_type.FormattingEnabled = true;
            this.member_type.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.member_type.Location = new System.Drawing.Point(385, 22);
            this.member_type.Name = "member_type";
            this.member_type.Size = new System.Drawing.Size(112, 21);
            this.member_type.TabIndex = 5;
            this.member_type.Text = "Member Type";
            this.member_type.SelectedIndexChanged += new System.EventHandler(this.member_type_SelectedIndexChanged);
            this.member_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.status_KeyPress);
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "Pending",
            "Approved"});
            this.status.Location = new System.Drawing.Point(255, 21);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(112, 21);
            this.status.TabIndex = 5;
            this.status.Text = "Select Status";
            this.status.SelectedIndexChanged += new System.EventHandler(this.status_SelectedIndexChanged);
            this.status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.status_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(826, 361);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(179, 20);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(56, 23);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // report
            // 
            this.report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.report.ForeColor = System.Drawing.Color.Black;
            this.report.Location = new System.Drawing.Point(695, 20);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 23);
            this.report.TabIndex = 3;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // member_id
            // 
            this.member_id.Location = new System.Drawing.Point(77, 22);
            this.member_id.MaxLength = 8;
            this.member_id.Name = "member_id";
            this.member_id.Size = new System.Drawing.Size(95, 20);
            this.member_id.TabIndex = 2;
            this.member_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.member_id_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(377, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Book\'s Request";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // viewBookRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(896, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "viewBookRequest";
            this.Text = "View Book Request";
            this.Load += new System.EventHandler(this.viewBookRequest_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.TextBox member_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox member_type;
        private System.Windows.Forms.ComboBox set_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mem_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}