using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqExercices
{
    public partial class ModifyStudent : Form
    {
        public ModifyStudent()
        {
            InitializeComponent();
        }

        private void ModifyStudent_Load(object sender, EventArgs e)
        {
            cmb_Id.DataSource = (from s in Form1.Udc.Students
                                 select s.id).ToList();
        }

        private void bt_AddStudent_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmb_Id.Text);
            Student st = Form1.Udc.Students.Single<Student>(s => s.id == id);
            st.name = txt_Name.Text;
            st.bithday = dtp_birthday.Value;
            Form1.Udc.SubmitChanges();
            MessageBox.Show("Student has been updated");
        }

        private void cmb_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cmb_Id.Text);
                Student st = Form1.Udc.Students.Single<Student>(s => s.id == id);
                txt_Name.Text = st.name;
                dtp_birthday.Value = (DateTime)st.bithday;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
