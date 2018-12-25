using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from student where sno=:sno and pwd=:pwd";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":sno",OracleDbType.Char,9),
            new OracleParameter(":pwd",OracleDbType.Varchar2,20)};
            para[0].Value = this.tbSno.Text;
            para[1].Value = this.tbPwd.Text;
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();//打开连接
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.HasRows)
                {
                    MessageBox.Show("成功登陆");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("用户名或密码错误"); ;
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
