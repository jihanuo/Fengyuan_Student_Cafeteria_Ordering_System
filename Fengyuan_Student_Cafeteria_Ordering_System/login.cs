using System.Data.SqlTypes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "账号";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "密码";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string userName = textBox1.Text;
            string userPwd = textBox2.Text;
            string connStr = "server=DESKTOP-KP99S2Q;database=People;uid=sa;pwd=200299";
            
            //***************************************采用混合身份验证,在这里更改sql连接信息********************************************************

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            string sql = "select * from dbo.yonghu where 账号=@t1 and 密码=@t2 ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@t1", SqlDbType.VarChar).Value = userName;
            cmd.Parameters.Add("@t2", SqlDbType.VarChar).Value = userPwd;

            //填入查询条件

            object result = cmd.ExecuteScalar();

            //result为查询返回值

            //此处检查账号和密码是否为空

            if (textBox1.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }
            if (textBox2.Text == "")

            {
                MessageBox.Show("密码不能为空！");
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            //有返回值则登录成功，没有则提示错误↓

            if (result != null && result != DBNull.Value)
            {
                int count = Convert.ToInt32(result);
                if (count > 0)
                {
                    progress Form2 = new progress();
                    userName = textBox1.Text;
                    userPwd = textBox2.Text;
                    Form2.Show();//登录成功显示的下一个页面
                    MessageBox.Show("欢迎进入！", "登陆成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("用户名密码错误或者账户不存在。", "!提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("用户名密码错误或者账户不存在。", "!提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
            conn.Close();
        }

        //连接到注册界面
        private void button2_Click(object sender, EventArgs e)
        {
            register form2 = new register();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //此处功能为了方便演示，从而做的一个快速建立所需数据库的按钮

        private void button3_Click(object sender, EventArgs e)
        {
            // 连接到master数据库
            string connectionString = "Data Source=localhost;Initial Catalog=master;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // 创建名为People的数据库
            string createDatabaseQuery = "CREATE DATABASE People";
            SqlCommand createDatabaseCommand = new SqlCommand(createDatabaseQuery, connection);
            createDatabaseCommand.ExecuteNonQuery();

            // 切换到新创建的数据库
            connection.ChangeDatabase("People");

            // 创建名为yonghu的表
            string createTableQuery = "CREATE TABLE shangjia (窗口号 CHAR(15), 窗口名 VARCHAR(50),密码 VARCHAR(50))";
            SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection);
            createTableCommand.ExecuteNonQuery();

            // 切换到新创建的数据库
            connection.ChangeDatabase("People");

            // 创建名为shangjia的表
            string createTableQuery2 = "CREATE TABLE yonghu (身份编号 INT, 账号 VARCHAR(30),姓名 CHAR(50),手机号 char(15),密码 VARCHAR(50))";
            SqlCommand createTableCommand2 = new SqlCommand(createTableQuery2, connection);
            createTableCommand2.ExecuteNonQuery();

            // 关闭连接
            connection.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        //连接到商家的登录界面
        private void button4_Click(object sender, EventArgs e)
        {
            shangjia_login form3 = new shangjia_login();
            form3.ShowDialog();
        }
    }
}
