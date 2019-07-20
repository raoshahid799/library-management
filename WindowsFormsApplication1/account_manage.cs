using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class account_manage : Form
    {
        public account_manage()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (new_user.Text == "" || new_pass.Text == "" || current_pass.Text == "" || current_user.Text == "")
                {
                    MessageBox.Show("Please fill All Field");
                }
                else
                {
                    String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();

                    String query = "UPDATE login SET user_name='" + new_user.Text + "',password=" + new_pass.Text + " WHERE user_name='" + current_user.Text + "' AND password='" + current_pass.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("User Name And Password have Updated");
                    }
                    else
                    {
                        MessageBox.Show("Invalid Current User Name And Password");
                    }
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}