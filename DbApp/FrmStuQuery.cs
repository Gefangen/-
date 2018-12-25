using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
namespace DbApp
{
    public partial class FrmStuQuery : Form
    {
        public FrmStuQuery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1、创建连接对象；2、打开链接；3、创建命令对象；4、执行；5、关闭连接
            string sql = string.Format("select sno,sname,ssex,sage,sdept from student where sname like '{0}%'",this.textBox1.Text);
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();//打开连接
                OracleCommand cmd = new OracleCommand(sql, con);
                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = odr;
                    this.dataGridView1.DataSource = bs;
                }
                else
                    this.dataGridView1.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.SelectedRows.Count==0)
            {
                MessageBox.Show("请选中后再删除");
                return;
            }
            if (MessageBox.Show("是否删除数据", "confirm message", MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;
            DataGridViewRow row = this.dataGridView1.SelectedRows[0];
            string sql = string.Format("delete from student where sno= '{0}'", row.Cells[0].Value.ToString());
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();//打开连接
                OracleCommand cmd = new OracleCommand(sql, con);
                OracleDataReader odr = cmd.ExecuteReader();
                if (cmd.ExecuteNonQuery()==0)
                {
                    MessageBox.Show("delete success");
                    this.dataGridView1.Rows.Remove(row);
                }
                else
                {
                    MessageBox.Show("没有找到学生");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0) return;
            DataGridViewRow row = this.dataGridView1.SelectedRows[0];
            FrmStuUpdate frm = new FrmStuUpdate();
            frm.tbSno.Text = row.Cells[0].Value.ToString();
            frm.tbSname.Text = row.Cells[1].Value.ToString();
            frm.tbSsex.Text = row.Cells[2].Value.ToString();
            frm.tbSage.Text = row.Cells[3].Value.ToString();
            frm.tbSdept.Text = row.Cells[4].Value.ToString();
            frm.ShowDialog(this);
        }
    }
}
