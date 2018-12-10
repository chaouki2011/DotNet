using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqExercices
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {
            //if(txt_Id.Text[0])
        }

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_AddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student st = new Student();
                //st.id = int.Parse(txt_Id.Text);
                st.name = txt_Name.Text;
                st.bithday = dtp_birthday.Value;

                //insert The Photo from the PictureBox
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                st.photo = photo_aray;


                Form1.Udc.Students.InsertOnSubmit(st);
                Form1.Udc.SubmitChanges();
                MessageBox.Show("Student has been added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_BrowseForImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory = @"c:\";
            ofd.RestoreDirectory = true;
            ofd.Multiselect = false;
            ofd.Title = "Select an image";
            ofd.Filter = "All images types|*.jpg;*.jpeg;*.png|" +
                "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
                "Portable Network Graphic (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String f1 = ofd.FileName;
                pictureBox1.ImageLocation = f1;
                pictureBox1.Image = Image.FromFile(f1); // ou bien =new Bitmap(f1);
            }

        }
    }
}
