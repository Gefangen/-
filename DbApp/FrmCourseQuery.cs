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
    public partial class FrmCourseQuery : Form
    {
        public FrmCourseQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = Course.SelectCourse(this.textBox1.Text);
        }

        private void FrmCourseQuery_Load(object sender, EventArgs e)
        {

        }

        private void courseBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows.Count == 0)
                return;
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            if (e.ColumnIndex==0)
            {//表示用户点击了删除按钮
                string cno = row.Cells[0].Value.ToString();
                if (0==Course.DeleteCourse(cno))
                {
                    MessageBox.Show("delete success");
                    //this.dataGridView1.Rows.Remove(row);
                }
                else MessageBox.Show("没有找到数据");
            }
            else if(e.ColumnIndex==1)
            {//表示用户点击了修改按钮
                Course c = (Course)row.DataBoundItem;
                FrmCourseUpdate frm = new FrmCourseUpdate();
                frm.tbCno.Text = c.Cno;
                frm.tbCname.Text = c.Cname;
                frm.tbCpno.Text = c.Cpno;
                frm.tbCcredit.Text = c.Ccredit.ToString();
                frm.ShowDialog();
           }
        }

        private void courseBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }
    }
}
