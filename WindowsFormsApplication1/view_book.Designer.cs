namespace WindowsFormsApplication1
{
    partial class view_book
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
            this.book_type = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coverimageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookregistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.librarayManagementDataSet2 = new WindowsFormsApplication1.librarayManagementDataSet2();
            this.book_id = new System.Windows.Forms.TextBox();
            this.book_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.author_name = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.book_registrationTableAdapter = new WindowsFormsApplication1.librarayManagementDataSet2TableAdapters.book_registrationTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookregistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarayManagementDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.book_type);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.report);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.book_id);
            this.groupBox2.Controls.Add(this.book_name);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.author_name);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(24, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 489);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Information";
            // 
            // book_type
            // 
            this.book_type.FormattingEnabled = true;
            this.book_type.Items.AddRange(new object[] {
            "Normal",
            "Reference"});
            this.book_type.Location = new System.Drawing.Point(557, 22);
            this.book_type.Name = "book_type";
            this.book_type.Size = new System.Drawing.Size(112, 21);
            this.book_type.TabIndex = 6;
            this.book_type.Text = "Book Type";
            this.book_type.SelectedIndexChanged += new System.EventHandler(this.book_type_SelectedIndexChanged);
            this.book_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_type_KeyPress);
            // 
            // search
            // 
            this.search.ForeColor = System.Drawing.Color.Black;
            this.search.Location = new System.Drawing.Point(159, 21);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(65, 23);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // report
            // 
            this.report.ForeColor = System.Drawing.Color.Black;
            this.report.Location = new System.Drawing.Point(687, 21);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(75, 23);
            this.report.TabIndex = 5;
            this.report.Text = "Report";
            this.report.UseVisualStyleBackColor = true;
            this.report.Click += new System.EventHandler(this.report_Click);
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
            this.bookidDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.authornameDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.publishyearDataGridViewTextBoxColumn,
            this.isbnnoDataGridViewTextBoxColumn,
            this.pagesDataGridViewTextBoxColumn,
            this.editionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.booktypeDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.coverimageDataGridViewImageColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookregistrationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(805, 420);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "book_id";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "Book ID";
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            this.bookidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "book_name";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "Book Name";
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            this.booknameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authornameDataGridViewTextBoxColumn
            // 
            this.authornameDataGridViewTextBoxColumn.DataPropertyName = "author_name";
            this.authornameDataGridViewTextBoxColumn.HeaderText = "Author Name";
            this.authornameDataGridViewTextBoxColumn.Name = "authornameDataGridViewTextBoxColumn";
            this.authornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publishyearDataGridViewTextBoxColumn
            // 
            this.publishyearDataGridViewTextBoxColumn.DataPropertyName = "publish_year";
            this.publishyearDataGridViewTextBoxColumn.HeaderText = "Publish Year";
            this.publishyearDataGridViewTextBoxColumn.Name = "publishyearDataGridViewTextBoxColumn";
            this.publishyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isbnnoDataGridViewTextBoxColumn
            // 
            this.isbnnoDataGridViewTextBoxColumn.DataPropertyName = "isbn_no";
            this.isbnnoDataGridViewTextBoxColumn.HeaderText = "ISBN No.";
            this.isbnnoDataGridViewTextBoxColumn.Name = "isbnnoDataGridViewTextBoxColumn";
            this.isbnnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagesDataGridViewTextBoxColumn
            // 
            this.pagesDataGridViewTextBoxColumn.DataPropertyName = "pages";
            this.pagesDataGridViewTextBoxColumn.HeaderText = "Pages";
            this.pagesDataGridViewTextBoxColumn.Name = "pagesDataGridViewTextBoxColumn";
            this.pagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editionDataGridViewTextBoxColumn
            // 
            this.editionDataGridViewTextBoxColumn.DataPropertyName = "edition";
            this.editionDataGridViewTextBoxColumn.HeaderText = "Edition";
            this.editionDataGridViewTextBoxColumn.Name = "editionDataGridViewTextBoxColumn";
            this.editionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // booktypeDataGridViewTextBoxColumn
            // 
            this.booktypeDataGridViewTextBoxColumn.DataPropertyName = "book_type";
            this.booktypeDataGridViewTextBoxColumn.HeaderText = "Book Type";
            this.booktypeDataGridViewTextBoxColumn.Name = "booktypeDataGridViewTextBoxColumn";
            this.booktypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coverimageDataGridViewImageColumn
            // 
            this.coverimageDataGridViewImageColumn.DataPropertyName = "cover_image";
            this.coverimageDataGridViewImageColumn.HeaderText = "Cover";
            this.coverimageDataGridViewImageColumn.Name = "coverimageDataGridViewImageColumn";
            this.coverimageDataGridViewImageColumn.ReadOnly = true;
            this.coverimageDataGridViewImageColumn.Width = 41;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookregistrationBindingSource
            // 
            this.bookregistrationBindingSource.DataMember = "book_registration";
            this.bookregistrationBindingSource.DataSource = this.librarayManagementDataSet2;
            // 
            // librarayManagementDataSet2
            // 
            this.librarayManagementDataSet2.DataSetName = "librarayManagementDataSet2";
            this.librarayManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_id
            // 
            this.book_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_id.Location = new System.Drawing.Point(68, 23);
            this.book_id.MaxLength = 8;
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(86, 20);
            this.book_id.TabIndex = 3;
            this.book_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_id_KeyPress);
            // 
            // book_name
            // 
            this.book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_name.Location = new System.Drawing.Point(301, 24);
            this.book_name.MaxLength = 20;
            this.book_name.Name = "book_name";
            this.book_name.Size = new System.Drawing.Size(83, 20);
            this.book_name.TabIndex = 1;
            this.book_name.TextChanged += new System.EventHandler(this.member_name_TextChanged);
            this.book_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book ID";
            // 
            // author_name
            // 
            this.author_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author_name.Location = new System.Drawing.Point(453, 23);
            this.author_name.MaxLength = 20;
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(84, 20);
            this.author_name.TabIndex = 4;
            this.author_name.TextChanged += new System.EventHandler(this.author_name_TextChanged);
            this.author_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_name_KeyPress_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(385, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Author Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(233, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Book Name";
            // 
            // book_registrationTableAdapter
            // 
            this.book_registrationTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(300, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Book Records Form";
            // 
            // view_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(888, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "view_book";
            this.Text = "Book Records";
            this.Load += new System.EventHandler(this.view_book_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookregistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librarayManagementDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox book_id;
        private System.Windows.Forms.TextBox book_name;
        private System.Windows.Forms.TextBox author_name;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private librarayManagementDataSet2 librarayManagementDataSet2;
        private System.Windows.Forms.BindingSource bookregistrationBindingSource;
        private librarayManagementDataSet2TableAdapters.book_registrationTableAdapter book_registrationTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booktypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn coverimageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button report;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ComboBox book_type;
    }
}