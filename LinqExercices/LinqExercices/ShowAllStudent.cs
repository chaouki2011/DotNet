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
    public partial class ShowAllStudent : Form
    {
        private bool choice;

        public ShowAllStudent(bool v)
        {
            InitializeComponent();
            this.choice = v;
        }
        public ShowAllStudent()
        {
            InitializeComponent();
        }
        

        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowAllStudent_Load(object sender, EventArgs e)
        {
            if (choice == true)
            {
                groupBox1.Show();
            }
            else
            {
                groupBox1.Hide();
                dataGridView1.Location = groupBox1.Location;
            }
            dataGridView1.DataSource = Form1.Udc.Students;


        }
    }
}
