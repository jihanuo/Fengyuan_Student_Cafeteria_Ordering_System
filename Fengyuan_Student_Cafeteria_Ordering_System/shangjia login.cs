using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class shangjia_login : Form
    {
        public shangjia_login()
        {
            InitializeComponent();

            // 在构造函数中调用LoadComboBoxData方法
            LoadComboBoxData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 在ComboBox选项发生变化时的处理逻辑
        }

        private void LoadComboBoxData()
        {
            // 连接字符串，根据你的数据库配置进行修改
            string connectionString = "Data Source=DESKTOP-KP99S2Q;Initial Catalog=People;Integrated Security=True";

            // SQL查询语句
            string query = "SELECT 窗口号 FROM shangjia";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // 打开数据库连接
                    connection.Open();

                    // 使用DataAdapter填充DataSet
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // 关闭数据库连接
                    connection.Close();

                    // 将DataTable设置为ComboBox的数据源
                    comboBox1.DataSource = dataTable;

                    // 指定显示的列
                    comboBox1.DisplayMember = "窗口号"; // 使用正确的列名
                }
            }
            string query2 = "SELECT 窗口名称 FROM shangjia";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query2, connection))
                {
                    // 打开数据库连接
                    connection.Open();

                    // 使用DataAdapter填充DataSet
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable2 = new DataTable();
                    adapter.Fill(dataTable2);

                    // 关闭数据库连接
                    connection.Close();

                    // 将DataTable设置为ComboBox的数据源
                    comboBox2.DataSource = dataTable2;

                    // 指定显示的列
                    comboBox2.DisplayMember = "窗口名称"; // 使用正确的列名
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // 获取用户在ComboBox中选择的手机号和姓名
                string Number = comboBox1.Text;
                string Name = comboBox2.Text;

                // 获取用户输入的密码
                string Password = textBox1.Text; 

                // 这里可以添加进一步的验证逻辑，比如从数据库中验证用户输入的信息是否正确

                // 假设你有一个方法 CheckCredentials 来验证用户信息
                bool credentialsValid = CheckCredentials(Number, Name, Password);

                if (credentialsValid)
                {
                    // 用户信息正确，进入系统
                    MessageBox.Show("登录成功！进入系统。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    progress form3 = new progress();
                    form3.ShowDialog();

                    // ***********************************在这里添加登录成功之后要打开的商家的系统界面 *********************************************
                }
                else
                {
                    // 用户信息不正确，显示错误消息
                    MessageBox.Show("登录失败，请检查窗口号、窗口名称和密码是否正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }
            }

            bool CheckCredentials(string Number, string name, string password)
            {
                string connectionString = "Data Source=DESKTOP-KP99S2Q;Initial Catalog=People;Integrated Security=True";

                //在此处更改qsl的连接信息

                string query = "SELECT COUNT(*) FROM shangjia WHERE 窗口号 = @Number AND 窗口名称 = @Name AND 密码 = @Password";

                //根据规范    窗口名称   需要改为   窗口名

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Number", Number);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Password", password);
                        
                        //填入查询的信息

                        connection.Open();

                        int count = (int)command.ExecuteScalar();

                        connection.Close();

                        // 如果 count 大于 0，表示验证通过
                        return count > 0;
                    }
                }
            }
        }
    }
}
