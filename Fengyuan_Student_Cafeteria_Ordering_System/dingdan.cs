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
    public partial class dingdan : Form
    {
        public dingdan()
        {
            InitializeComponent();
        }

        public dingdan(ListViewItem selected_item)
        {
            InitializeComponent();
            label1.Text = selected_item.SubItems[0].Text;
            label2.Text = selected_item.SubItems[1].Text;
            label3.Text = selected_item.SubItems[2].Text;
            if (selected_item.SubItems[3].Text == "已付款")// 根据订单状态，控制按钮是否可用
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;

            }
            if (selected_item.SubItems[3].Text == "已接单")
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;

            }

        }

        private void button1_Click(object sender, EventArgs e)//接单
        {

            string sql_str = string.Format("update 订单 set 订单状态 = 2, 接单时间 = '{0}' where 订单号 ='{1}';", DateTime.Now, label1.Text);
            int i = data_work.DataExcute(sql_str);
            if (0 != i)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)// 出餐
        {
            string sql_str = string.Format("update 订单 set 订单状态 = 3 where 订单号 ='{0} '", label1.Text);
            if (Convert.ToBoolean(data_work.DataExcute(sql_str)))
            {
                MessageBox.Show("出餐成功");
            }
            else
            {

            };
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dingdan_Load_1(object sender, EventArgs e)
        {

        }
    }
}
