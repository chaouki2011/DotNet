using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineManger
{
    public partial class ShowMachinesForm : Form
    {
        internal static Machines machines = new Machines();
       
        public ShowMachinesForm()
        {
            InitializeComponent();
        }

        
        private void bt_Add_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1("Add",this.dataGridView1);
         //ou bien   Form1 f1 = new Form1(bt_Add.Text);

            f1.Show();
        }

        private void bt_Modify_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(bt_Modify.Text);
            f1.Show();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(bt_delete.Text);
            f1.Show();
        }

        private void bt_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res= MessageBox.Show("Would you really exit?","Exit confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowMachinesForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = machines.ListOfMachines;
        }
        public DataGridView GetDataGridView()
        {
            return dataGridView1;
        }
    }
}
