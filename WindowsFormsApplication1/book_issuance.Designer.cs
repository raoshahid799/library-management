namespace WindowsFormsApplication1
{
    partial class book_issuance
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
            this.label8 = new System.Windows.Forms.Label();
            this.issue_book = new System.Windows.Forms.TextBox();
            this.department = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.member_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.student_search2 = new System.Windows.Forms.Button();
            this.student_search = new System.Windows.Forms.Button();
            this.member_type = new System.Windows.Forms.TextBox();
            this.mem_id = new System.Windows.Forms.TextBox();
            this.reg_textBox = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.student_ComboBox = new System.Windows.Forms.ComboBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.laber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.memberregistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.isbn_search_text = new System.Windows.Forms.TextBox();
            this.atuthor_text = new System.Windows.Forms.TextBox();
            this.edition_text = new System.Windows.Forms.TextBox();
            this.book_id_text = new System.Windows.Forms.TextBox();
            this.book_id = new System.Windows.Forms.TextBox();
            this.book_name_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.book_search1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.isbn_text = new System.Windows.Forms.TextBox();
            this.book_detail = new System.Windows.Forms.Button();
            this.book_search2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.book_combo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.return_date = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.detail = new System.Windows.Forms.TextBox();
            this.issue_date = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.issue_button = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.member_registrationTableAdapter = new WindowsFormsApplication1.librarayManagementDataSetTableAdapters.member_registrationTableAdapter();
            this.librarayManagementDataSet = new WindowsFormsApplication1.librarayManagementDataSet();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberregistrationBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librarayManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.issue_book);
            this.groupBox1.Controls.Add(this.department);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.member_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.student_search2);
            this.groupBox1.Controls.Add(this.student_search);
            this.groupBox1.Controls.Add(this.member_type);
            this.groupBox1.Controls.Add(this.mem_id);
            this.groupBox1.Controls.Add(this.reg_textBox);
            this.groupBox1.Controls.Add(this.last_name);
            this.groupBox1.Controls.Add(this.student_ComboBox);
            this.groupBox1.Controls.Add(this.first_name);
            this.groupBox1.Controls.Add(this.laber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(38, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Last Name";
            // 
            // issue_book
            // 
            this.issue_book.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.issue_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.issue_book.Location = new System.Drawing.Point(480, 142);
            this.issue_book.Name = "issue_book";
            this.issue_book.ReadOnly = true;
            this.issue_book.Size = new System.Drawing.Size(173, 23);
            this.issue_book.TabIndex = 111;
            this.issue_book.TabStop = false;
            // 
            // department
            // 
            this.department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.department.Location = new System.Drawing.Point(480, 109);
            this.department.Name = "department";
            this.department.ReadOnly = true;
            this.department.Size = new System.Drawing.Size(173, 23);
            this.department.TabIndex = 111;
            this.department.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(38, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Member Type";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(372, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Memer ID";
            // 
            // member_id
            // 
            this.member_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.member_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.member_id.Location = new System.Drawing.Point(480, 75);
            this.member_id.Name = "member_id";
            this.member_id.ReadOnly = true;
            this.member_id.Size = new System.Drawing.Size(173, 23);
            this.member_id.TabIndex = 111;
            this.member_id.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(372, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Issued Book";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(372, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Department";
            // 
            // student_search2
            // 
            this.student_search2.ForeColor = System.Drawing.Color.Black;
            this.student_search2.Location = new System.Drawing.Point(596, 25);
            this.student_search2.Name = "student_search2";
            this.student_search2.Size = new System.Drawing.Size(75, 23);
            this.student_search2.TabIndex = 5;
            this.student_search2.Text = "Search";
            this.student_search2.UseVisualStyleBackColor = true;
            this.student_search2.Click += new System.EventHandler(this.student_search2_Click);
            // 
            // student_search
            // 
            this.student_search.ForeColor = System.Drawing.Color.Black;
            this.student_search.Location = new System.Drawing.Point(343, 25);
            this.student_search.Name = "student_search";
            this.student_search.Size = new System.Drawing.Size(75, 23);
            this.student_search.TabIndex = 3;
            this.student_search.Text = "Search";
            this.student_search.UseVisualStyleBackColor = true;
            this.student_search.Click += new System.EventHandler(this.student_search_Click);
            // 
            // member_type
            // 
            this.member_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.member_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.member_type.Location = new System.Drawing.Point(145, 140);
            this.member_type.Name = "member_type";
            this.member_type.ReadOnly = true;
            this.member_type.Size = new System.Drawing.Size(165, 23);
            this.member_type.TabIndex = 111;
            this.member_type.TabStop = false;
            // 
            // mem_id
            // 
            this.mem_id.Location = new System.Drawing.Point(490, 26);
            this.mem_id.Name = "mem_id";
            this.mem_id.Size = new System.Drawing.Size(100, 20);
            this.mem_id.TabIndex = 4;
            this.mem_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mem_id_KeyPress);
            // 
            // reg_textBox
            // 
            this.reg_textBox.Location = new System.Drawing.Point(237, 26);
            this.reg_textBox.Name = "reg_textBox";
            this.reg_textBox.Size = new System.Drawing.Size(100, 20);
            this.reg_textBox.TabIndex = 2;
            this.reg_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reg_textBox_KeyPress);
            // 
            // last_name
            // 
            this.last_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.last_name.Location = new System.Drawing.Point(145, 109);
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Size = new System.Drawing.Size(166, 23);
            this.last_name.TabIndex = 1111;
            this.last_name.TabStop = false;
            // 
            // student_ComboBox
            // 
            this.student_ComboBox.FormattingEnabled = true;
            this.student_ComboBox.Location = new System.Drawing.Point(6, 26);
            this.student_ComboBox.Name = "student_ComboBox";
            this.student_ComboBox.Size = new System.Drawing.Size(172, 21);
            this.student_ComboBox.TabIndex = 1;
            this.student_ComboBox.Text = "Search by Name";
            this.student_ComboBox.SelectedIndexChanged += new System.EventHandler(this.student_ComboBox_SelectedIndexChanged);
            this.student_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.student_ComboBox_KeyPress);
            // 
            // first_name
            // 
            this.first_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.first_name.Location = new System.Drawing.Point(145, 75);
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Size = new System.Drawing.Size(166, 23);
            this.first_name.TabIndex = 1111;
            this.first_name.TabStop = false;
            // 
            // laber
            // 
            this.laber.AutoSize = true;
            this.laber.Location = new System.Drawing.Point(429, 29);
            this.laber.Name = "laber";
            this.laber.Size = new System.Drawing.Size(59, 13);
            this.laber.TabIndex = 0;
            this.laber.Text = "Member ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No:";
            // 
            // memberregistrationBindingSource
            // 
            this.memberregistrationBindingSource.DataMember = "member_registration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.isbn_search_text);
            this.groupBox2.Controls.Add(this.atuthor_text);
            this.groupBox2.Controls.Add(this.edition_text);
            this.groupBox2.Controls.Add(this.book_id_text);
            this.groupBox2.Controls.Add(this.book_id);
            this.groupBox2.Controls.Add(this.book_name_text);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.book_search1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.isbn_text);
            this.groupBox2.Controls.Add(this.book_detail);
            this.groupBox2.Controls.Add(this.book_search2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.book_combo);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 166);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Information";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(38, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Author Name";
            // 
            // isbn_search_text
            // 
            this.isbn_search_text.Location = new System.Drawing.Point(237, 29);
            this.isbn_search_text.MaxLength = 13;
            this.isbn_search_text.Name = "isbn_search_text";
            this.isbn_search_text.Size = new System.Drawing.Size(100, 20);
            this.isbn_search_text.TabIndex = 7;
            this.isbn_search_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mem_id_KeyPress);
            // 
            // atuthor_text
            // 
            this.atuthor_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.atuthor_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.atuthor_text.Location = new System.Drawing.Point(145, 100);
            this.atuthor_text.Name = "atuthor_text";
            this.atuthor_text.ReadOnly = true;
            this.atuthor_text.Size = new System.Drawing.Size(166, 23);
            this.atuthor_text.TabIndex = 111;
            this.atuthor_text.TabStop = false;
            // 
            // edition_text
            // 
            this.edition_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edition_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.edition_text.Location = new System.Drawing.Point(480, 100);
            this.edition_text.Name = "edition_text";
            this.edition_text.ReadOnly = true;
            this.edition_text.Size = new System.Drawing.Size(173, 23);
            this.edition_text.TabIndex = 1111;
            this.edition_text.TabStop = false;
            // 
            // book_id_text
            // 
            this.book_id_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.book_id_text.Location = new System.Drawing.Point(145, 131);
            this.book_id_text.Name = "book_id_text";
            this.book_id_text.ReadOnly = true;
            this.book_id_text.Size = new System.Drawing.Size(165, 23);
            this.book_id_text.TabIndex = 1111;
            this.book_id_text.TabStop = false;
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(492, 30);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(100, 20);
            this.book_id.TabIndex = 9;
            this.book_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mem_id_KeyPress);
            // 
            // book_name_text
            // 
            this.book_name_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.book_name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.book_name_text.Location = new System.Drawing.Point(145, 66);
            this.book_name_text.Name = "book_name_text";
            this.book_name_text.ReadOnly = true;
            this.book_name_text.Size = new System.Drawing.Size(166, 23);
            this.book_name_text.TabIndex = 13;
            this.book_name_text.TabStop = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(372, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "ISBN No";
            // 
            // book_search1
            // 
            this.book_search1.ForeColor = System.Drawing.Color.Black;
            this.book_search1.Location = new System.Drawing.Point(343, 28);
            this.book_search1.Name = "book_search1";
            this.book_search1.Size = new System.Drawing.Size(75, 23);
            this.book_search1.TabIndex = 8;
            this.book_search1.Text = "Search";
            this.book_search1.UseVisualStyleBackColor = true;
            this.book_search1.Click += new System.EventHandler(this.book_search1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Book ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(437, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Book ID";
            // 
            // isbn_text
            // 
            this.isbn_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isbn_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isbn_text.Location = new System.Drawing.Point(480, 66);
            this.isbn_text.Name = "isbn_text";
            this.isbn_text.ReadOnly = true;
            this.isbn_text.Size = new System.Drawing.Size(173, 23);
            this.isbn_text.TabIndex = 111;
            this.isbn_text.TabStop = false;
            // 
            // book_detail
            // 
            this.book_detail.ForeColor = System.Drawing.Color.Black;
            this.book_detail.Location = new System.Drawing.Point(365, 132);
            this.book_detail.Name = "book_detail";
            this.book_detail.Size = new System.Drawing.Size(92, 23);
            this.book_detail.TabIndex = 13;
            this.book_detail.Text = "Book Details";
            this.book_detail.UseVisualStyleBackColor = true;
            this.book_detail.Click += new System.EventHandler(this.book_detail_Click);
            // 
            // book_search2
            // 
            this.book_search2.ForeColor = System.Drawing.Color.Black;
            this.book_search2.Location = new System.Drawing.Point(599, 29);
            this.book_search2.Name = "book_search2";
            this.book_search2.Size = new System.Drawing.Size(75, 23);
            this.book_search2.TabIndex = 10;
            this.book_search2.Text = "Search";
            this.book_search2.UseVisualStyleBackColor = true;
            this.book_search2.Click += new System.EventHandler(this.book_search2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(184, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "ISBN No.";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(38, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Book Name";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(372, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Edition";
            // 
            // book_combo
            // 
            this.book_combo.FormattingEnabled = true;
            this.book_combo.Location = new System.Drawing.Point(6, 29);
            this.book_combo.Name = "book_combo";
            this.book_combo.Size = new System.Drawing.Size(172, 21);
            this.book_combo.TabIndex = 6;
            this.book_combo.Text = "Search by Name";
            this.book_combo.SelectedIndexChanged += new System.EventHandler(this.book_combo_SelectedIndexChanged);
            this.book_combo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.student_ComboBox_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.return_date);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.detail);
            this.groupBox3.Controls.Add(this.issue_date);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(691, 111);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Issuance Details";
            // 
            // return_date
            // 
            this.return_date.Enabled = false;
            this.return_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.return_date.Location = new System.Drawing.Point(136, 62);
            this.return_date.Name = "return_date";
            this.return_date.Size = new System.Drawing.Size(103, 20);
            this.return_date.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(38, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Issue Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(38, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Return Date";
            // 
            // detail
            // 
            this.detail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.detail.Location = new System.Drawing.Point(351, 27);
            this.detail.MaxLength = 79;
            this.detail.Multiline = true;
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(173, 58);
            this.detail.TabIndex = 11;
            // 
            // issue_date
            // 
            this.issue_date.Enabled = false;
            this.issue_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.issue_date.Location = new System.Drawing.Point(136, 26);
            this.issue_date.Name = "issue_date";
            this.issue_date.Size = new System.Drawing.Size(103, 20);
            this.issue_date.TabIndex = 5;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(294, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 17);
            this.label19.TabIndex = 7;
            this.label19.Text = "Details";
            // 
            // issue_button
            // 
            this.issue_button.Location = new System.Drawing.Point(305, 535);
            this.issue_button.Name = "issue_button";
            this.issue_button.Size = new System.Drawing.Size(161, 45);
            this.issue_button.TabIndex = 12;
            this.issue_button.Text = "Issue";
            this.issue_button.UseVisualStyleBackColor = true;
            this.issue_button.Click += new System.EventHandler(this.issue_button_Click);
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.Location = new System.Drawing.Point(297, 96);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "Book Issuance Form";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(266, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(212, 26);
            this.label17.TabIndex = 7;
            this.label17.Text = "Book Issuance Form";
            // 
            // member_registrationTableAdapter
            // 
            this.member_registrationTableAdapter.ClearBeforeFill = true;
            // 
            // librarayManagementDataSet
            // 
            this.librarayManagementDataSet.DataSetName = "librarayManagementDataSet";
            this.librarayManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_issuance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(820, 593);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.issue_button);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "book_issuance";
            this.Text = "Book Issuance Form";
            this.Load += new System.EventHandler(this.book_issuance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberregistrationBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.librarayManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button student_search;
        private System.Windows.Forms.TextBox reg_textBox;
        private System.Windows.Forms.ComboBox student_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox issue_book;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox member_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox member_type;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edition_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox isbn_text;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button book_search1;
        private System.Windows.Forms.TextBox isbn_search_text;
        private System.Windows.Forms.TextBox atuthor_text;
        private System.Windows.Forms.ComboBox book_combo;
        private System.Windows.Forms.TextBox book_name_text;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button book_search2;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker return_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker issue_date;
        private System.Windows.Forms.Button issue_button;
        private System.Windows.Forms.Button book_detail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.BindingSource memberregistrationBindingSource;
        private librarayManagementDataSetTableAdapters.member_registrationTableAdapter member_registrationTableAdapter;
        private System.Windows.Forms.Button student_search2;
        private System.Windows.Forms.TextBox mem_id;
        private System.Windows.Forms.Label laber;
        private System.Windows.Forms.TextBox book_id_text;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox detail;
        private System.Windows.Forms.Label label19;
        private librarayManagementDataSet librarayManagementDataSet;
    }
}