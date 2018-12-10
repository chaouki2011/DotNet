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
    public partial class ModuleByTeacher : Form
    {
        public ModuleByTeacher()
        {
            InitializeComponent();
        }

        private void ModuleByTeacher_Load(object sender, EventArgs e)
        {
            var lststd = (from x in Form1.Udc.Teachers
                          join y in Form1.Udc.TeacherModules
                          on x.id equals y.IdTeacher
                          select new
                          {
                              x.name,
                              y.IdModule,
                              y.NbHours
                          }).ToList();
            dataGridView1.DataSource = lststd;
        }
    }
}
