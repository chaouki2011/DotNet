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
    public partial class Form1 : Form
    {
        public static UniversityDataContext Udc = new UniversityDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllStudent s1 = new ShowAllStudent(false);
            s1.MdiParent = this;
            s1.Show();
        }
        private void findStudentToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    ShowAllStudent s1 = new ShowAllStudent(true);
                    s1.MdiParent = this;
                    s1.Show();
                }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent ast = new AddStudent();
            ast.MdiParent = this;
            ast.Show();
        }

        

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyStudent mst = new ModifyStudent();
            mst.MdiParent = this;
            mst.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moduleByTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModuleByTeacher mbt = new ModuleByTeacher();
            mbt.MdiParent = this;
            mbt.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent mbt = new DeleteStudent();
            mbt.MdiParent = this;
            mbt.Show();
        }
    }
}
