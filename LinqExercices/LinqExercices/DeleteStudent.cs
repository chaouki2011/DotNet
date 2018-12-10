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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();
        }

        public static List<int> AllStudentsIds()
        {
            List<int> lststdIds=new List<int>();
            try
            {
                lststdIds = (from x in Form1.Udc.Students
                              select x.id).ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return lststdIds;
        }

        private void bt_DeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                
                int Id = int.Parse(cmb_Id.Text);
                Student st=Form1.Udc.Students.Single<Student>(s => s.id == Id);
                Form1.Udc.Students.DeleteOnSubmit(st);
                Form1.Udc.SubmitChanges();
                MessageBox.Show("Student has been Deleted");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteStudent_Load(object sender, EventArgs e)
        {
            cmb_Id.DataSource = AllStudentsIds();
        }

        private void cmb_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            var st = from s in Form1.Udc.Students
                     where s.id==int.Parse(cmb_Id.Text)
                         select new
                         {
                             s.name,
                             s.bithday
                         };
            foreach (var x in st)
            {
                lab_Name.Text = x.name;
                lab_bithday.Text = x.bithday.ToString();
            }
            
        }
    }
}
