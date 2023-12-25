using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fengyuan_Student_Cafeteria_Ordering_System
{
    public partial class cafteria_manage : Form
    {
        public cafteria_manage()
        {
            InitializeComponent();
        }
        public cafteria_manage(string win_id)
        {
            this.Tag = win_id;
            InitializeComponent();
        }
        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void cafteria_manage_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dingdan_lst.SelectedItems.Count > 0)
            {
                ListViewItem selected_item = dingdan_lst.SelectedItems[0];
                dingdan dd = new(selected_item);
                dd.Show();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "dingdan")// 默认显示全部订单
            {
                string sqlstr = string.Format("select * from 订单 where 窗口号 ='{0}' and 订单状态 <> '4' ;", this.Tag);//需绑定登录部分数据，暂设为1
                DataTable dt = data_work.DataQuery(sqlstr);
                dingdan_lst.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem myitem = new ListViewItem(dr["订单号"].ToString());
                    myitem.SubItems.Add(dr["餐食号"].ToString());
                    myitem.SubItems.Add(dr["窗口号"].ToString());
                    if (dr["订单状态"].ToString() == '1'.ToString())
                    {
                        myitem.SubItems.Add("已付款");
                    }
                    else if (dr["订单状态"].ToString() == '2'.ToString())
                    {
                        myitem.SubItems.Add("已接单");

                    }
                    else if (dr["订单状态"].ToString() == '5'.ToString())
                    {
                        myitem.SubItems.Add("售后单");

                    }
                    else if (dr["订单状态"].ToString() == '3'.ToString())
                    {
                        myitem.SubItems.Add("待取餐");

                    }
                    dingdan_lst.Items.Add(myitem);
                }
                dingdan_lst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            if (tabControl1.SelectedTab.Name == "caipin")
            {
                string sqlstr = string.Format("select * from 餐食 where 窗口号 ='{0}';", this.Tag);
                DataTable dt = data_work.DataQuery(sqlstr);
                caipin_lst.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem myitem = new ListViewItem(dr["餐食号"].ToString());
                    myitem.SubItems.Add(dr["餐食名称"].ToString());
                    myitem.SubItems.Add(dr["餐食价格"].ToString());
                    myitem.SubItems.Add(dr["制作时长"].ToString());

                    caipin_lst.Items.Add(myitem);
                }
                caipin_lst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }

        }
        protected void DataBind_dingdan_info(int i = 0)//i表示不同的订单状态，根据订单状态展示相应信息
        {
            string sqlstr = string.Format("select * from 订单 where 窗口号 ='{0}'and 订单状态 ={1} ;", this.Tag, i);//需绑定登录部分数据，暂设为1
            DataTable dt = data_work.DataQuery(sqlstr);
            dingdan_lst.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["订单号"].ToString());
                myitem.SubItems.Add(dr["餐食号"].ToString());
                myitem.SubItems.Add(dr["窗口号"].ToString());
                if (dr["订单状态"].ToString() == '1'.ToString())
                {
                    myitem.SubItems.Add("已付款");
                }
                else if (dr["订单状态"].ToString() == '2'.ToString())
                {
                    myitem.SubItems.Add("已接单");

                }
                else if (dr["订单状态"].ToString() == '5'.ToString())
                {
                    myitem.SubItems.Add("售后单");

                }
                else if (dr["订单状态"].ToString() == '3'.ToString())
                {
                    myitem.SubItems.Add("待取餐");

                }
                dingdan_lst.Items.Add(myitem);
            }
            dingdan_lst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "全部订单")
            {
                string sqlstr = string.Format("select * from 订单 where 窗口号 = '{0}'and 订单状态 <> '4';", this.Tag);
                DataTable dt = data_work.DataQuery(sqlstr);
                dingdan_lst.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem myitem = new ListViewItem(dr["订单号"].ToString());
                    myitem.SubItems.Add(dr["餐食号"].ToString());
                    myitem.SubItems.Add(dr["窗口号"].ToString());
                    if (dr["订单状态"].ToString() == '1'.ToString())
                    {
                        myitem.SubItems.Add("已付款");
                    }
                    else if (dr["订单状态"].ToString() == '2'.ToString())
                    {
                        myitem.SubItems.Add("已接单");

                    }
                    else if (dr["订单状态"].ToString() == '5'.ToString())
                    {
                        myitem.SubItems.Add("售后单");

                    }
                    else if (dr["订单状态"].ToString() == '3'.ToString())
                    {
                        myitem.SubItems.Add("待取餐");

                    }
                    dingdan_lst.Items.Add(myitem);
                }
                dingdan_lst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                groupBox1.Text = "全部订单";

            }
            else if (comboBox1.Text == "新订单")
            {
                DataBind_dingdan_info(1);
                groupBox1.Text = "新订单";
            }
            else if (comboBox1.Text == "售后单")
            {
                DataBind_dingdan_info(5);
                groupBox1.Text = "售后单";

            }
            else if (comboBox1.Text == "已接餐")
            {
                DataBind_dingdan_info(2);
                groupBox1.Text = "已接餐";

            }
            else if (comboBox1.Text == "待取餐")
            {
                DataBind_dingdan_info(3);
                groupBox1.Text = "待取餐";

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu_edit menu_Edit = new menu_edit();
            menu_Edit.ShowDialog();
        }

        private void dingdan_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dingdan_lst.SelectedItems.Count > 0)
            {
                ListViewItem selected_item = dingdan_lst.SelectedItems[0];

                dingdan dingdan = new dingdan(selected_item);
                dingdan.Show();
            }
        }

        private void caipin_lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (caipin_lst.SelectedItems.Count > 0)
            {
                ListViewItem selected_item = caipin_lst.SelectedItems[0];

                menu_edit menu_Edit = new menu_edit(selected_item);
                menu_Edit.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cafteria_manage_Load_1(object sender, EventArgs e)
        {

        }

        private void dingdan_Click(object sender, EventArgs e)
        {

        }
    }
}
