using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class book_registration : Form
    {
        public book_registration()
        {
            InitializeComponent();
        }

        byte[] photo;

        private void cover_Click(object sender, EventArgs e)
        {
            try{

                DialogResult result = openFileDialog1.ShowDialog();
                   

                if (result == DialogResult.OK)
                {
                    String url = openFileDialog1.FileName;

                   
                    
                    cover_box.Text = url;
                }
                if (result == DialogResult.Cancel)
                    cover_box.Text = "";

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void save_Click(object sender, EventArgs e)
        {

            try
            {
                /*
                if (book_id.Text == "" || book_name.Text == "" || author_name.Text == "" || publisher.Text == "" || pub_year.Text == "" || edition.Text == "" || book_type.Text == "" || department.Text == "")
                {

                    MessageBox.Show("Compulsory field is not filled");
                }
                else
                {

                */

                    if (cover_box.Text == "")
                        photo = GetPhoto(@"\Resources\no-image.png");

                    else
                        photo = GetPhoto(cover_box.Text);

                
                    
                    /*

                    if (photo.Length > 3024000)
                    {
                        MessageBox.Show("Cover image size must be less then 3MB");
                    }
                    else
                    {
                        String con = @"Data Source=DESKTOP-Q1SVI70\SQLEXPRESS;Initial Catalog=librarayManagement;Integrated Security=True";
                        SqlConnection sqlCon = new SqlConnection(con);
                        sqlCon.Open();

                        String query = "INSERT INTO dbo.book_registration (book_id ,book_name ,author_name ,publisher ,publish_year ,isbn_no ,pages ,edition ,price ,book_type,rank ,department ,cover_image) VALUES ('" + book_id.Text + "','" + book_name.Text + "','" + author_name.Text + "','" + publisher.Text + "','" + pub_year.Text + "','" + isbn.Text + "','" + page.Text + "','" + edition.Text + "','" + price.Text + "','" + book_type.Text + "','" + rank.Text + "','" + department.Text + "','" + photo + "')";

                        SqlCommand cmd = new SqlCommand(query, sqlCon);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Record has saved");

                        sqlCon.Close();


                    }
                    */


            //    }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }



        }

        public static byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }

    }
}
