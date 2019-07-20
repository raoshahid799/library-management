using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class member_registration : Form
    {
        public member_registration()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (member.Text == "Teacher")
                {
                    if (first_name.Text == "" || last_name.Text == "" || department.Text == "Select Department" || sex.Text == "Select Gender" || course.Text == "Select Class" || address.Text == "")
                    {
                        MessageBox.Show("Information is incomplate for Teacher");
                    }
                    else
                    {
                        String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                        SqlConnection sqlCon = new SqlConnection(con);
                        sqlCon.Open();
                        String query = "INSERT INTO member_registration (first_name ,last_name ,reg_no ,roll_no ,session ,course_name ,member_type ,department ,date ,sex ,address,fine) VALUES ('" + first_name.Text + "','" + last_name.Text + "','" + reg_no.Text + "','" + roll_no.Text + "','" + session.Text + "','" + course.Text + "','" + member.Text + "','" + department.Text + "','" + date.Text + "','" + sex.Text + "','" + address.Text + "',0)";

                        SqlCommand cmd = new SqlCommand(query, sqlCon);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Record has saved");
                        sqlCon.Close();
                    }
                }
                else
                {
                    if (first_name.Text == "" || last_name.Text == "" || reg_no.Text == "" || roll_no.Text == "" || course.Text == "Select Class" || department.Text == "Select Department" || sex.Text == "Select Gender" || address.Text == "")
                    {
                        MessageBox.Show("Information is incomplate for Students");
                    }
                    else
                    {
                        String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                        SqlConnection sqlCon = new SqlConnection(con);
                        sqlCon.Open();

                        String query = "INSERT INTO member_registration (first_name ,last_name ,reg_no ,roll_no ,session ,course_name ,member_type ,department ,date ,sex ,address,fine) VALUES ('" + first_name.Text + "','" + last_name.Text + "','" + reg_no.Text + "','" + roll_no.Text + "','" + session.Text + "','" + course.Text + "','" + member.Text + "','" + department.Text + "','" + date.Text + "','" + sex.Text + "','" + address.Text + "',0)";

                        SqlCommand cmd = new SqlCommand(query, sqlCon);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Record has saved");

                        sqlCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void member_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (member.Text == "Teacher")
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
            }
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