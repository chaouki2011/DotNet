using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectedModeTp
{
    public partial class Form1 : Form
    {
        private SqlConnection conx=new SqlConnection(@"Data Source=DESKTOP-7J9ODH9\SQLEXPRESS;Initial Catalog=UniversityDB1;Integrated Security=True");
        private SqlCommand cmd;
        private SqlDataReader Dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_AddModule_Click(object sender, EventArgs e)
        {
            try
            {
                conx.Open();
                cmd = new SqlCommand();
                cmd.Connection = conx;
                cmd.CommandText = "insert into Module values(@Id,@Name,@NbHours)";
                //cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.Add("@Id", SqlDbType.Int);
                cmd.Parameters["@Id"].Value = int.Parse(txt_Id.Text);
                cmd.Parameters.Add("@Name", SqlDbType.Text);//ou bien cmd.Parameters.Add("@Name", SqlDbType.Text);
                cmd.Parameters["@Name"].Value = txt_Name.Text;
                cmd.Parameters.AddWithValue("@NbHours", int.Parse(txt_NbHours.Text));
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Module has been inserted");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conx.State==ConnectionState.Open)
                {
                    conx.Close();
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Module> lstModule = new List<Module>();
            try { 
            conx.Open();
                cmd = new SqlCommand();
            cmd.Connection = conx;
            cmd.CommandTimeout = 10;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *  from Module";
                
            using (Dr = cmd.ExecuteReader())
            {
                while (Dr.Read())
                {
                        Module m = new Module();
                        m.Id = Dr.GetInt32(0);
                        lstModule.Add(m);
                }
            }

                dataGridView1.DataSource = lstModule;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conx.State == ConnectionState.Open)
                {
                    conx.Close();
                }
            }
        }

    }
    
}
