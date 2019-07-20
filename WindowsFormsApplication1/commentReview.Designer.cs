namespace WindowsFormsApplication1
{
    partial class commentReview
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
            this.student_pane = new System.Windows.Forms.FlowLayoutPanel();
            this.teacher_pane = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.author_name = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.book_name = new System.Windows.Forms.TextBox();
            this.book_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.save = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.student_ComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mem_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.member_id = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.comment = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // student_pane
            // 
            this.student_pane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.student_pane.AutoScroll = true;
            this.student_pane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.student_pane.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.student_pane.Location = new System.Drawing.Point(23, 275);
            this.student_pane.Name = "student_pane";
            this.student_pane.Padding = new System.Windows.Forms.Padding(5);
            this.student_pane.Size = new System.Drawing.Size(460, 326);
            this.student_pane.TabIndex = 0;
            this.student_pane.WrapContents = false;
            // 
            // teacher_pane
            // 
            this.teacher_pane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.teacher_pane.AutoScroll = true;
            this.teacher_pane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.teacher_pane.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.teacher_pane.Location = new System.Drawing.Point(516, 275);
            this.teacher_pane.Name = "teacher_pane";
            this.teacher_pane.Padding = new System.Windows.Forms.Padding(5);
            this.teacher_pane.Size = new System.Drawing.Size(466, 326);
            this.teacher_pane.TabIndex = 0;
            this.teacher_pane.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(523, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teacher\'s Reviews";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student\'s Comments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(277, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 149);
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "ISBN No.";
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(98, 108);
            this.isbn.MaxLength = 13;
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            this.isbn.Size = new System.Drawing.Size(155, 20);
            this.isbn.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Author Name";
            // 
            // author_name
            // 
            this.author_name.Location = new System.Drawing.Point(98, 80);
            this.author_name.MaxLength = 49;
            this.author_name.Name = "author_name";
            this.author_name.ReadOnly = true;
            this.author_name.Size = new System.Drawing.Size(153, 20);
            this.author_name.TabIndex = 69;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(328, 18);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 13);
            this.label24.TabIndex = 57;
            this.label24.Text = "Cover Photo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Book ID";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 58);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 55;
            this.label23.Text = "Book Name";
            // 
            // book_name
            // 
            this.book_name.Location = new System.Drawing.Point(98, 54);
            this.book_name.MaxLength = 49;
            this.book_name.Name = "book_name";
            this.book_name.ReadOnly = true;
            this.book_name.Size = new System.Drawing.Size(155, 20);
            this.book_name.TabIndex = 68;
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(98, 28);
            this.book_id.MaxLength = 6;
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Size = new System.Drawing.Size(155, 20);
            this.book_id.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.book_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.book_name);
            this.groupBox1.Controls.Add(this.isbn);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.author_name);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(34, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 206);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(361, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Book\'s Comments And Reviews";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.save);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.student_ComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.mem_id);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.member_id);
            this.groupBox2.Controls.Add(this.last_name);
            this.groupBox2.Controls.Add(this.comment);
            this.groupBox2.Controls.Add(this.first_name);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(516, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 206);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Member Information";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // save
            // 
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(285, 167);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(67, 23);
            this.save.TabIndex = 75;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(200, 26);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(67, 23);
            this.search.TabIndex = 75;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // student_ComboBox
            // 
            this.student_ComboBox.FormattingEnabled = true;
            this.student_ComboBox.Location = new System.Drawing.Point(293, 28);
            this.student_ComboBox.Name = "student_ComboBox";
            this.student_ComboBox.Size = new System.Drawing.Size(138, 21);
            this.student_ComboBox.TabIndex = 68;
            this.student_ComboBox.Text = "Search by Name";
            this.student_ComboBox.SelectedIndexChanged += new System.EventHandler(this.student_ComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Search by ID";
            // 
            // mem_id
            // 
            this.mem_id.Location = new System.Drawing.Point(98, 28);
            this.mem_id.MaxLength = 6;
            this.mem_id.Name = "mem_id";
            this.mem_id.Size = new System.Drawing.Size(96, 20);
            this.mem_id.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Member ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "First Name";
            // 
            // member_id
            // 
            this.member_id.Location = new System.Drawing.Point(103, 129);
            this.member_id.MaxLength = 13;
            this.member_id.Name = "member_id";
            this.member_id.ReadOnly = true;
            this.member_id.Size = new System.Drawing.Size(96, 20);
            this.member_id.TabIndex = 74;
            // 
            // last_name
            // 
            this.last_name.Location = new System.Drawing.Point(102, 105);
            this.last_name.MaxLength = 13;
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Size = new System.Drawing.Size(96, 20);
            this.last_name.TabIndex = 74;
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(213, 77);
            this.comment.MaxLength = 499;
            this.comment.Multiline = true;
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(218, 84);
            this.comment.TabIndex = 74;
            this.comment.Text = "Enter Comments or Review";
            // 
            // first_name
            // 
            this.first_name.Location = new System.Drawing.Point(102, 77);
            this.first_name.MaxLength = 13;
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Size = new System.Drawing.Size(96, 20);
            this.first_name.TabIndex = 74;
            // 
            // commentReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1006, 634);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacher_pane);
            this.Controls.Add(this.student_pane);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "commentReview";
            this.Text = "Reviews On Books";
            this.Load += new System.EventHandler(this.commentReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel student_pane;
        private System.Windows.Forms.FlowLayoutPanel teacher_pane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox author_name;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mem_id;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox student_ComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox member_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
    }
}