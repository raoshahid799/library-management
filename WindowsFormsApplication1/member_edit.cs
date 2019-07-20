using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class member_edit : Form
    {
        private String id;
        private int account;

        public member_edit(String id, int account)
        {
            this.id = id;
            this.account = account;
            InitializeComponent();
        }

        private void member_edit_Load(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query = "SELECT member_id ,first_name ,last_name ,reg_no ,roll_no ,session,course_name,member_type,department ,date ,sex ,address ,fine FROM dbo.member_registration WHERE member_id='" + id + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader sql_data = cmd.ExecuteReader();

                sql_data.Read();

                member_id.Text = "" + sql_data.GetValue(0);
                first_name.Text = sql_data.GetString(1);
                last_name.Text = sql_data.GetString(2);

                member_type.Text = sql_data.GetString(7); //id is in int
                if (member_type.Text == "Student")
                { //ager student ho ga tu read kry otherwise nhi kry q k in empty data of teacher ka jo exception send kry ga
                    reg_no.Text = sql_data.GetString(3); //id is in int
                    roll_no.Text = "" + sql_data.GetValue(4);
                    session.Text = sql_data.GetString(5);
                }
                else
                {
                    reg_no.Enabled = false;
                    session.Enabled = false;
                    roll_no.Enabled = false;

                    session.Text = "";
                }

                course_name.Text = "" + sql_data.GetValue(6);

                department.Text = "" + sql_data.GetValue(8);
                date.Text = "" + sql_data.GetValue(9);
                sex.Text = sql_data.GetString(10);

                address.Text = sql_data.GetString(11);
                fine.Text = "" + sql_data.GetValue(12);

                if (account == 2)
                {
                    fine.Enabled = false;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query = "UPDATE member_registration SET first_name ='" + first_name.Text + "',last_name ='" + last_name.Text + "' ,reg_no ='" + reg_no.Text + "',roll_no='" + roll_no.Text + "',session ='" + session.Text + "',course_name='" + course_name.Text + "',member_type='" + member_type.Text + "',department='" + department.Text + "',date='" + date.Text + "',sex='" + sex.Text + "',address='" + address.Text + "',fine='" + fine.Text + "' WHERE member_id='" + member_id.Text + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record has been Updated");

                sqlCon.Close();

                member_view mv = (member_view)Application.OpenForms["member_view"];
                mv.loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void member_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (member_type.Text == "Teacher")
            {
                reg_no.Enabled = false;
                session.Enabled = false;
                roll_no.Enabled = false;
            }
            else
            {
                reg_no.Enabled = true;
                session.Enabled = true;
                roll_no.Enabled = true;
                session.Text = "2014-2016";
            }
        }

        private void member_type_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void first_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }

        private void reg_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }

        private void fine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void session_TextChanged(object sender, EventArgs e)
        {
        }

        private void session_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 45))
            {
                e.Handled = true;
            }
        }
    }
}