using Fengyuan_Student_Cafeteria_Ordering_System;
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
            // SQL查询语句
            string query = "SELECT 窗口号 FROM 窗口信息";
            DataTable dataTable = data_work.DataQuery(query);
            // 将DataTable设置为ComboBox的数据源
            comboBox1.DataSource = dataTable;
            // 指定显示的列
            comboBox1.DisplayMember = "窗口号"; // 使用正确的列名

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // 获取用户在ComboBox中选择的手机号和姓名
                string Number = comboBox1.Text;

                // 获取用户输入的密码
                string Password = textBox1.Text;

                // 这里可以添加进一步的验证逻辑，比如从数据库中验证用户输入的信息是否正确

                // 假设你有一个方法 CheckCredentials 来验证用户信息
                DataTable win_in = win_info(Number, Password);
                if (win_in.Rows.Count == 1)
                {
                    string win_id = win_in.Rows[0]["窗口号"].ToString();
                    // 用户信息正确，进入系统
                    MessageBox.Show("登录成功！进入系统。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cafteria_manage form3 = new cafteria_manage(win_id);
                    this.Hide();
                    form3.ShowDialog();
                }
                else
                {
                    // 用户信息不正确，显示错误消息
                    MessageBox.Show("登录失败，请检查窗口号、窗口名称和密码是否正确。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                }
            }

            DataTable win_info(string Number, string password)
            {
                string query = string.Format("SELECT * FROM 窗口信息 WHERE 窗口号 ='{0}' AND 密码 = '{1}';", Number, password);
                DataTable dt = data_work.DataQuery(query);
                return dt;
            }
        }

        private void shangjia_login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
