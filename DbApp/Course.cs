using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace DbApp
{
    public class Course
    {
        public string Cno { get; set; }
        public string Cname { get; set; }
        public string Cpno { get; set; }
        public int Ccredit { get; set; }
        public static List<Course> SelectCourse(string cname)
        {
            string sql = "select cno,cname,cpno,ccredit from course where cname like :cname";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":cname", OracleDbType.Char, 40) };
            para[0].Value = cname + "%";
            List<Course> list = new List<Course>();
            //创建来凝结，打开链接，创建命令对象，执行命令，关闭连接
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader odr = cmd.ExecuteReader();
                while(odr.Read())
                {
                    Course c = new Course();
                    //c.Cno = odr.GetString(0);
                    c.Cno = odr["cno"].ToString();
                    c.Cname = odr.GetString(1);
                    if (odr.IsDBNull(2)) c.Cpno = null;
                    else c.Cpno = odr.GetString(2);
                    c.Ccredit = odr.GetInt32(3);
                    list.Add(c);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            return list;
        }
        public static int DeleteCourse(string cno)
        {
            int result = 0;
            string sql = "delete from course where cno=:cno";
            OracleParameter[] para = new OracleParameter[] { new OracleParameter(":cno", OracleDbType.Char, 4) };
            para[0].Value = cno;
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            return result;
        }
        public static int InsertCourse(Course c)
        {
            int result = 0;
            string sql = "insert into course(cno,cname.cpno,ccredit)values(:cno,:cname,:cpno,:ccredie)";
            OracleParameter[] para = new OracleParameter[] {new OracleParameter(":cno",OracleDbType.Char,4),
            new OracleParameter(":cname",OracleDbType.Char,40),new OracleParameter(":cpno",OracleDbType.Char,4),
            new OracleParameter(":ccredit",OracleDbType.Int32)};
            para[0].Value = c.Cno;
            para[1].Value = c.Cname;
            para[2].Value = c.Cpno;
            para[3].Value = c.Ccredit;
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            return result;
        }
        public static int UpdateCourse(Course c)
        {
            int result = 0;
            string sql = "update course set cname=:cname,cpno=:cpno,ccredit=:ccredit where cno=:cno";
            OracleParameter[] para = new OracleParameter[] {new OracleParameter(":cname",OracleDbType.Char,40),
            new OracleParameter(":cpno",OracleDbType.Char,4),new OracleParameter(":ccredit",OracleDbType.Int32),
            new OracleParameter(":cno",OracleDbType.Char,4)};
            para[0].Value = c.Cname;
            para[1].Value = c.Cpno;
            para[2].Value = c.Ccredit;
            para[3].Value = c.Cno;
            OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["strCon"].ConnectionString);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
            return result;
        }
    }
}
