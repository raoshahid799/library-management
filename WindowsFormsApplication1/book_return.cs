using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class book_return : Form
    {
        private SqlDataAdapter adapter1, adapter3;

        public book_return()
        {
            InitializeComponent();
        }

        private int fine_rate = 5;

        private void book_return_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            bookload();
        }

        private void bookload()
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT member_registration.member_id AS [Member ID],member_registration.first_name AS [First Name],member_registration.last_name AS[Last Name] ,member_registration.member_type AS [Member Type],member_registration.department AS [Department],book_registration.book_name AS [Book Name],book_registration.book_id AS [Book ID],book_issue.issue_date AS [Issue Date],book_issue.due_date AS[Due Date],book_issue.issue_id AS [Issue ID],book_issue.detail AS [Issue Detail],book_issue.status As[Status] FROM member_registration INNER JOIN book_issue ON member_registration.member_id=book_issue.member_id INNER JOIN  book_registration ON book_issue.book_id=book_registration.book_id AND book_issue.status='issue'";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);

                DataTable table = new DataTable();

                adapter.Fill(table);
                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM member_registration";
                adapter1 = new SqlDataAdapter(query3, sqlCon);

                String query5 = "SELECT * FROM book_issue WHERE status='issue'";

                adapter3 = new SqlDataAdapter(query5, sqlCon);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                DialogResult result = MessageBox.Show("Member Name\t" + row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString() + "\nDo you want to Return this book ?", "Welcome", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    mem_id.Text = row.Cells[0].Value.ToString();
                    mem_name.Text = row.Cells[1].Value.ToString();
                    mem_name.Text = mem_name.Text + " " + row.Cells[2].Value.ToString();
                    b_name.Text = row.Cells[5].Value.ToString();

                    b_id.Text = row.Cells[6].Value.ToString();
                    issue_date.Text = row.Cells[7].Value.ToString();
                    issue_id.Text = row.Cells[9].Value.ToString();
                }
            }
        }

        private void book_name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                //     String query2 = "SELECT * FROM book_issue WHERE book_name like '%"+book_name.Text+"%' AND status='issue'";
                String query2 = "SELECT member_registration.member_id AS [Member ID],member_registration.first_name AS [First Name],member_registration.last_name AS[Last Name] ,member_registration.member_type AS [Member Type],member_registration.department AS [Department],book_registration.book_name AS [Book Name],book_registration.book_id AS [Book ID],book_issue.issue_date AS [Issue Date],book_issue.issue_id AS [Issue ID],book_issue.due_date AS[Due Date],book_issue.detail AS [Issue Detail],book_issue.status As[Status] FROM member_registration INNER JOIN book_issue ON member_registration.member_id=book_issue.member_id INNER JOIN  book_registration ON book_issue.book_id=book_registration.book_id AND book_issue.status='issue' AND book_registration.book_name like '%" + book_name.Text + "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);

                DataTable table = new DataTable();

                adapter.Fill(table);
                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM member_registration WHERE book_name like '%" + book_name.Text + "%'";
                adapter1 = new SqlDataAdapter(query3, sqlCon);

                String query5 = "SELECT * FROM book_issue WHERE status='issue'";

                adapter3 = new SqlDataAdapter(query5, sqlCon);

                sqlCon.Close();
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

                String query2 = "SELECT member_registration.member_id AS [Member ID],member_registration.first_name AS [First Name],member_registration.last_name AS[Last Name] ,member_registration.member_type AS [Member Type],member_registration.department AS [Department],book_registration.book_name AS [Book Name],book_registration.book_id AS [Book ID],book_issue.issue_date AS [Issue Date],book_issue.due_date AS[Due Date],book_issue.issue_id AS [Issue ID],book_issue.detail AS [Issue Detail],book_issue.status As[Status] FROM member_registration INNER JOIN book_issue ON member_registration.member_id=book_issue.member_id INNER JOIN  book_registration ON book_issue.book_id=book_registration.book_id AND book_issue.status='issue' AND member_registration.first_name like '%" + member_name.Text + "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);

                DataTable table = new DataTable();

                adapter.Fill(table);
                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM member_registration WHERE first_name like '%" + member_name.Text + "%'";
                adapter1 = new SqlDataAdapter(query3, sqlCon);

                String query5 = "SELECT * FROM book_issue WHERE status='issue'";

                adapter3 = new SqlDataAdapter(query5, sqlCon);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void member_id_TextChanged(object sender, EventArgs e)
        {
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (issue_id.Text == "" || b_id.Text == "")
                {
                    MessageBox.Show("Issue ID OR book ID is Empty ");
                }
                else
                {
                    TimeSpan ts = return_date.Value - issue_date.Value;
                    int fine = 0;
                    int total_day = (int)ts.TotalDays;
                    total_day = total_day - 15;
                    if (total_day > 0)
                    {
                        fine = total_day * fine_rate;
                    }
                    String link = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(link);
                    sqlCon.Open();
                    String query2 = "INSERT INTO book_return (issue_id,member_id ,book_id,return_date,detail,fine) VALUES ('" + issue_id.Text + "','" + mem_id.Text + "','" + b_id.Text + "','" + return_date.Text + "','" + detail.Text + "','" + fine + "')";
                    SqlCommand cmd = new SqlCommand(query2, sqlCon);
                    cmd.ExecuteNonQuery();
                    String query3 = "UPDATE book_issue SET status='return' WHERE book_id='" + b_id.Text + "'";
                    SqlCommand cmd3 = new SqlCommand(query3, sqlCon);
                    cmd3.ExecuteNonQuery();
                    String query4 = "UPDATE book_registration SET status='Available' WHERE book_id='" + b_id.Text + "'";
                    SqlCommand cmd4 = new SqlCommand(query4, sqlCon);
                    cmd4.ExecuteNonQuery();
                    String query5 = "SELECT fine FROM member_registration WHERE member_id='" + mem_id.Text + "'";
                    SqlCommand cmd5 = new SqlCommand(query5, sqlCon);
                    SqlDataReader reader = cmd5.ExecuteReader();
                    reader.Read();
                    int db_fine = 0;
                    db_fine = reader.GetInt32(0);
                    int total_fine;
                    total_fine = db_fine + fine;
                    reader.Close();
                    String query6 = "UPDATE member_registration SET fine=" + total_fine + " WHERE member_id='" + mem_id.Text + "'";
                    SqlCommand cmd6 = new SqlCommand(query6, sqlCon);
                    cmd6.ExecuteNonQuery();
                    sqlCon.Close();

                    MessageBox.Show("Data has saved");
                    bookload();
                    issue_id.Text = "";
                    b_id.Text = "";
                }
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
                    MessageBox.Show("Please Enter Query");
                }
                else
                {
                    String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();

                    String query2 = "SELECT member_registration.member_id AS [Member ID],member_registration.first_name AS [First Name],member_registration.last_name AS[Last Name] ,member_registration.member_type AS [Member Type],member_registration.department AS [Department],book_registration.book_name AS [Book Name],book_registration.book_id AS [Book ID],book_issue.issue_date AS [Issue Date],book_issue.issue_id AS [Issue ID],book_issue.due_date AS[Due Date],book_issue.detail AS [Issue Detail],book_issue.status As[Status] FROM member_registration INNER JOIN book_issue ON member_registration.member_id=book_issue.member_id INNER JOIN  book_registration ON book_issue.book_id=book_registration.book_id AND book_issue.status='issue' AND member_registration.member_id='" + member_id.Text + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);

                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    String query3 = "SELECT * FROM member_registration WHERE member_id='" + member_id.Text + "'";
                    adapter1 = new SqlDataAdapter(query3, sqlCon);

                    String query5 = "SELECT * FROM book_issue WHERE status='issue'";

                    adapter3 = new SqlDataAdapter(query5, sqlCon);

                    sqlCon.Close();
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
                librarayManagementDataSet9 ds = new librarayManagementDataSet9();
                bookReturnReport br = new bookReturnReport();
                adapter1.Fill(ds.member_registration);

                adapter3.Fill(ds.book_issue);
                br.SetDataSource(ds);
                report.crystalReportViewer1.ReportSource = br;
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void search2_Click(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT member_registration.member_id AS [Member ID],member_registration.first_name AS [First Name],member_registration.last_name AS[Last Name] ,member_registration.member_type AS [Member Type],member_registration.department AS [Department],book_registration.book_name AS [Book Name],book_registration.book_id AS [Book ID],book_issue.issue_date AS [Issue Date],book_issue.due_date AS[Due Date],book_issue.issue_id AS [Issue ID],book_issue.detail AS [Issue Detail],book_issue.status As[Status] FROM member_registration INNER JOIN book_issue ON member_registration.member_id=book_issue.member_id INNER JOIN  book_registration ON book_issue.book_id=book_registration.book_id AND book_issue.status='issue' AND book_registration.book_id='" + book_id.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);

                DataTable table = new DataTable();

                adapter.Fill(table);
                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM member_registration WHERE book_id='" + book_id.Text + "'";
                adapter1 = new SqlDataAdapter(query3, sqlCon);

                String query5 = "SELECT * FROM book_issue WHERE status='issue'";

                adapter3 = new SqlDataAdapter(query5, sqlCon);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void member_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void book_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }
    }
}