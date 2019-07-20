namespace WindowsFormsApplication1
{
    partial class book_request
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
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.edition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.author_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.book_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Search = new System.Windows.Forms.Button();
            this.last_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.first_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.member_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pub_year
            // 
            this.pub_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pub_year.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pub_year.Location = new System.Drawing.Point(194, 312);
            this.pub_year.Name = "pub_year";
            this.pub_year.Size = new System.Drawing.Size(256, 22);
            this.pub_year.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(455, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 18);
            this.label16.TabIndex = 26;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(455, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 18);
            this.label15.TabIndex = 25;
            this.label15.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(90, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "ISBN No.";
            // 
            // isbn
            // 
            this.isbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn.Location = new System.Drawing.Point(194, 281);
            this.isbn.MaxLength = 13;
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(256, 22);
            this.isbn.TabIndex = 6;
            this.isbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.member_id_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(90, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Edition";
            // 
            // edition
            // 
            this.edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edition.Location = new System.Drawing.Point(194, 343);
            this.edition.MaxLength = 2;
            this.edition.Name = "edition";
            this.edition.Size = new System.Drawing.Size(256, 22);
            this.edition.TabIndex = 8;
            this.edition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(90, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Pub Years";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Publishers";
            // 
            // publisher
            // 
            this.publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisher.Location = new System.Drawing.Point(194, 248);
            this.publisher.MaxLength = 49;
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(256, 22);
            this.publisher.TabIndex = 5;
            this.publisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(90, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Author Name";
            // 
            // author_name
            // 
            this.author_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_name.Location = new System.Drawing.Point(194, 219);
            this.author_name.MaxLength = 49;
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(256, 22);
            this.author_name.TabIndex = 4;
            this.author_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Book Name";
            // 
            // book_name
            // 
            this.book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_name.Location = new System.Drawing.Point(194, 190);
            this.book_name.MaxLength = 49;
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(256, 22);
            this.book_name.TabIndex = 3;
            this.book_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Book Request Form";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(236, 420);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(120, 41);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 374);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(460, 100);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // last_name
            // 
            this.last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_name.Location = new System.Drawing.Point(194, 158);
            this.last_name.MaxLength = 49;
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Size = new System.Drawing.Size(256, 22);
            this.last_name.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(90, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Last Name";
            // 
            // first_name
            // 
            this.first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_name.Location = new System.Drawing.Point(194, 130);
            this.first_name.MaxLength = 49;
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Size = new System.Drawing.Size(256, 22);
            this.first_name.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(90, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "First Name";
            // 
            // member_id
            // 
            this.member_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_id.Location = new System.Drawing.Point(194, 100);
            this.member_id.MaxLength = 49;
            this.member_id.Name = "member_id";
            this.member_id.Size = new System.Drawing.Size(256, 22);
            this.member_id.TabIndex = 1;
            this.member_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.member_id_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(90, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Member ID";
            // 
            // book_request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(583, 523);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pub_year);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.edition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.member_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.book_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "book_request";
            this.Text = "Book Request";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker pub_year;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox author_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox member_id;
        private System.Windows.Forms.Label label11;
    }
}