using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class book_edit : Form
    {
        private String bookID;
        private byte[] img;

        public book_edit(String bookID)
        {
            this.bookID = bookID;

            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query = "UPDATE book_registration    SET book_name ='" + book_name.Text + "',author_name ='" + author_name.Text + "',publisher ='" + publisher.Text + "',publish_year ='" + pub_year.Text + "',isbn_no ='" + isbn.Text + "',pages ='" + page.Text + "',edition ='" + edition.Text + "' ,price ='" + price.Text + "',book_type ='" + book_type.Text + "',rank ='" + rank.Text + "',department ='" + department.Text + "',[cover_image]=@cover   WHERE book_id='" + book_id.Text + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlParameter param = cmd.Parameters.AddWithValue("@cover", img);
                param.DbType = DbType.Binary;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record has been Saved");

                sqlCon.Close();

                view_book vb = (view_book)Application.OpenForms["view_book"];
                vb.loadbook();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void book_edit_Load(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query = "SELECT book_id ,book_name ,author_name ,publisher ,publish_year ,isbn_no ,pages ,edition ,price ,book_type ,rank ,department ,cover_image ,status FROM book_registration WHERE book_id='" + bookID + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader sql_data = cmd.ExecuteReader();

                sql_data.Read();

                book_id.Text = "" + sql_data.GetValue(0);
                book_name.Text = sql_data.GetString(1);
                author_name.Text = sql_data.GetString(2);
                publisher.Text = sql_data.GetString(3); //id is in int
                pub_year.Text = "" + sql_data.GetValue(4);
                isbn.Text = sql_data.GetString(5);
                page.Text = "" + sql_data.GetValue(6);
                edition.Text = sql_data.GetString(7); //id is in int

                price.Text = "" + sql_data.GetValue(8);
                book_type.Text = sql_data.GetString(9);
                rank.Text = sql_data.GetString(10);

                department.Text = sql_data.GetString(11);

                pictureBox1.Image = Image.FromStream(sql_data.GetStream(12));

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

        private void cover_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    String url = openFileDialog1.FileName;

                    img = File.ReadAllBytes(url);
                    MemoryStream ms = new MemoryStream(img);

                    cover_box.Text = url;
                    pictureBox1.Image = Image.FromStream(ms);

                    int h = pictureBox1.Height;
                    int w = pictureBox1.Width;
                    pictureBox1.Size = new System.Drawing.Size(w, h);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                if (result == DialogResult.Cancel)
                    cover_box.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void book_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && !(e.KeyChar == 8) && !(e.KeyChar == 32))
            {
                e.Handled = true;
            }
        }

        private void page_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
            {
                e.Handled = true;
            }
        }

        private void department_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}