using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class commentReview : Form
    {
        private String bookID;
        private byte[] img;
        private String member_type = "";
        //book  ki id ajaye gy phlay phr us k isbn no sy comment ko fetch kry gy

        public commentReview(String bookID)
        {
            this.bookID = bookID;
            InitializeComponent();
        }

        private void commentReview_Load(object sender, EventArgs e)
        {
            loadBook();

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
                    data = sql_data.GetString(0).Trim() + " " + sql_data.GetString(1).Trim();

                    student_ComboBox.Items.Add(data);
                }

                sql_data.Close();

                sqlCon.Close();

                student_ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                student_ComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            loadcomment();
        }

        private void loadcomment()
        {
            try
            {
                student_pane.Controls.Clear();
                teacher_pane.Controls.Clear();

                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();
                String query = "SELECT first_name,last_name,member_id ,date ,comment ,member_type FROM comment WHERE isbn='" + isbn.Text + "'";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader sql_data = cmd.ExecuteReader();
                String name = "";
                String comment = "";
                String date;
                if (sql_data.HasRows)
                {
                    while (sql_data.Read())
                    {
                        name = "";
                        comment = "";
                        name = name + sql_data.GetString(0).Trim();
                        name = name + " " + sql_data.GetString(1).Trim();
                        date = "" + sql_data.GetValue(3);
                        comment = sql_data.GetString(4);
                        comment = comment + "\n\n" + date + "\nMember ID:" + sql_data.GetValue(2);
                        if (sql_data.GetString(5).Trim() == "Teacher")
                        {
                            Label labelName = new Label();
                            Label labelComment = new Label();
                            labelName.Text = name;
                            labelName.AutoSize = true;
                            labelName.BackColor = System.Drawing.Color.LightSeaGreen;
                            labelName.ForeColor = System.Drawing.Color.White;
                            labelName.Font = new System.Drawing.Font("Arial", 14);
                            labelComment.BackColor = System.Drawing.Color.LightSeaGreen;
                            labelComment.ForeColor = System.Drawing.Color.White;
                            labelComment.Font = new System.Drawing.Font("Arial", 10);
                            labelComment.Margin = new Padding(0, 0, 0, 15);
                            labelComment.Text = comment;
                            labelComment.AutoSize = true;
                            teacher_pane.Controls.Add(labelName);
                            teacher_pane.Controls.Add(labelComment);
                        }
                        else
                        {
                            Label labelName = new Label();
                            labelName.Text = name;
                            labelName.AutoSize = true;
                            Label labelComment = new Label();
                            labelName.BackColor = System.Drawing.Color.LightSeaGreen;
                            labelName.ForeColor = System.Drawing.Color.White;
                            labelComment.Font = new System.Drawing.Font("Arial", 10);
                            labelComment.BackColor = System.Drawing.Color.LightSeaGreen;
                            labelComment.ForeColor = System.Drawing.Color.White;
                            labelComment.Margin = new Padding(0, 0, 0, 15);
                            labelName.Font = new System.Drawing.Font("Arial", 14);
                            labelComment.Text = comment;
                            labelComment.AutoSize = true;
                            student_pane.Controls.Add(labelName);
                            student_pane.Controls.Add(labelComment);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadBook()
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query = "SELECT book_id ,book_name ,author_name,isbn_no ,cover_image  FROM book_registration WHERE book_id='" + bookID + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader sql_data = cmd.ExecuteReader();
                sql_data.Read();
                book_id.Text = "" + sql_data.GetValue(0);
                book_name.Text = sql_data.GetString(1);
                author_name.Text = sql_data.GetString(2);
                isbn.Text = sql_data.GetString(3);
                pictureBox1.Image = Image.FromStream(sql_data.GetStream(4));
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                img = ms.GetBuffer();
                ms.Close();
                int h = pictureBox1.Height;
                int w = pictureBox1.Width;
                pictureBox1.Size = new System.Drawing.Size(w, h);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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
                if (mem_id.Text == "")
                {
                    MessageBox.Show("Please Enter Query to Search");
                }
                else
                {
                    String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();

                    String query = "SELECT member_id,first_name,last_name,member_type FROM member_registration WHERE member_id='" + mem_id.Text + "'";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    SqlDataReader sql_data = cmd.ExecuteReader();

                    if (sql_data.HasRows)
                    {
                        sql_data.Read();

                        member_id.Text = "" + sql_data.GetValue(0); //id is in int

                        first_name.Text = sql_data.GetString(1);
                        last_name.Text = sql_data.GetString(2);
                        member_type = sql_data.GetString(3);

                        sql_data.Close();
                    }
                    else
                    {
                        MessageBox.Show("Record not found");
                        member_id.Text = "";
                        first_name.Text = "";
                        last_name.Text = "";
                    }
                }
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

                String query = "SELECT member_id,first_name,last_name,member_type FROM member_registration WHERE first_name='" + first + "' AND last_name='" + last + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader sql_data = cmd.ExecuteReader();

                sql_data.Read();

                member_id.Text = "" + sql_data.GetValue(0); //id is in int

                first_name.Text = sql_data.GetString(1);
                last_name.Text = sql_data.GetString(2);
                member_type = sql_data.GetString(3);

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (member_id.Text == "")
                {
                    MessageBox.Show("Member ID can not be empty");
                }
                else
                {
                    String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();

                    String query = "INSERT INTO comment VALUES('" + first_name.Text + "','" + last_name.Text + "','" + member_id.Text + "','" + dateTimePicker1.Text + "','" + comment.Text + "','" + isbn.Text + "','" + member_type + "')";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved");
                    sqlCon.Close();
                    member_id.Text = "";
                    loadcomment();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}