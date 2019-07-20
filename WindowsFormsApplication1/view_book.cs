using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class view_book : Form
    {
        private SqlDataAdapter adapter1;
        private int account;

        public view_book(int account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void view_book_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            loadbook();

            DataGridViewButtonColumn review_button = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(review_button);
            review_button.HeaderText = "Action";
            review_button.Text = "Riview";
            review_button.Name = "review_button";
            review_button.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn edit_button = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(edit_button);
            edit_button.HeaderText = "Action";
            edit_button.Text = "Update";
            edit_button.Name = "edit_button";
            edit_button.UseColumnTextForButtonValue = true;

            if (account == 1)
            {
                DataGridViewButtonColumn delete_button = new DataGridViewButtonColumn();
                dataGridView1.Columns.Add(delete_button);
                delete_button.HeaderText = "Action";
                delete_button.Text = "Delete";
                delete_button.Name = "delete_button";
                delete_button.UseColumnTextForButtonValue = true;
            }
        }

        public void loadbook()
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT * FROM book_registration";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM book_registration";

                adapter1 = new SqlDataAdapter(query3, sqlCon);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["edit_button"].Index && (e.RowIndex >= 0))
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];

                DialogResult result = MessageBox.Show("Book Name:\t" + row.Cells[1].Value.ToString() + "\n\nDo you Want to update this book ?", "Wellcome User", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    String id = row.Cells[0].Value.ToString();
                    book_edit edit = new book_edit(id);
                    edit.Show();
                }
            }

            if (account == 1)
            {
                if (e.ColumnIndex == dataGridView1.Columns["delete_button"].Index && (e.RowIndex >= 0))
                {
                    int index = e.RowIndex;
                    DataGridViewRow row = dataGridView1.Rows[index];

                    DialogResult result = MessageBox.Show("Book Name:\t" + row.Cells[1].Value.ToString() + "\n\nDo you Want to Delete this book ?", "Wellcome User", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        String id = row.Cells[0].Value.ToString();

                        try
                        {
                            String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                            SqlConnection sqlCon = new SqlConnection(con);
                            sqlCon.Open();

                            String query = "DELETE  FROM book_registration WHERE book_id='" + id + "'";

                            SqlCommand cmd = new SqlCommand(query, sqlCon);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record has been Deleted");

                            sqlCon.Close();

                            loadbook();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns["review_button"].Index && (e.RowIndex >= 0))
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                String id = row.Cells[0].Value.ToString();

                commentReview comment = new commentReview(id);
                comment.Show();
            }

            if (e.ColumnIndex == dataGridView1.Columns[12].Index && (e.RowIndex >= 0))
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                String id = row.Cells[0].Value.ToString();

                imag_viewer view = new imag_viewer(id);
                view.Show();
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            try
            {
                reportViewer report = new reportViewer();
                librarayManagementDataSet8 ds = new librarayManagementDataSet8();
                bookReport br = new bookReport();
                adapter1.Fill(ds.book_registration);
                br.SetDataSource(ds);
                report.crystalReportViewer1.ReportSource = br;
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void member_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT * FROM book_registration WHERE book_name like'%" + book_name.Text + "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM book_registration WHERE book_name like'%" + book_name.Text + "%'";

                adapter1 = new SqlDataAdapter(query3, sqlCon);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT * FROM book_registration WHERE book_id='" + book_id.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM book_registration WHERE book_id='" + book_id.Text + "'";

                adapter1 = new SqlDataAdapter(query3, sqlCon);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void author_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT * FROM book_registration WHERE author_name like'%" + author_name.Text + "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM book_registration WHERE author_name like'%" + book_name.Text + "%'";

                adapter1 = new SqlDataAdapter(query3, sqlCon);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void book_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT * FROM book_registration WHERE book_type='" + book_type.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM book_registration WHERE book_type='" + book_type.Text + "'";

                adapter1 = new SqlDataAdapter(query3, sqlCon);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void book_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void book_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void book_name_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }
    }
}