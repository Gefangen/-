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

namespace DBapp
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from studentinfo";
            OracleConnection con = new OracleConnection("data source=127.0.0.1:1521/orcl; User id=system;password=123456");
            try
            {
                con.Open();  //打开连接
                OracleCommand cmd = new OracleCommand(sql, con); //构造命令
                OracleDataReader ord = cmd.ExecuteReader();     //执行命令
                if (ord.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = ord;
                    this.dataGridView1.DataSource = bs;
                }
                else
                {
                    this.dataGridView1.DataSource = null;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select * from course";
            OracleConnection con = new OracleConnection("data source=127.0.0.1:1521/orcl; User id=system;password=123456");
            try
            {
                con.Open();  //打开连接
                OracleCommand cmd = new OracleCommand(sql, con); //构造命令
                OracleDataReader ord = cmd.ExecuteReader();     //执行命令
                if (ord.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = ord;
                    this.dataGridView1.DataSource = bs;
                }
                else
                {
                    this.dataGridView1.DataSource = null;
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
    }
}
