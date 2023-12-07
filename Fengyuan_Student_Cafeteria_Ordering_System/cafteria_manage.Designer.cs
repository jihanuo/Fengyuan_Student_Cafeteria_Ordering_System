namespace Fengyuan_Student_Cafeteria_Ordering_System
{
    partial class cafteria_manage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dingdan = new TabPage();
            groupBox1 = new GroupBox();
            dingdan_lst = new ListView();
            订单号 = new ColumnHeader();
            餐食号 = new ColumnHeader();
            窗口号 = new ColumnHeader();
            订单状态 = new ColumnHeader();
            comboBox1 = new ComboBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            dingdan.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(dingdan);
            tabControl1.Location = new Point(12, 21);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1611, 990);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(8, 45);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1595, 937);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "菜品管理";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dingdan
            // 
            dingdan.Controls.Add(groupBox1);
            dingdan.Location = new Point(8, 45);
            dingdan.Name = "dingdan";
            dingdan.Padding = new Padding(3);
            dingdan.Size = new Size(1595, 937);
            dingdan.TabIndex = 1;
            dingdan.Text = "订单管理";
            dingdan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dingdan_lst);
            groupBox1.Location = new Point(89, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1407, 772);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "全部订单";
            // 
            // dingdan_lst
            // 
            dingdan_lst.Columns.AddRange(new ColumnHeader[] { 订单号, 餐食号, 窗口号, 订单状态 });
            dingdan_lst.FullRowSelect = true;
            dingdan_lst.Location = new Point(32, 59);
            dingdan_lst.MultiSelect = false;
            dingdan_lst.Name = "dingdan_lst";
            dingdan_lst.Size = new Size(944, 686);
            dingdan_lst.TabIndex = 0;
            dingdan_lst.UseCompatibleStateImageBehavior = false;
            dingdan_lst.View = View.Details;
            dingdan_lst.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // 订单号
            // 
            订单号.Text = "订单号";
            订单号.Width = 100;
            // 
            // 餐食号
            // 
            餐食号.Text = "餐食号";
            餐食号.Width = 100;
            // 
            // 窗口号
            // 
            窗口号.Text = "窗口号";
            窗口号.Width = 100;
            // 
            // 订单状态
            // 
            订单状态.Text = "订单状态";
            订单状态.Width = 150;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "全部订单", "新订单", "已接餐", "售后单" });
            comboBox1.Location = new Point(1010, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 39);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1010, 163);
            label1.Name = "label1";
            label1.Size = new Size(158, 31);
            label1.TabIndex = 2;
            label1.Text = "选择订单类型";
            // 
            // cafteria_manage
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1712, 1023);
            Controls.Add(tabControl1);
            Name = "cafteria_manage";
            Text = "cafteria_manage";
            tabControl1.ResumeLayout(false);
            dingdan.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage dingdan;
        private GroupBox groupBox1;
        private ListView dingdan_lst;
        private ColumnHeader 订单号;
        private ColumnHeader 餐食号;
        private ColumnHeader 窗口号;
        private ColumnHeader 订单状态;
        private ComboBox comboBox1;
        private Label label1;
    }
}