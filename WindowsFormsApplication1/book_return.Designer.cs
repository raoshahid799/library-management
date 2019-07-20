namespace WindowsFormsApplication1
{
    partial class book_return
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.search2 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.member_id = new System.Windows.Forms.TextBox();
            this.member_name = new System.Windows.Forms.TextBox();
            this.book_id = new System.Windows.Forms.TextBox();
            this.book_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bookissueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.librarayManagementDataSet6 = new WindowsFormsApplication1.librarayManagementDataSet6();
            this.bookissueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarayManagementDataSet1 = new WindowsFormsApplication1.librarayManagementDataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mem_name = new System.Windows.Forms.TextBox();
            this.b_name = new System.Windows.Forms.TextBox();
            this.mem_id = new System.Windows.Forms.TextBox();
            this.b_id = new System.Windows.Forms.TextBox();
            this.return_date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.detail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.issue_date = new System.Windows.Forms.DateTimePicker();
            this.issue_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.book_issueTableAdapter = new WindowsFormsApplication1.librarayManagementDataSet1TableAdapters.book_issueTableAdapter();
            this.book_issueTableAdapter1 = new WindowsFormsApplication1.librarayManagementDataSet6TableAdapters.book_issueTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookissueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarayManagementDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookissueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarayManagementDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.search2);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.member_id);
            this.groupBox2.Controls.Add(this.member_name);
            this.groupBox2.Controls.Add(this.book_id);
            this.groupBox2.Controls.Add(this.book_name);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(25, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 378);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Information";
            // 
            // search2
            // 
            this.search2.ForeColor = System.Drawing.Color.Black;
            this.search2.Location = new System.Drawing.Point(726, 20);
            this.search2.Name = "search2";
            this.search2.Size = new System.Drawing.Size(75, 23);
            this.search2.TabIndex = 7;
            this.search2.Text = "Search";
            this.search2.UseVisualStyleBackColor = true;
            this.search2.Click += new System.EventHandler(this.search2_Click);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(354, 21);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(63, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(816, 299);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // member_id
            // 
            this.member_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_id.Location = new System.Drawing.Point(256, 23);
            this.member_id.Name = "member_id";
            this.member_id.Size = new System.Drawing.Size(93, 20);
            this.member_id.TabIndex = 3;
            this.member_id.TextChanged += new System.EventHandler(this.member_id_TextChanged);
            this.member_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.member_id_KeyPress);
            // 
            // member_name
            // 
            this.member_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_name.Location = new System.Drawing.Point(94, 23);
            this.member_name.MaxLength = 8;
            this.member_name.Name = "member_name";
            this.member_name.Size = new System.Drawing.Size(91, 20);
            this.member_name.TabIndex = 1;
            this.member_name.TextChanged += new System.EventHandler(this.member_name_TextChanged);
            this.member_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress);
            // 
            // book_id
            // 
            this.book_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_id.Location = new System.Drawing.Point(634, 22);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(86, 20);
            this.book_id.TabIndex = 6;
            this.book_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.member_id_KeyPress);
            // 
            // book_name
            // 
            this.book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_name.Location = new System.Drawing.Point(491, 23);
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(80, 20);
            this.book_name.TabIndex = 5;
            this.book_name.TextChanged += new System.EventHandler(this.book_name_TextChanged);
            this.book_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(422, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Book Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Member ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Member Name";
            // 
            // bookissueBindingSource1
            // 
            this.bookissueBindingSource1.DataMember = "book_issue";
            this.bookissueBindingSource1.DataSource = this.librarayManagementDataSet6;
            // 
            // librarayManagementDataSet6
            // 
            this.librarayManagementDataSet6.DataSetName = "librarayManagementDataSet6";
            this.librarayManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookissueBindingSource
            // 
            this.bookissueBindingSource.DataMember = "book_issue";
            this.bookissueBindingSource.DataSource = this.librarayManagementDataSet1;
            // 
            // librarayManagementDataSet1
            // 
            this.librarayManagementDataSet1.DataSetName = "librarayManagementDataSet1";
            this.librarayManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Book Return Forms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Member ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Member Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Book ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Book Name";
            // 
            // mem_name
            // 
            this.mem_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mem_name.Location = new System.Drawing.Point(99, 21);
            this.mem_name.Name = "mem_name";
            this.mem_name.ReadOnly = true;
            this.mem_name.Size = new System.Drawing.Size(96, 20);
            this.mem_name.TabIndex = 2;
            // 
            // b_name
            // 
            this.b_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_name.Location = new System.Drawing.Point(494, 21);
            this.b_name.Name = "b_name";
            this.b_name.ReadOnly = true;
            this.b_name.Size = new System.Drawing.Size(100, 20);
            this.b_name.TabIndex = 2;
            // 
            // mem_id
            // 
            this.mem_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mem_id.Location = new System.Drawing.Point(297, 22);
            this.mem_id.Name = "mem_id";
            this.mem_id.ReadOnly = true;
            this.mem_id.Size = new System.Drawing.Size(96, 20);
            this.mem_id.TabIndex = 2;
            // 
            // b_id
            // 
            this.b_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_id.Location = new System.Drawing.Point(660, 22);
            this.b_id.Name = "b_id";
            this.b_id.ReadOnly = true;
            this.b_id.Size = new System.Drawing.Size(93, 20);
            this.b_id.TabIndex = 2;
            // 
            // return_date
            // 
            this.return_date.Enabled = false;
            this.return_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.return_date.Location = new System.Drawing.Point(297, 52);
            this.return_date.Name = "return_date";
            this.return_date.Size = new System.Drawing.Size(96, 20);
            this.return_date.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Return Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Detail";
            // 
            // detail
            // 
            this.detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail.Location = new System.Drawing.Point(492, 53);
            this.detail.MaxLength = 80;
            this.detail.Multiline = true;
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(202, 40);
            this.detail.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBox1.Controls.Add(this.issue_date);
            this.groupBox1.Controls.Add(this.return_date);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.issue_id);
            this.groupBox1.Controls.Add(this.b_id);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.mem_name);
            this.groupBox1.Controls.Add(this.detail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mem_id);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.b_name);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 432);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Information";
            // 
            // issue_date
            // 
            this.issue_date.Enabled = false;
            this.issue_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.issue_date.Location = new System.Drawing.Point(99, 52);
            this.issue_date.Name = "issue_date";
            this.issue_date.Size = new System.Drawing.Size(96, 20);
            this.issue_date.TabIndex = 5;
            // 
            // issue_id
            // 
            this.issue_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue_id.Location = new System.Drawing.Point(99, 80);
            this.issue_id.Name = "issue_id";
            this.issue_id.ReadOnly = true;
            this.issue_id.Size = new System.Drawing.Size(96, 20);
            this.issue_id.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Issue ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Issue Date";
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.save.Location = new System.Drawing.Point(361, 553);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(133, 33);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // book_issueTableAdapter
            // 
            this.book_issueTableAdapter.ClearBeforeFill = true;
            // 
            // book_issueTableAdapter1
            // 
            this.book_issueTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(751, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.report_Click);
            // 
            // book_return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(891, 598);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "book_return";
            this.Text = "Book Return";
            this.Load += new System.EventHandler(this.book_return_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookissueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarayManagementDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookissueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarayManagementDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox member_name;
        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox member_id;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private librarayManagementDataSet1 librarayManagementDataSet1;
        private System.Windows.Forms.BindingSource bookissueBindingSource;
        private librarayManagementDataSet1TableAdapters.book_issueTableAdapter book_issueTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mem_name;
        private System.Windows.Forms.TextBox b_name;
        private System.Windows.Forms.TextBox mem_id;
        private System.Windows.Forms.TextBox b_id;
        private System.Windows.Forms.DateTimePicker return_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox detail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DateTimePicker issue_date;
        private System.Windows.Forms.Label label10;
        private librarayManagementDataSet6 librarayManagementDataSet6;
        private System.Windows.Forms.BindingSource bookissueBindingSource1;
        private librarayManagementDataSet6TableAdapters.book_issueTableAdapter book_issueTableAdapter1;
        private System.Windows.Forms.TextBox issue_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button search2;
        private System.Windows.Forms.Button button1;
    }
}