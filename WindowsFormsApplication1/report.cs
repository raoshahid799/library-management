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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT  member_registration.first_name AS [First Name],member_registration.last_name AS [Last Name],member_registration.member_id AS [Member ID],member_registration.member_type AS [Member Type],member_registration.reg_no AS [Registration No.],member_registration.department AS[Department],member_registration.course_name AS [Course Name],member_registration.session AS [Session],member_registration.date AS [Member Reg. Date],member_registration.sex AS [Gender],member_registration.address AS [Address],book_registration.book_name AS [Book Name],book_registration.cover_image AS [Cover],book_issue.book_id AS [Book ID],book_issue.issue_date AS [Issue Date],book_issue.due_date AS [Due Date],book_issue.status AS [Status],book_issue.detail AS [Book Issue Detail],book_return.return_date AS [Return Date],book_return.detail AS [Return Detail],book_return.fine AS [Fine]  FROM  member_registration INNER JOIN book_issue ON member_registration.member_id=book_issue.member_id   LEFT OUTER JOIN book_return ON book_issue.issue_id =book_return.issue_id  INNER JOIN book_registration ON book_issue.book_id=book_registration.book_id";
                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                dataGridView1.DataSource = table;
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

                String query2 = "SELECT  member_registration.first_name AS [First Name],member_registration.last_name AS [Last Name],member_registration.member_id AS [Member ID],member_registration.member_type AS [Member Type],member_registration.reg_no AS [Registration No.],member_registration.department AS[Department],member_registration.course_name AS [Course Name],member_registration.session AS [Session],member_registration.date AS [Member Reg. Date],member_registration.sex AS [Gender],member_registration.address AS [Address],book_registration.book_name AS [Book Name],book_registration.cover_image AS [Cover],book_issue.book_id AS [Book ID],book_issue.issue_date AS [Issue Date],book_issue.due_date AS [Due Date],book_issue.status AS [Status],book_issue.detail AS [Book Issue Detail],book_return.return_date AS [Return Date],book_return.detail AS [Return Detail],book_return.fine AS [Fine]  FROM  member_registration INNER JOIN book_issue ON member_registration.member_id=book_issue.member_id   LEFT OUTER JOIN book_return ON book_issue.issue_id =book_return.issue_id  INNER JOIN book_registration ON book_issue.book_id=book_registration.book_id WHERE member_registration.member_type='" + member_type.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);

                DataRow row = table.NewRow();
                table.Rows.Add(row);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT  member_registration.first_name AS [First Name],member_registration.last_name AS [Last Name],member_registration.member_id AS [Member ID],member_registration.member_type AS [Member Type],member_registration.reg_no AS [Registration No.],member_registration.department AS[Department],member_registration.course_name AS [Course Name],member_registration.session AS [Session],member_registration.date AS [Member Reg. Date],member_registration.sex AS [Gender],member_registration.address AS [Address],book_registration.book_name AS [Book Name],book_registration.cover_image AS [Cover],book_issue.book_id AS [Book ID],book_issue.issue_date AS [Issue Date],book_issue.due_date AS [Due Date],book_issue.status AS [Status],book_issue.detail AS [Book Issue Detail],book_return.return_date AS [Return Date],book_return.detail AS [Return Detail],book_return.fine AS [Fine]  FROM  member_registration INNER JOIN book_issue ON member_registration.member_id=book_issue.member_id   LEFT OUTER JOIN book_return ON book_issue.issue_id =book_return.issue_id  INNER JOIN book_registration ON book_issue.book_id=book_registration.book_id WHERE member_registration.first_name like '%" + name.Text + "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                dataGridView1.DataSource = table;
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

                    String query2 = "SELECT  member_registration.first_name AS [First Name],member_registration.last_name AS [Last Name],member_registration.member_id AS [Member ID],member_registration.member_type AS [Member Type],member_registration.reg_no AS [Registration No.],member_registration.department AS[Department],member_registration.course_name AS [Course Name],member_registration.session AS [Session],member_registration.date AS [Member Reg. Date],member_registration.sex AS [Gender],member_registration.address AS [Address],book_registration.book_name AS [Book Name],book_registration.cover_image AS [Cover],book_issue.book_id AS [Book ID],book_issue.issue_date AS [Issue Date],book_issue.due_date AS [Due Date],book_issue.status AS [Status],book_issue.detail AS [Book Issue Detail],book_return.return_date AS [Return Date],book_return.detail AS [Return Detail],book_return.fine AS [Fine]  FROM  member_registration INNER JOIN book_issue ON member_registration.member_id=book_issue.member_id   LEFT OUTER JOIN book_return ON book_issue.issue_id =book_return.issue_id  INNER JOIN book_registration ON book_issue.book_id=book_registration.book_id WHERE member_registration.member_id='" + member_id.Text + "'";

                    SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    DataRow row = table.NewRow();
                    table.Rows.Add(row);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridView1[19, dataGridView1.Rows.Count - 1].Value = "Total Fine";
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[19].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            int fine = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1[20, i].Value != DBNull.Value)
                {
                    fine += int.Parse(dataGridView1[20, i].Value.ToString());
                }
            }

            dataGridView1[20, dataGridView1.Rows.Count - 1].Value = fine;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[12].Index && (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1))
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                String id = row.Cells[13].Value.ToString();

                imag_viewer view = new imag_viewer(id);
                view.Show();
            }
        }

        private void status_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT  member_registration.first_name AS [First Name],member_registration.last_name AS [Last Name],member_registration.member_id AS [Member ID],member_registration.member_type AS [Member Type],member_registration.reg_no AS [Registration No.],member_registration.department AS[Department],member_registration.course_name AS [Course Name],member_registration.session AS [Session],member_registration.date AS [Member Reg. Date],member_registration.sex AS [Gender],member_registration.address AS [Address],book_registration.book_name AS [Book Name],book_registration.cover_image AS [Cover],book_issue.book_id AS [Book ID],book_issue.issue_date AS [Issue Date],book_issue.due_date AS [Due Date],book_issue.status AS [Status],book_issue.detail AS [Book Issue Detail],book_return.return_date AS [Return Date],book_return.detail AS [Return Detail],book_return.fine AS [Fine]  FROM  member_registration INNER JOIN book_issue ON member_registration.member_id=book_issue.member_id   LEFT OUTER JOIN book_return ON book_issue.issue_id =book_return.issue_id  INNER JOIN book_registration ON book_issue.book_id=book_registration.book_id WHERE book_issue.status='" + status.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow row = table.NewRow();
                table.Rows.Add(row);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT  member_registration.first_name AS [First Name],member_registration.last_name AS [Last Name],member_registration.member_id AS [Member ID],member_registration.member_type AS [Member Type],member_registration.reg_no AS [Registration No.],member_registration.department AS[Department],member_registration.course_name AS [Course Name],member_registration.session AS [Session],member_registration.date AS [Member Reg. Date],member_registration.sex AS [Gender],member_registration.address AS [Address],book_registration.book_name AS [Book Name],book_registration.cover_image AS [Cover],book_issue.book_id AS [Book ID],book_issue.issue_date AS [Issue Date],book_issue.due_date AS [Due Date],book_issue.status AS [Status],book_issue.detail AS [Book Issue Detail],book_return.return_date AS [Return Date],book_return.detail AS [Return Detail],book_return.fine AS [Fine]  FROM  member_registration INNER JOIN book_issue ON member_registration.member_id=book_issue.member_id   LEFT OUTER JOIN book_return ON book_issue.issue_id =book_return.issue_id  INNER JOIN book_registration ON book_issue.book_id=book_registration.book_id WHERE book_return.return_date BETWEEN '" + from.Text + "' AND '" + to.Text + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rp_Click(object sender, EventArgs e)
        {
            reportViewer report = new reportViewer();
            memberReportDataSet ds = new memberReportDataSet();
            memberDetailReport br = new memberDetailReport();
            DataTable dt = new DataTable();

            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {
                DataRow dr = dt.NewRow();

                if (item.DataBoundItem != null)
                {
                    dr = (DataRow)((DataRowView)item.DataBoundItem).Row;
                    ds.DataTable1.ImportRow(dr);
                }
            }

            ds.DataTable1.Rows.RemoveAt(dataGridView1.Rows.Count - 1); //removing the last row because it contain total fine which is causing problem
            br.SetDataSource(ds);
            report.crystalReportViewer1.ReportSource = br;
            report.Show();
        }

        private void member_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }

        private void member_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}