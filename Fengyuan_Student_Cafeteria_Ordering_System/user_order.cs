using shujukusheji;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fengyuan_Student_Cafeteria_Ordering_System
{
    public partial class user_order : Form
    {
        private double totalPrice = 0.0;
        private Dictionary<string, double> menuPrices = new Dictionary<string, double>();

        public user_order()
        {
            InitializeComponent();
        }
        public user_order(string win_name, string user_id)
        {
            InitializeComponent();
            this.Text = win_name;
            this.Tag = user_id;
        }
        private void user_order_Load(object sender, EventArgs e)
        {
            Table_show(this.Text);

        }
        public void Table_show(string win_name)
        {
            dataGridView1.Rows.Clear();//清空旧数据
            string sql_str = string.Format("select 餐食名称, 介绍, 餐食价格 from 餐食 where 窗口号 = (select 窗口号 from 窗口信息 where 窗口名 ='{0}')", win_name);
            DataTable dt = data_work.DataQuery(sql_str);
            foreach (DataRow dc in dt.Rows)
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void commit_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (string caipin in listBox1.Items)
            {
                string str_sql = string.Format("INSERT into 订单 (餐食号, 窗口号,账号, 创建时间, 订单状态) VALUES ((select 餐食号 from 餐食 where 餐食名称 = '{0}'),(select 窗口号 from 餐食 where 餐食名称 = '{0}'),'{1}',GETDATE(), '1')", caipin, this.Tag);
                if (Convert.ToBoolean(data_work.DataExcute(str_sql)))
                {
                    i++;
                }

            }
            if (i == listBox1.Items.Count)
            {
                MessageBox.Show("点单成功！ 请在用户端刷新查看");
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedMenu = listBox1.SelectedItem.ToString();

                if (menuPrices.ContainsKey(selectedMenu))
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                    // 删除菜品对应的价格
                    double priceToRemove = menuPrices[selectedMenu];

                    totalPrice -= priceToRemove;

                    label3.Text = totalPrice.ToString("C2");


                }
            }


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] str = new string[dataGridView1.Rows.Count];

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    str[i] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    double price = Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
                    totalPrice += price;
                    if (!menuPrices.ContainsKey(str[i]))
                    {
                        menuPrices.Add(str[i], price);

                    }
                    listBox1.Items.Add(str[i]);
                    label3.Text = totalPrice.ToString();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
