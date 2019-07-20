using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class book_issuance : Form
    {
        public book_issuance()
        {
            InitializeComponent();
        }

        private void book_issuance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'librarayManagementDataSet.member_registration' table. You can move, or remove it, as needed.
            //  this.member_registrationTableAdapter.Fill(this.librarayManagementDataSet.member_registration);
            //adding data into member combo box
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query = "SELECT first_name,last_name,reg_no FROM member_registration";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader sql_data = cmd.ExecuteReader();

                String data = null;

                while (sql_data.Read())
                {
                    data = sql_data.GetString(0).Trim() + "  " + sql_data.GetString(1).Trim();

                    student_ComboBox.Items.Add(data);
                }

                sql_data.Close();

                sqlCon.Close();

                loadbook();

                student_ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                student_ComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

                book_combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                book_combo.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return_date.Value = return_date.Value.AddDays(15);//add 15 days in return date to get return date
        }

        private void loadbook()
        {
            try
            {
                book_combo.Items.Clear();
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query2 = "SELECT book_name FROM book_registration WHERE book_type='Normal' AND status='Available'";

                SqlCommand cmd2 = new SqlCommand(query2, sqlCon);
                SqlDataReader sql_data2 = cmd2.ExecuteReader();

                while (sql_data2.Read())
                {
                    book_combo.Items.Add(sql_data2.GetString(0));
                }

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void student_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                int length = student_ComboBox.Text.IndexOf(" ");

                String first = student_ComboBox.Text.Substring(0, length).Trim();
                String last = student_ComboBox.Text.Substring(++length).Trim();

                String query = "SELECT member_id,first_name,last_name,member_type,department FROM member_registration WHERE first_name='" + first + "' AND last_name='" + last + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader sql_data = cmd.ExecuteReader();

                if (sql_data.HasRows)
                {
                    sql_data.Read();

                    first_name.Text = sql_data.GetString(1);
                    last_name.Text = sql_data.GetString(2);
                    member_type.Text = sql_data.GetString(3);
                    member_id.Text = "" + sql_data.GetValue(0); //id is in int
                    department.Text = sql_data.GetString(4);
                }

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //check how many book are issued
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query = "SELECT status FROM book_issue WHERE member_id='" + member_id.Text + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader sql_data = cmd.ExecuteReader();

                int total = 0;
                if (sql_data.HasRows)
                {
                    while (sql_data.Read())
                    {
                        if (sql_data.GetString(0) == "issue")
                            total++;
                    }
                }

                issue_book.Text = "" + total;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void student_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (reg_textBox.Text == "")
                {
                    MessageBox.Show("Please Enter Query to Search");
                }
                else
                {
                    String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();

                    String query = "SELECT member_id,first_name,last_name,member_type,department FROM member_registration WHERE reg_no='" + reg_textBox.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader sql_data = cmd.ExecuteReader();

                    if (sql_data.HasRows)
                    {
                        sql_data.Read();

                        first_name.Text = sql_data.GetString(1);
                        last_name.Text = sql_data.GetString(2);
                        member_type.Text = sql_data.GetString(3);
                        member_id.Text = "" + sql_data.GetValue(0); //id is in int
                        department.Text = sql_data.GetString(4);

                        sql_data.Close();

                        try
                        {
                            String query6 = "SELECT status FROM book_issue WHERE member_id='" + member_id.Text + "'";

                            SqlCommand cmd6 = new SqlCommand(query6, sqlCon);
                            SqlDataReader sql_data6 = cmd6.ExecuteReader();

                            int total = 0;
                            if (sql_data6.HasRows)
                            {
                                while (sql_data6.Read())
                                {
                                    if (sql_data.GetString(0) == "issue")
                                        total++;
                                }
                            }

                            issue_book.Text = "" + total;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("Not Found");

                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void student_search2_Click(object sender, EventArgs e)
        {
            try
            {
                if (mem_id.Text == "")
                {
                    MessageBox.Show("Please Enter Query to Search");
                }
                else
                {
                    String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();

                    String query = "SELECT member_id,first_name,last_name,member_type,department FROM member_registration WHERE member_id='" + mem_id.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader sql_data = cmd.ExecuteReader();

                    if (sql_data.HasRows)
                    {
                        sql_data.Read();

                        first_name.Text = sql_data.GetString(1);
                        last_name.Text = sql_data.GetString(2);
                        member_type.Text = sql_data.GetString(3);
                        member_id.Text = "" + sql_data.GetValue(0); //id is in int
                        department.Text = sql_data.GetString(4);
                        sql_data.Close();

                        try
                        {
                            // checking the how many are issued
                            String query6 = "SELECT status FROM book_issue WHERE member_id='" + member_id.Text + "'";

                            SqlCommand cmd6 = new SqlCommand(query6, sqlCon);
                            SqlDataReader sql_data6 = cmd6.ExecuteReader();

                            int total = 0;
                            if (sql_data6.HasRows)
                            {
                                while (sql_data6.Read())
                                {
                                    if (sql_data6.GetString(0) == "issue")
                                        total++;
                                }
                            }

                            issue_book.Text = "" + total;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                        MessageBox.Show("Not Found");

                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void book_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query = "SELECT book_id,book_name,author_name,isbn_no,edition FROM book_registration WHERE book_name='" + book_combo.Text + "' AND book_type='Normal' AND status='Available'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader sql_data = cmd.ExecuteReader();

                sql_data.Read();

                book_id_text.Text = "" + sql_data.GetValue(0);  //id is in int
                book_name_text.Text = sql_data.GetString(1);
                atuthor_text.Text = sql_data.GetString(2);
                isbn_text.Text = sql_data.GetString(3);
                edition_text.Text = sql_data.GetString(4);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void book_search1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isbn_search_text.Text == "")
                {
                    MessageBox.Show("Please Enter Query to Search");
                }
                else
                {
                    String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();

                    String query = "SELECT book_id,book_name,author_name,isbn_no,edition FROM book_registration WHERE isbn_no='" + isbn_search_text.Text + "' AND book_type='Normal' AND status='Available'";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader sql_data = cmd.ExecuteReader();

                    if (sql_data.HasRows)
                    {
                        sql_data.Read();

                        book_id_text.Text = "" + sql_data.GetValue(0);  //id is in int
                        book_name_text.Text = sql_data.GetString(1);
                        atuthor_text.Text = sql_data.GetString(2);
                        isbn_text.Text = sql_data.GetString(3);
                        edition_text.Text = sql_data.GetString(4);
                    }
                    else
                        MessageBox.Show("Not Found");

                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void book_search2_Click(object sender, EventArgs e)
        {
            try
            {
                if (book_id.Text == "")
                {
                    MessageBox.Show("Please Enter Query to Search");
                }
                else
                {
                    String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();

                    String query = "SELECT book_id,book_name,author_name,isbn_no,edition FROM book_registration WHERE book_id='" + book_id.Text + "' AND book_type='Normal' AND status='Available'";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader sql_data = cmd.ExecuteReader();

                    if (sql_data.HasRows)
                    {
                        sql_data.Read();

                        book_id_text.Text = "" + sql_data.GetValue(0);  //id is in int
                        book_name_text.Text = sql_data.GetString(1);
                        atuthor_text.Text = sql_data.GetString(2);
                        isbn_text.Text = sql_data.GetString(3);
                        edition_text.Text = sql_data.GetString(4);
                    }
                    else
                        MessageBox.Show("Not Found");

                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void issue_button_Click(object sender, EventArgs e)
        {
            try
            {
                if ((member_id.Text == "") || (book_id_text.Text == ""))
                {
                    MessageBox.Show("Member ID and Book ID can not be Empty");
                }
                else
                {
                    if (int.Parse(issue_book.Text) < 2)
                    {
                        String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                        SqlConnection sqlCon = new SqlConnection(con);
                        sqlCon.Open();
                        String name;
                        name = first_name.Text + " " + last_name.Text;
                        String query = "INSERT INTO book_issue (member_id ,book_id,book_name,issue_date ,due_date ,status ,detail) VALUES ('" + member_id.Text + "','" + book_id_text.Text + "','" + book_name_text.Text + "','" + issue_date.Text + "','" + return_date.Text + "','issue','" + detail.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, sqlCon);
                        cmd.ExecuteNonQuery();

                        String query2 = "UPDATE book_registration SET status='unavailable' WHERE book_id='" + book_id_text.Text + "'";
                        SqlCommand cmd2 = new SqlCommand(query2, sqlCon);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Book has been Issue");
                        member_id.Text = "";
                        book_id_text.Text = "";
                        sqlCon.Close();

                        loadbook();
                    }
                    else
                    {
                        MessageBox.Show("Only 2 book is Available for Issuance");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void book_detail_Click(object sender, EventArgs e)
        {
            if (book_id_text.Text == "")
            {
                MessageBox.Show("Please Select the Book First");
            }
            else
            {
                String id = book_id_text.Text;
                commentReview cr = new commentReview(id);
                cr.Show();
            }
        }

        private void student_ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }

        private void reg_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }

        private void mem_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }
    }
}