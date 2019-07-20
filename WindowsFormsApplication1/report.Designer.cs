namespace WindowsFormsApplication1
{
    partial class report
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.rp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateSearch = new System.Windows.Forms.Button();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.member_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.member_id = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(952, 473);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(47, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(95, 20);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // rp
            // 
            this.rp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rp.Location = new System.Drawing.Point(872, 18);
            this.rp.Name = "rp";
            this.rp.Size = new System.Drawing.Size(75, 23);
            this.rp.TabIndex = 3;
            this.rp.Text = "Report";
            this.rp.UseVisualStyleBackColor = true;
            this.rp.Click += new System.EventHandler(this.rp_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(367, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Member\'s Report";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateSearch);
            this.groupBox1.Controls.Add(this.from);
            this.groupBox1.Controls.Add(this.to);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.member_type);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.member_id);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(956, 530);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Information";
            // 
            // dateSearch
            // 
            this.dateSearch.ForeColor = System.Drawing.Color.Black;
            this.dateSearch.Location = new System.Drawing.Point(880, 22);
            this.dateSearch.Name = "dateSearch";
            this.dateSearch.Size = new System.Drawing.Size(56, 23);
            this.dateSearch.TabIndex = 7;
            this.dateSearch.Text = "Search";
            this.dateSearch.UseVisualStyleBackColor = true;
            this.dateSearch.Click += new System.EventHandler(this.dateSearch_Click);
            // 
            // from
            // 
            this.from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.from.Location = new System.Drawing.Point(651, 23);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(97, 20);
            this.from.TabIndex = 6;
            // 
            // to
            // 
            this.to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.to.Location = new System.Drawing.Point(779, 24);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(97, 20);
            this.to.TabIndex = 6;
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "issue",
            "return"});
            this.status.Location = new System.Drawing.Point(491, 22);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(104, 21);
            this.status.TabIndex = 5;
            this.status.Text = "Select Status";
            this.status.SelectedIndexChanged += new System.EventHandler(this.status_SelectedIndexChanged);
            this.status.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.member_type_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "From";
            // 
            // member_type
            // 
            this.member_type.FormattingEnabled = true;
            this.member_type.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.member_type.Location = new System.Drawing.Point(378, 22);
            this.member_type.Name = "member_type";
            this.member_type.Size = new System.Drawing.Size(104, 21);
            this.member_type.TabIndex = 5;
            this.member_type.Text = "Select Member";
            this.member_type.SelectedIndexChanged += new System.EventHandler(this.member_type_SelectedIndexChanged);
            this.member_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.member_type_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(756, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Member ID";
            // 
            // member_id
            // 
            this.member_id.Location = new System.Drawing.Point(207, 22);
            this.member_id.Name = "member_id";
            this.member_id.Size = new System.Drawing.Size(95, 20);
            this.member_id.TabIndex = 2;
            this.member_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.member_id_KeyPress);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(310, 21);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(56, 23);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(989, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rp);
            this.Name = "report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button rp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox member_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox member_id;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dateSearch;
    }
}