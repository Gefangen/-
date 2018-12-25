using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBapp
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void 查询学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmstuQuery frm = new FrmstuQuery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStuinsert frm = new FrmStuinsert();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 课程查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCourseQuery frm = new FrmCourseQuery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCourseInsert frm = new FrmCourseInsert();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStatistics frm = new FrmStatistics();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MainForm1_Load(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            if(frm.ShowDialog(this)==DialogResult.OK)
            {

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
