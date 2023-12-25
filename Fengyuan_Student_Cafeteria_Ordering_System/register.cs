using Fengyuan_Student_Cafeteria_Ordering_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace login
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //下面两段主要是一个textbox的焦点显示功能的制作

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (textBox1.Text == "外来人员可以为空")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "外来人员可以为空";
                textBox1.ForeColor = Color.Gray;
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            string userPwd = textBox2.Text.Trim();
            string reuserPwd = textBox3.Text.Trim();
            string tell = textBox4.Text.Trim();
            string Name = textBox5.Text.Trim();

            //对输入的所有内容进行定义

            if (string.IsNullOrEmpty(userPwd))//判断密码是否为空
            {
                MessageBox.Show("密码不能为空!");
                return;
            }
            if (string.IsNullOrEmpty(reuserPwd))//判断确认密码是否为空
            {
                MessageBox.Show("确认密码不能为空!");
                return;
            }
            if (string.IsNullOrEmpty(tell))//判断电话号码是否为空
            {
                MessageBox.Show("电话号码不能为空!");
                return;
            }


            string SELECT_sql = string.Format("SELECT 姓名 from 用餐用户 where 姓名='{0}'", userName);
            IDataReader check = data_work.DataQuery(SELECT_sql).CreateDataReader();
            if (check.Read())//用户名查重
            {
                MessageBox.Show("用户名已存在！");
                return;
            }

            if (userPwd != reuserPwd)//判断两次密码是否一致
            {
                MessageBox.Show("两次输入密码不一致，请重新输入！");
                textBox2.Text = "";
                textBox3.Text = "";
                return;
            }
            if (string.IsNullOrEmpty(userName))//账号不能为空
            {
                MessageBox.Show("账号/教工号不能为空！");
                return;
            }
            string sql_str2 = string.Format("INSERT INTO 用餐用户 (账号,姓名,手机号,密码) VALUES ('{0}','{1}','{2}','{3}')", userName, Name, tell, userPwd);
            int rowsAffected = data_work.DataExcute(sql_str2);
            //使用填入的内容进行查询，并返回值

            if (rowsAffected > 0)
            {
                MessageBox.Show("注册成功! 用户名: " + userName + "，密码: " + userPwd);
                this.Close();
                // Open a new window
                login newForm = new login();
                newForm.Show();
            }
            else
            {
                MessageBox.Show("注册失败，请重试");
            }
        }
    }
}
