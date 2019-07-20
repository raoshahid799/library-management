using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class book_registration : Form
    {
        public book_registration()
        {
            InitializeComponent();
        }

        private byte[] img;

        private void cover_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    String url = openFileDialog1.FileName;

                    img = File.ReadAllBytes(url);

                    cover_box.Text = url;
                    pictureBox1.Image = Image.FromFile(url);
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

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cover_box.Text == "")
                {
                    MemoryStream ms = new MemoryStream();
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    img = ms.GetBuffer();
                    ms.Close();
                }

                if (book_id.Text == "" || book_name.Text == "" || author_name.Text == "" || publisher.Text == "" || pub_year.Text == "" || edition.Text == "" || book_type.Text == "" || department.Text == "")
                {
                    MessageBox.Show("Compulsory field is not filled");
                }
                else
                {
                    if (img.Length > 2024000)
                    {
                        MessageBox.Show("Cover image size must be less then 2MB");
                    }
                    else
                    {
                        String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                        SqlConnection sqlCon = new SqlConnection(con);
                        sqlCon.Open();
                        String query = "INSERT INTO book_registration (book_id ,book_name ,author_name ,publisher ,publish_year ,isbn_no ,pages ,edition ,price ,book_type,rank ,department ,[cover_image],status) VALUES ('" + book_id.Text + "','" + book_name.Text + "','" + author_name.Text + "','" + publisher.Text + "','" + pub_year.Text + "','" + isbn.Text + "','" + page.Text + "','" + edition.Text + "','" + price.Text + "','" + book_type.Text + "','" + rank.Text + "','" + department.Text + "',@cover,'Available')";
                        SqlCommand cmd = new SqlCommand(query, sqlCon);
                        SqlParameter param = cmd.Parameters.AddWithValue("@cover", img);
                        param.DbType = DbType.Binary;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record has saved");
                        sqlCon.Close();
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void book_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar == 8))
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

        private void department_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}