namespace WindowsFormsApplication1
{
    partial class book_edit
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
            this.pub_year = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cover = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.book_type = new System.Windows.Forms.ComboBox();
            this.department = new System.Windows.Forms.ComboBox();
            this.cover_box = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rank = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.page = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.author_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.book_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.book_id = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pub_year
            // 
            this.pub_year.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pub_year.Location = new System.Drawing.Point(511, 260);
            this.pub_year.Name = "pub_year";
            this.pub_year.Size = new System.Drawing.Size(100, 20);
            this.pub_year.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(618, 263);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 20);
            this.label20.TabIndex = 38;
            this.label20.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(617, 294);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 20);
            this.label18.TabIndex = 39;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(411, 171);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 20);
            this.label19.TabIndex = 40;
            this.label19.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(410, 265);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 20);
            this.label21.TabIndex = 42;
            this.label21.Text = "*";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label23.ForeColor = System.Drawing.Color.Red;
            this.label23.Location = new System.Drawing.Point(135, 354);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 20);
            this.label23.TabIndex = 43;
            this.label23.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(410, 323);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 20);
            this.label22.TabIndex = 44;
            this.label22.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(410, 200);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 20);
            this.label17.TabIndex = 45;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(410, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 20);
            this.label16.TabIndex = 46;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(410, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 47;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(411, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "*";
            // 
            // cover
            // 
            this.cover.ForeColor = System.Drawing.Color.Black;
            this.cover.Location = new System.Drawing.Point(46, 351);
            this.cover.Name = "cover";
            this.cover.Size = new System.Drawing.Size(83, 23);
            this.cover.TabIndex = 13;
            this.cover.Text = "Browse Cover ";
            this.cover.UseVisualStyleBackColor = true;
            this.cover.Click += new System.EventHandler(this.cover_Click);
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.ForeColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(238, 398);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(128, 43);
            this.save.TabIndex = 14;
            this.save.Text = "Update";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // book_type
            // 
            this.book_type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.book_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.book_type.FormattingEnabled = true;
            this.book_type.Items.AddRange(new object[] {
            "Normal",
            "Reference"});
            this.book_type.Location = new System.Drawing.Point(149, 260);
            this.book_type.Name = "book_type";
            this.book_type.Size = new System.Drawing.Size(256, 21);
            this.book_type.TabIndex = 7;
            this.book_type.Text = "Select Book Type";
            this.book_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.department_KeyPress);
            // 
            // department
            // 
            this.department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "MATHEMATICS",
            "COMPUTER SCIENCE",
            "ECONOMICS",
            "URDU",
            "ENGLISH",
            "ADP"});
            this.department.Location = new System.Drawing.Point(149, 320);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(256, 21);
            this.department.TabIndex = 11;
            this.department.Text = "Select Department";
            this.department.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.department_KeyPress);
            // 
            // cover_box
            // 
            this.cover_box.Location = new System.Drawing.Point(157, 351);
            this.cover_box.Name = "cover_box";
            this.cover_box.Size = new System.Drawing.Size(248, 23);
            this.cover_box.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(444, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Price";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(511, 319);
            this.price.MaxLength = 5;
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 12;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.page_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(45, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Rank";
            // 
            // rank
            // 
            this.rank.Location = new System.Drawing.Point(149, 291);
            this.rank.MaxLength = 4;
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(256, 20);
            this.rank.TabIndex = 9;
            this.rank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(45, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Book Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(45, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "ISBN No.";
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(149, 226);
            this.isbn.MaxLength = 13;
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(256, 20);
            this.isbn.TabIndex = 6;
            this.isbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.page_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(444, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Edition";
            // 
            // edition
            // 
            this.edition.Location = new System.Drawing.Point(511, 291);
            this.edition.MaxLength = 2;
            this.edition.Name = "edition";
            this.edition.Size = new System.Drawing.Size(100, 20);
            this.edition.TabIndex = 10;
            this.edition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Pages";
            // 
            // page
            // 
            this.page.Location = new System.Drawing.Point(149, 196);
            this.page.MaxLength = 5;
            this.page.Name = "page";
            this.page.Size = new System.Drawing.Size(256, 20);
            this.page.TabIndex = 5;
            this.page.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.page_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(444, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Pub Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Publishers";
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(149, 168);
            this.publisher.MaxLength = 49;
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(256, 20);
            this.publisher.TabIndex = 4;
            this.publisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(45, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Author Name";
            // 
            // author_name
            // 
            this.author_name.Location = new System.Drawing.Point(151, 139);
            this.author_name.MaxLength = 49;
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(254, 20);
            this.author_name.TabIndex = 3;
            this.author_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Department";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(45, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Book Name";
            // 
            // book_name
            // 
            this.book_name.Location = new System.Drawing.Point(149, 110);
            this.book_name.MaxLength = 49;
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(256, 20);
            this.book_name.TabIndex = 2;
            this.book_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Book Update  Form";
            // 
            // book_id
            // 
            this.book_id.Location = new System.Drawing.Point(149, 80);
            this.book_id.MaxLength = 6;
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Size = new System.Drawing.Size(256, 20);
            this.book_id.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(447, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 160);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(497, 76);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "Cover Photo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // book_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(645, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pub_year);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cover);
            this.Controls.Add(this.save);
            this.Controls.Add(this.book_type);
            this.Controls.Add(this.department);
            this.Controls.Add(this.cover_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rank);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.edition);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.page);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.book_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.book_id);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "book_edit";
            this.Text = "Book Update Form";
            this.Load += new System.EventHandler(this.book_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker pub_year;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cover;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox book_type;
        private System.Windows.Forms.ComboBox department;
        private System.Windows.Forms.Label cover_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox rank;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox page;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox author_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}