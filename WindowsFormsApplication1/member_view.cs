using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class member_view : Form
    {
        private int account;
        private SqlDataAdapter adapter1;

        public member_view(int account)
        {
            this.account = account;
            InitializeComponent();
        }

        private void member_view_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            // TODO: This line of code loads data into the 'librarayManagementDataSet7.member_registration' table. You can move, or remove it, as needed.
            // this.member_registrationTableAdapter.Fill(this.librarayManagementDataSet7.member_registration);

            loadData();

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

        public void loadData()
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT * FROM member_registration";
                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow row = table.NewRow();
                table.Rows.Add(row);

                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM member_registration";

                adapter1 = new SqlDataAdapter(query3, sqlCon);

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

        private void member_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT  * FROM  member_registration WHERE member_type='" + member_type.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow row = table.NewRow();
                table.Rows.Add(row);

                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM member_registration  WHERE member_type='" + member_type.Text + "'";

                adapter1 = new SqlDataAdapter(query3, sqlCon);

                sqlCon.Close();
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

                String query2 = "SELECT * FROM member_registration WHERE first_name like '%" + name.Text + "%'";
                SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataRow row = table.NewRow();
                table.Rows.Add(row);

                dataGridView1.DataSource = table;

                String query3 = "SELECT * FROM member_registration WHERE first_name like '%" + name.Text + "%'";

                adapter1 = new SqlDataAdapter(query3, sqlCon);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridView1[11, dataGridView1.Rows.Count - 1].Value = "Total Fine";
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[11].Style.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            int fine = 0;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1[12, i].Value != DBNull.Value)
                {
                    fine += int.Parse(dataGridView1[12, i].Value.ToString());
                }
            }

            dataGridView1[12, dataGridView1.Rows.Count - 1].Value = fine;
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

                    String query2 = "SELECT * FROM member_registration WHERE member_id='" + member_id.Text + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(query2, sqlCon);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    DataRow row = table.NewRow();
                    table.Rows.Add(row);

                    dataGridView1.DataSource = table;

                    String query3 = "SELECT * FROM member_registration WHERE member_id='" + member_id.Text + "'";

                    adapter1 = new SqlDataAdapter(query3, sqlCon);

                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["edit_button"].Index && (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1))
            {
                int index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];

                DialogResult result = MessageBox.Show("Book Name:\t" + row.Cells[1].Value.ToString() + "\n\nDo you Want to update this Member ?", "Wellcome User", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    String id = row.Cells[0].Value.ToString();
                    member_edit edit = new member_edit(id, account);
                    edit.Show();
                }
            }

            if (account == 1)
            {
                if (e.ColumnIndex == dataGridView1.Columns["delete_button"].Index && (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1))
                {
                    int index = e.RowIndex;
                    DataGridViewRow row = dataGridView1.Rows[index];

                    DialogResult result = MessageBox.Show("Book Name:\t" + row.Cells[1].Value.ToString() + "\n\nDo you Want to Delete this Member ?", "Wellcome User", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        String id = row.Cells[0].Value.ToString();

                        try
                        {
                            String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                            SqlConnection sqlCon = new SqlConnection(con);
                            sqlCon.Open();

                            String query = "DELETE  FROM member_registration WHERE member_id='" + id + "'";

                            SqlCommand cmd = new SqlCommand(query, sqlCon);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record has been Deleted");

                            sqlCon.Close();

                            loadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            try
            {
                reportViewer report = new reportViewer();
                librarayManagementDataSet7 ds = new librarayManagementDataSet7();
                viewMemberReport br = new viewMemberReport();
                adapter1.Fill(ds.member_registration);

                br.SetDataSource(ds);
                report.crystalReportViewer1.ReportSource = br;
                report.Show();
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

        private void member_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }
    }
}