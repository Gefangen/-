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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 查询学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStuQuery frm =new FrmStuQuery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //打开添加学生窗体
            FrmStuInsert frm = new FrmStuInsert();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 查询课程ToolStripMenuItem_Click(object sender, EventArgs e)
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
            FrmStatistic frm = new DbApp.FrmStatistic();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
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
