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
        }

        private void dingdan_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql_str = string.Format("update 订单 set 订单状态 = 0 where 订单号 ='{0} '", label1.Text);
            int i = data_work.DataExcute(sql_str);
            if (0 != i)
            {
                MessageBox.Show(i.ToString());
            }
            //计算时间 
            string sql_str1 = string.Format("select 订单.订单号, 订单.餐食号,餐食.制作时长 from 订单,餐食 where 订单.窗口号='{0}'and 订单.订单状态=‘1’", label3.Text);
            DataTable time_dt = data_work.DataQuery(sql_str1);
            float total_time = 0;
            Dictionary<string, float> time_Dict = new Dictionary<string, float>();
            foreach (DataRow dr in time_dt.Rows)
            {
                total_time += (float)dr["制作时长"];
                time_Dict[dr["订单号"].ToString()] = total_time;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql_str = string.Format("update 订单 set 订单状态 = 0 where 订单号 ='{0} '", label1.Text);
            if (Convert.ToBoolean(data_work.DataExcute(sql_str)))
            {
                MessageBox.Show("出餐成功");
            }
            else
            {

            };
        }
    }
}
