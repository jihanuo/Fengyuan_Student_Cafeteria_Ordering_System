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

            if (string.IsNullOrEmpty(userPwd))
            {
                MessageBox.Show("密码不能为空!");
                return;
            }

            //判断密码是否为空

            if (string.IsNullOrEmpty(reuserPwd))
            {
                MessageBox.Show("确认密码不能为空!");
                return;
            }

            //判断确认密码是否为空

            if (string.IsNullOrEmpty(tell))
            {
                MessageBox.Show("电话号码不能为空!");
                return;
            }

            //判断电话号码是否为空

            string connStr = "server=DESKTOP-KP99S2Q;database=People;uid=sa;pwd=200299";

            //*************************在这里更改连接sql数据库的信息********************************

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string SELECT_sql = "SELECT 姓名 from yonghu where 姓名=@username";
                using (SqlCommand SELECT_cmd = new SqlCommand(SELECT_sql, conn))
                {
                    SELECT_cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.NVarChar)).Value = Name;
                    using (SqlDataReader check = SELECT_cmd.ExecuteReader())
                    {
                        if (check.Read())
                        {
                            MessageBox.Show("用户名已存在！");
                            return;
                        }
                    }
                }

                //用户名查重

                if (userPwd != reuserPwd)
                {
                    MessageBox.Show("两次输入密码不一致，请重新输入！");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    return;
                }

                //判断两次密码是否一致

                if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)

                //如果选择的combobox的前两项内容

                {
                    if (string.IsNullOrEmpty(userName))
                    {
                        MessageBox.Show("账号/教工号不能为空！");
                        return;
                    }

                    //账号不能为空
                    
                    string selectedValue = (comboBox1.SelectedIndex + 1).ToString();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO yonghu (身份编号,账号,姓名,手机号,密码) VALUES (@selectedValue, @userName, @Name, @telephone, @userPwd)", conn))
                    {
                        cmd.Parameters.AddWithValue("@selectedValue", selectedValue);
                        cmd.Parameters.AddWithValue("@userName", userName);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@telephone", tell);
                        cmd.Parameters.AddWithValue("@userPwd", userPwd);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        //使用填入的内容进行查询，并返回值

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("注册成功! 用户名: " + userName + "，密码: " + userPwd);
                            this.Close();

                            // Open a new window
                            progress newForm = new progress();
                            newForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("注册失败，请重试");
                        }
                    }
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    string selectedValue = "3";
                    Random random = new Random();
                    int randomNumber = random.Next(100000000, 999999999);
                    string randomString = "w" + randomNumber.ToString();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO yonghu (身份编号,账号,姓名,手机号,密码) VALUES (@selectedValue, @userName, @Name, @telephone, @userPwd)", conn))
                    {
                        cmd.Parameters.AddWithValue("@selectedValue", selectedValue);
                        cmd.Parameters.AddWithValue("@userName", randomString);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@telephone", tell);
                        cmd.Parameters.AddWithValue("@userPwd", userPwd);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("注册成功! 用户名: " + randomString + "，密码: " + userPwd);
                            this.Close();

                            // Open a new window
                            progress newForm = new progress();
                            newForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("注册失败，请重试");
                        }
                    }
                }
            }
        }
    }
}