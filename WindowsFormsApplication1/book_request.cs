using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class book_request : Form
    {
        public book_request()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (book_name.Text == "" || author_name.Text == "" || first_name.Text == "" || last_name.Text == "")
                {
                    MessageBox.Show("Book Name and Author Name and Member Name is Compulsory");
                }
                else
                {
                    String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();

                    String query = "INSERT INTO book_request (member_id,book_name ,author_name ,publisher ,isbn_no ,pub_year ,edition ,date ,status) VALUES ('" + member_id.Text + "','" + book_name.Text + "','" + author_name.Text + "','" + publisher.Text + "','" + isbn.Text + "','" + pub_year.Text + "','" + edition.Text + "','" + dateTimePicker1.Text + "','Pending')";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Request has been Received");
                    sqlCon.Close();

                    book_name.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Search_Click(object sender, EventArgs e)
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

                    String query = "SELECT first_name,last_name FROM member_registration WHERE member_id='" + member_id.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        first_name.Text = reader.GetString(0);
                        last_name.Text = reader.GetString(1);
                    }
                    else
                    {
                        MessageBox.Show("Not Found");

                        first_name.Text = "";
                        last_name.Text = "";
                    }
                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void member_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
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