using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace DbApp
{
    public partial class FrmStuUpdate : Form
    {
        public FrmStuUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("update student set sname='{0}',ssex='{1}',sage={2},sdept='{3}' where sno='{4}'",
                this.tbSname.Text, this.tbSsex.Text, this.tbSage.Text, this.tbSdept.Text, this.tbSno.Text);
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();//打开连接
                OracleCommand cmd = new OracleCommand(sql, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("updeta success");
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
    }
}
