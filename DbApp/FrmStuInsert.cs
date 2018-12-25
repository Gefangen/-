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
    public partial class FrmStuInsert : Form
    {
        public FrmStuInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into student(sno,sname,ssex,sage,sdept)values('{0}','{1}','{2}',{3},'{4}')",
                tbSno.Text, tbSname.Text, tbSsex.Text, tbSage.Text, tbSdept.Text);
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();//打开连接
                OracleCommand cmd = new OracleCommand(sql, con);
                OracleDataReader odr = cmd.ExecuteReader();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("insert success");
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
