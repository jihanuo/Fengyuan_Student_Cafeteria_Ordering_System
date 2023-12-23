using Fengyuan_Student_Cafeteria_Ordering_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Studentssystem
{
    public partial class PasswordForm : Form
    {

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rNo = txtNo.Text;
            string pw = txtoldPassword.Text;

            string sql1 = "select * from Student where 学号 = '" + rNo + "' and 密码 = '" + pw + "'";

            try
            {


                object reader = data_work.DataQuery(sql1);

                if (reader == null)
                {
                    MessageBox.Show("学生编号或者原密码输入错误！请重新输入");
                    txtNo.Text = string.Empty;
                    txtoldPassword.Text = string.Empty;
                    txtNewPassword.Text = string.Empty;
                    return;
                }
                else
                {
                    string sql2 = string.Format("update Student set 密码 = '{0}' where 学号 = '{1}' ", txtNewPassword.Text, rNo);
                    object reader1 = data_work.DataQuery(sql2);
                    if (reader == null)
                    {
                        MessageBox.Show("修改失败");
                        txtNo.Text = string.Empty;
                        txtoldPassword.Text = string.Empty;
                        txtNewPassword.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("修改成功!");
                    }
                }
            }
            catch { }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
