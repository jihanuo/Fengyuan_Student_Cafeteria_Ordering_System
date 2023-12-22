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
    public partial class menu_edit : Form
    {
        public menu_edit()
        {
            InitializeComponent();
        }
        public menu_edit(ListViewItem selected_item)
        {
            InitializeComponent();
            菜品.Text = selected_item.SubItems[1].Text;
            价格.Text = selected_item.SubItems[2].Text;
            制作时长.Text = selected_item.SubItems[3].Text;
            label5.Text= selected_item.SubItems[0].Text;
        }

        private void menu_edit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string caipin;
            double jiage, zhizuoshichang;
            caipin = 菜品.Text.ToString();
            jiage = Convert.ToDouble(价格.Text);
            zhizuoshichang = Convert.ToDouble(价格.Text);
            string sql_str = string.Format("insert into 餐食表 (菜品,价格,制作时长)values('{0}',{1},{2});",caipin,jiage,zhizuoshichang);
            int i = data_work.DataExcute(sql_str);
            if (i != 0) {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int bianhao = Convert.ToInt32(label5.Text);
            string sql_str = string.Format("delete from 餐食表 where (编号={0});", bianhao);
            int i = data_work.DataExcute(sql_str);
            if (i != 0)
            {
                this.Close();
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string caipin;
            double jiage, zhizuoshichang;
            caipin = 菜品.Text.ToString();
            jiage = Convert.ToDouble(价格.Text);
            zhizuoshichang = Convert.ToDouble(价格.Text);
            string sql_str = string.Format("insert into 餐食表 (菜品,价格,制作时长)values('{0}',{1},{2});", caipin, jiage, zhizuoshichang);
            int i = data_work.DataExcute(sql_str);
            if (i != 0)
            {
                this.Close();
            }
        }
    }
}
