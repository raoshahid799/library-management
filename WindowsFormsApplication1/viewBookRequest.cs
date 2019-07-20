using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class viewBookRequest : Form
    {
        private int account;
        private SqlDataAdapter adapter1, adapter2;

        public viewBookRequest(int account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void viewBookRequest_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            loaddata();

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

        private void loaddata()
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "Select member_registration.member_id as [Member ID],member_registration.first_name as [First Name],member_registration.last_name as[Last Name],member_registration.member_type [Member Type],member_registration.department as[Departmetn],book_request.id as [ID],book_request.book_name as [Book Name],book_request.author_name as [Author Name],book_request.isbn_no as [ISBN No],book_request.edition as [Edition],book_request.publisher as[Publisher],book_request.pub_year as [Pub. Year],book_request.date as [Request Date],status as [Status] from member_registration inner join book_request on member_registration.member_id=book_request.member_id";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM member_registration";
                adapter1 = new SqlDataAdapter(query3, sqlCon);

                String query5 = "SELECT * FROM book_request";

                adapter2 = new SqlDataAdapter(query5, sqlCon);

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
                if (member_id.Text == "")
                {
                    MessageBox.Show("Please Enter Query First");
                }
                else
                {
                    String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();

                    String query = "Select member_registration.member_id as [Member ID],member_registration.first_name as [First Name],member_registration.last_name as[Last Name],member_registration.member_type [Member Type],member_registration.department as[Departmetn],book_request.id as [ID],book_request.book_name as [Book Name],book_request.author_name as [Author Name],book_request.isbn_no as [ISBN No],book_request.edition as [Edition],book_request.publisher as[Publisher],book_request.pub_year as [Pub. Year],book_request.date as [Request Date],status as [Status] from member_registration inner join book_request on member_registration.member_id=book_request.member_id WHERE member_registration.member_id='" + member_id.Text + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;

                    String query3 = "SELECT * FROM member_registration WHERE member_id='" + member_id.Text + "'";
                    adapter1 = new SqlDataAdapter(query3, sqlCon);

                    String query5 = "SELECT * FROM book_request";

                    adapter2 = new SqlDataAdapter(query5, sqlCon);

                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query = "Select member_registration.member_id as [Member ID],member_registration.first_name as [First Name],member_registration.last_name as[Last Name],member_registration.member_type [Member Type],member_registration.department as[Departmetn],book_request.id as [ID],book_request.book_name as [Book Name],book_request.author_name as [Author Name],book_request.isbn_no as [ISBN No],book_request.edition as [Edition],book_request.publisher as[Publisher],book_request.pub_year as [Pub. Year],book_request.date as [Request Date],status as [Status] from member_registration inner join book_request on member_registration.member_id=book_request.member_id WHERE book_request.status='" + status.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM member_registration";
                adapter1 = new SqlDataAdapter(query3, sqlCon);

                String query5 = "SELECT * FROM book_request WHERE book_request.status='" + status.Text + "'";

                adapter2 = new SqlDataAdapter(query5, sqlCon);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void member_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query = "Select member_registration.member_id as [Member ID],member_registration.first_name as [First Name],member_registration.last_name as[Last Name],member_registration.member_type [Member Type],member_registration.department as[Departmetn],book_request.id as [ID],book_request.book_name as [Book Name],book_request.author_name as [Author Name],book_request.isbn_no as [ISBN No],book_request.edition as [Edition],book_request.publisher as[Publisher],book_request.pub_year as [Pub. Year],book_request.date as [Request Date],status as [Status] from member_registration inner join book_request on member_registration.member_id=book_request.member_id WHERE member_registration.member_type='" + member_type.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM member_registration WHERE member_type='" + member_type.Text + "'";
                adapter1 = new SqlDataAdapter(query3, sqlCon);

                String query5 = "SELECT * FROM book_request";

                adapter2 = new SqlDataAdapter(query5, sqlCon);

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
                int i = e.RowIndex;

                if (i >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];

                    DialogResult result = MessageBox.Show("book Name\t" + row.Cells[6].Value.ToString() + "\nDo you want to Update this book ?", "Welcome", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        mem_id.Text = row.Cells[5].Value.ToString();
                        book_name.Text = row.Cells[6].Value.ToString();
                    }
                }
            }

            if (account == 1)
            {
                if (e.ColumnIndex == dataGridView1.Columns["delete_button"].Index && (e.RowIndex >= 0))
                {
                    int index = e.RowIndex;
                    DataGridViewRow row = dataGridView1.Rows[index];

                    DialogResult result = MessageBox.Show("Book Name:\t" + row.Cells[6].Value.ToString() + "\n\nDo you Want to Delete this book Request ?", "Wellcome User", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        String id = row.Cells[5].Value.ToString();

                        try
                        {
                            String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                            SqlConnection sqlCon = new SqlConnection(con);
                            sqlCon.Open();

                            String query = "DELETE  FROM book_request WHERE id='" + id + "'";

                            SqlCommand cmd = new SqlCommand(query, sqlCon);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record has been Deleted");

                            sqlCon.Close();
                            loaddata();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (mem_id.Text == "" || book_name.Text == "" || set_status.Text == "Select Status")
                {
                    MessageBox.Show("Member ID,Book ID and Status is Missing");
                }
                else
                {
                    String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();

                    String query = "UPDATE book_request SET status='Approved' WHERE id='" + mem_id.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data has updated");
                    set_status.Text = "Select Status";
                    sqlCon.Close();

                    loaddata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            try
            {
                reportViewer report = new reportViewer();
                librarayManagementDataSet10 ds = new librarayManagementDataSet10();
                bookRequestReport br = new bookRequestReport();
                adapter1.Fill(ds.member_registration);
                adapter2.Fill(ds.book_request);
                br.SetDataSource(ds);
                report.crystalReportViewer1.ReportSource = br;
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void status_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void member_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}