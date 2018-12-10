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
    public partial class Form1 : Form
    {
        private string Action;
        private DataGridView dataGridView1;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string Action)
        {
            InitializeComponent();
            this.Action = Action;

        }

        public Form1(string Action, DataGridView dataGridView1) : this(Action)
        {
            this.dataGridView1 = dataGridView1;
        }
      

        private void bt_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_Choice.Text = Action + " Machine";
            this.Text = Action + " Machine Form";
            txt_Id.DropDownStyle = ComboBoxStyle.DropDownList;
            switch (Action)
            {
                case "Add":
                       txt_Id.DropDownStyle = ComboBoxStyle.Simple;

                    break;
                case "Modify":
                    txt_Id.DataSource = ShowMachinesForm.machines.ListOfIds();
                    break;
                case "Delete":
                    txt_Id.DataSource = ShowMachinesForm.machines.ListOfIds();
                     //txt_Name.Enabled = false;
                    //txt_constructor.Enabled = false;
                    //cmb_type.Enabled = false;
                    //rdb_Functional.Enabled = false;
                    //rdb_NonFunctional.Enabled = false;
                    
                    
                    
                    
                    //An other possibility with foreach
                    foreach (Control x1 in this.Controls)
                    {
                        if (!(x1 is Button || x1 is Label))
                        {
                            x1.Enabled = false;
                        }
                    }
                    txt_Id.Enabled = true;
                    break;
            }

            //cmb_type.DataSource = Enum.GetValues(typeof(MachineType));
            cmb_type.SelectedIndex = 0;
            cmb_type.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void bt_Choice_Click(object sender, EventArgs e)
        {
            Machine m = new Machine();
            bool ok;
            int id;
            switch (Action)
            {
                case "Add":
                    m.Id = int.Parse(txt_Id.Text);
                    m.Name = txt_Name.Text;
                    m.Constructor = txt_constructor.Text;
                    m.Type = cmb_type.Text;
                    m.State = rdb_Functional.Checked;
                    ok = ShowMachinesForm.machines.AddMachine(m);
                    if (ok)
                    {
                        MessageBox.Show("Machine has been added");//use the snippet mbox + 2*TAB
                    }
                    else
                        MessageBox.Show("Machine is existed");
                    break;


                case "Modify":
                    id = int.Parse(txt_Id.Text);
                    m = ShowMachinesForm.machines.FindMachine(id);
                    if (m == null)
                        MessageBox.Show("Machine does not existe");
                    else
                    {
                        m.Name = txt_Name.Text;
                        m.Constructor = txt_constructor.Text;
                        m.Type = cmb_type.Text;
                        m.State = rdb_Functional.Checked;
                        MessageBox.Show("Machine has been Modified");
                    }
                   break;
                case "Delete":
                    id = int.Parse(txt_Id.Text);
                    ok = ShowMachinesForm.machines.DeleteMachine(id);
                    if (ok)
                    {
                        MessageBox.Show("Machine has been deleted");
                    }
                    else
                        MessageBox.Show("Machine does not existe");
                    break;
            }//fin switch

            //update the dtagridView content
           // dataGridView1.DataSource = null;//duplicate line ctrl+E+V
           // dataGridView1.DataSource = ShowMachinesForm.machines.ListOfMachines;


            //or this code that get all active forms
            FormCollection fc=Application.OpenForms;
            foreach (var x in fc)
            {
                if (((Form)x).Name== "ShowMachinesForm")
                {
                    ((ShowMachinesForm)x).GetDataGridView().DataSource = null;//duplicate line ctrl+E+V
                    ((ShowMachinesForm)x).GetDataGridView().DataSource = ShowMachinesForm.machines.ListOfMachines;


                }

            }

            
        }

       

        private void txt_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(txt_Id.Text);
            Machine m = ShowMachinesForm.machines.FindMachine(id);
            txt_Name.Text = m.Name;
            cmb_type.Text = m.Type;
            txt_constructor.Text = m.Constructor;
            rdb_Functional.Checked = m.State;
            rdb_NonFunctional.Checked = !m.State;
        }
    }
}
