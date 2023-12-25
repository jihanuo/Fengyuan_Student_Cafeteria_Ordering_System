using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fengyuan_Student_Cafeteria_Ordering_System
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }
        public user(string user_name)
        {
            InitializeComponent();
            this.Tag = user_name;
        }

        private void zhongxikuaican_Click(object sender, EventArgs e)
        {
            user_order_show(sender);
        }

        private void zhajihanbao_Click(object sender, EventArgs e)
        {
            user_order_show(sender);
        }

        private void user_order_show(object sender)
        {
            Button clickedButton = sender as Button;
            string buttonName = clickedButton.Text;
            string user_id = this.Tag.ToString();
            user_order user_Order = new user_order(buttonName, user_id);
            user_Order.Show();
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void user_Load(object sender, EventArgs e)
        {
            qucan_show();
        }
        private void qucan_show()
        {
            string sql_str1 = string.Format(" select 订单.订单号, 订单.餐食号,餐食.制作时长 from 订单,餐食 where 订单.餐食号=餐食.餐食号 and 订单.订单状态='2'and 账号='{0}';", this.Tag);
            DataTable time_dt = data_work.DataQuery(sql_str1);
            float total_time = 0;
            Dictionary<string, float> time_Dict = new Dictionary<string, float>();
            foreach (DataRow dr in time_dt.Rows)
            {
                total_time += (float)dr["制作时长"];
                time_Dict[dr["订单号"].ToString()] = total_time;
            }

            string sql_str = string.Format("select 订单.订单号,餐食.餐食名称,订单.订单状态,订单.接单时间,窗口信息.窗口名 from 订单,窗口信息,餐食 where 订单.账号 = '{0}'and (订单.订单状态 between 1 and 3)and 订单.窗口号=窗口信息.窗口号 and 餐食.餐食号=订单.餐食号;", this.Tag);
            DataTable dt = data_work.DataQuery(sql_str);
            qucan_list.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["餐食名称"].ToString());
                if (dr["订单状态"].ToString() == '1'.ToString())
                {
                    myitem.SubItems.Add("已付款");
                }
                else if (dr["订单状态"].ToString() == '2'.ToString())
                {
                    myitem.SubItems.Add("已接单");

                }
                else if (dr["订单状态"].ToString() == '3'.ToString())
                {
                    myitem.SubItems.Add("待取餐");

                }
                if (time_Dict.ContainsKey(dr["订单号"].ToString()))
                {
                    DateTime a = Convert.ToDateTime(dr["接单时间"].ToString()).AddMinutes(time_Dict[dr["订单号"].ToString()]);
                    myitem.SubItems.Add(a.ToString());
                }
                else if (dr["订单状态"].ToString() == '3'.ToString())
                {
                    myitem.SubItems.Add(DateTime.Now.ToString());
                }
                else
                {
                    myitem.SubItems.Add("待接餐");

                }
                myitem.SubItems.Add(dr["订单号"].ToString());
                myitem.SubItems.Add(dr["窗口名"].ToString());
                qucan_list.Items.Add(myitem);
            }
            qucan_list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void qucan_Click(object sender, EventArgs e)
        {
            if (qucan_list.SelectedItems.Count > 0)
            {
                ListViewItem selected_item = qucan_list.SelectedItems[0];
                int dingdan_id = Convert.ToInt32(selected_item.SubItems[3].Text);
                string sql_str = string.Format("UPDATE 订单 SET 订单状态 = '4'WHERE 订单号 = {0};", dingdan_id);
                data_work.DataExcute(sql_str);
                qucan_show();
            }

        }

        private void dingdan_view_Click(object sender, EventArgs e)
        {
            qucan_show();
        }

        private void qucan_list_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void user_center_Click(object sender, EventArgs e)
        {
            Studentssystem.PasswordForm passwordForm = new Studentssystem.PasswordForm();
            passwordForm.Show();
        }

        private void mianfenzhuanjia_Click(object sender, EventArgs e)
        {
            user_order_show(sender);

        }

        private void malaxiangguo_Click(object sender, EventArgs e)
        {
            user_order_show(sender);

        }

        private void yuansuzhushi_Click(object sender, EventArgs e)
        {
            user_order_show(sender);
        }

        private void nanfangweidao_Click(object sender, EventArgs e)
        {
            user_order_show(sender);

        }

        private void zzrishang_Click(object sender, EventArgs e)
        {
            user_order_show(sender);

        }

        private void f_niuroufan_Click(object sender, EventArgs e)
        {
            user_order_show(sender);
        }
    }
}
