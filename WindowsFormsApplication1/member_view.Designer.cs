namespace WindowsFormsApplication1
{
    partial class member_view
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.member_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memberidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberregistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarayManagementDataSet7 = new WindowsFormsApplication1.librarayManagementDataSet7();
            this.member_id = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.member_registrationTableAdapter = new WindowsFormsApplication1.librarayManagementDataSet7TableAdapters.member_registrationTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberregistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarayManagementDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.member_type);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.member_id);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.report);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(5, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 530);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Information";
            // 
            // member_type
            // 
            this.member_type.FormattingEnabled = true;
            this.member_type.Items.AddRange(new object[] {
            "Teacher",
            "Student"});
            this.member_type.Location = new System.Drawing.Point(444, 22);
            this.member_type.Name = "member_type";
            this.member_type.Size = new System.Drawing.Size(105, 21);
            this.member_type.TabIndex = 5;
            this.member_type.Text = "Select Member";
            this.member_type.SelectedIndexChanged += new System.EventHandler(this.member_type_SelectedIndexChanged);
            this.member_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.member_type_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Member ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.membertypeDataGridViewTextBoxColumn,
            this.regnoDataGridViewTextBoxColumn,
            this.rollnoDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.fineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memberregistrationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(868, 473);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // memberidDataGridViewTextBoxColumn
            // 
            this.memberidDataGridViewTextBoxColumn.DataPropertyName = "member_id";
            this.memberidDataGridViewTextBoxColumn.HeaderText = "Member ID";
            this.memberidDataGridViewTextBoxColumn.Name = "memberidDataGridViewTextBoxColumn";
            this.memberidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // membertypeDataGridViewTextBoxColumn
            // 
            this.membertypeDataGridViewTextBoxColumn.DataPropertyName = "member_type";
            this.membertypeDataGridViewTextBoxColumn.HeaderText = "Member Type";
            this.membertypeDataGridViewTextBoxColumn.Name = "membertypeDataGridViewTextBoxColumn";
            this.membertypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regnoDataGridViewTextBoxColumn
            // 
            this.regnoDataGridViewTextBoxColumn.DataPropertyName = "reg_no";
            this.regnoDataGridViewTextBoxColumn.HeaderText = "Reg No.";
            this.regnoDataGridViewTextBoxColumn.Name = "regnoDataGridViewTextBoxColumn";
            this.regnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rollnoDataGridViewTextBoxColumn
            // 
            this.rollnoDataGridViewTextBoxColumn.DataPropertyName = "roll_no";
            this.rollnoDataGridViewTextBoxColumn.HeaderText = "Roll No.";
            this.rollnoDataGridViewTextBoxColumn.Name = "rollnoDataGridViewTextBoxColumn";
            this.rollnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "session";
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            this.sessionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "Course Name";
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            this.coursenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fineDataGridViewTextBoxColumn
            // 
            this.fineDataGridViewTextBoxColumn.DataPropertyName = "fine";
            this.fineDataGridViewTextBoxColumn.HeaderText = "Fine";
            this.fineDataGridViewTextBoxColumn.Name = "fineDataGridViewTextBoxColumn";
            this.fineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberregistrationBindingSource
            // 
            this.memberregistrationBindingSource.DataMember = "member_registration";
            this.memberregistrationBindingSource.DataSource = this.librarayManagementDataSet7;
            // 
            // librarayManagementDataSet7
            // 
            this.librarayManagementDataSet7.DataSetName = "librarayManagementDataSet7";
            this.librarayManagementDataSet7.EnforceConstraints = false;
            this.librarayManagementDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // member_id
            // 
            this.member_id.Location = new System.Drawing.Point(269, 22);
            this.member_id.MaxLength = 8;
            this.member_id.Name = "member_id";
            this.member_id.Size = new System.Drawing.Size(95, 20);
            this.member_id.TabIndex = 2;
            this.member_id.TextChanged += new System.EventHandler(this.member_id_TextChanged);
            this.member_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.member_id_KeyPress);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(370, 21);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(55, 23);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // report
            // 
            this.report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.report.ForeColor = System.Drawing.Color.Black;
            this.report.Location = new System.Drawing.Point(770, 20);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 23);
            this.report.TabIndex = 7;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(103, 22);
            this.name.MaxLength = 15;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(95, 20);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(343, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Member\'s Report";
            // 
            // member_registrationTableAdapter
            // 
            this.member_registrationTableAdapter.ClearBeforeFill = true;
            // 
            // member_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(888, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "member_view";
            this.Text = "Member Report";
            this.Load += new System.EventHandler(this.member_view_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberregistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarayManagementDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox member_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox member_id;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private librarayManagementDataSet7 librarayManagementDataSet7;
        private System.Windows.Forms.BindingSource memberregistrationBindingSource;
        private librarayManagementDataSet7TableAdapters.member_registrationTableAdapter member_registrationTableAdapter;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineDataGridViewTextBoxColumn;

    }
}