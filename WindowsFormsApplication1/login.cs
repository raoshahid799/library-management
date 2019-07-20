using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.Text == "" || pass.Text == "")
                {
                    MessageBox.Show("Please Enter Password or User Name First");
                }
                else
                {
                    String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();
                    String query = "SELECT type FROM login WHERE user_name='" + user.Text + "' AND password='" + pass.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        String id = reader.GetString(0);
                        if (id == "Admin")
                        {
                            Form1 f = new Form1(1);
                            f.Closed += (s, arg) => this.Close();
                            this.Hide();
                            f.Show();
                        }
                        else
                        {
                            Form1 f = new Form1(2);
                            f.Closed += (s, arg) => this.Close();
                            this.Hide();
                            f.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show(" User Name OR Password Incorrect !");
                    }
                    reader.Close();
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }
    }
}