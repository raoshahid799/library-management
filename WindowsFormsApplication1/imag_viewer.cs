using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class imag_viewer : Form
    {
        private String bookID;
        private byte[] img;

        public imag_viewer(String bookID)
        {
            this.bookID = bookID;
            InitializeComponent();
        }

        private void imag_viewer_Load(object sender, EventArgs e)
        {
            try
            {
                String con = ConfigurationManager.ConnectionStrings["WindowsFormsApplication1.Properties.Settings.librarayManagementConnectionString"].ConnectionString;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                String query = "SELECT cover_image  FROM book_registration WHERE book_id='" + bookID + "'";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader sql_data = cmd.ExecuteReader();

                sql_data.Read();

                pictureBox1.Image = Image.FromStream(sql_data.GetStream(0));

                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                img = ms.GetBuffer();
                ms.Close();

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}