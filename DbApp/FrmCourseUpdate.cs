using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbApp
{
    public partial class FrmCourseUpdate : Form
    {
        public FrmCourseUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Cno = tbCno.Text;
            c.Cname = tbCname.Text;
            c.Cpno = tbCpno.Text;
            c.Ccredit = Convert.ToInt32(tbCcredit.Text);
            if (Course.UpdateCourse(c) == 1)
                MessageBox.Show("update success");
            else
                MessageBox.Show("没有找到记录");
        }
    }
}
