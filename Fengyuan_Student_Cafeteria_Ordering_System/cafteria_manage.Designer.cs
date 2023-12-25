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
            caipin = new TabPage();
            button1 = new Button();
            caipin_lst = new ListView();
            编号 = new ColumnHeader();
            菜品 = new ColumnHeader();
            价格 = new ColumnHeader();
            制作时间 = new ColumnHeader();
            dingdan = new TabPage();
            groupBox1 = new GroupBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            dingdan_lst = new ListView();
            订单号 = new ColumnHeader();
            餐食号 = new ColumnHeader();
            窗口号 = new ColumnHeader();
            订单状态 = new ColumnHeader();
            tabControl1.SuspendLayout();
            caipin.SuspendLayout();
            dingdan.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(caipin);
            tabControl1.Controls.Add(dingdan);
            tabControl1.Location = new Point(11, 21);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1611, 989);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // caipin
            // 
            caipin.Controls.Add(button1);
            caipin.Controls.Add(caipin_lst);
            caipin.Location = new Point(8, 45);
            caipin.Name = "caipin";
            caipin.Padding = new Padding(3);
            caipin.Size = new Size(1595, 936);
            caipin.TabIndex = 0;
            caipin.Text = "菜品管理";
            caipin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(778, 217);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(143, 44);
            button1.TabIndex = 1;
            button1.Text = "添加";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // caipin_lst
            // 
            caipin_lst.Columns.AddRange(new ColumnHeader[] { 编号, 菜品, 价格, 制作时间 });
            caipin_lst.Location = new Point(84, 123);
            caipin_lst.Margin = new Padding(4);
            caipin_lst.Name = "caipin_lst";
            caipin_lst.Size = new Size(543, 526);
            caipin_lst.TabIndex = 0;
            caipin_lst.UseCompatibleStateImageBehavior = false;
            caipin_lst.View = View.Details;
            caipin_lst.SelectedIndexChanged += caipin_lst_SelectedIndexChanged;
            // 
            // 编号
            // 
            编号.Text = "编号";
            编号.Width = 50;
            // 
            // 菜品
            // 
            菜品.Text = "菜品";
            菜品.TextAlign = HorizontalAlignment.Center;
            菜品.Width = 100;
            // 
            // 价格
            // 
            价格.Text = "价格";
            价格.TextAlign = HorizontalAlignment.Center;
            价格.Width = 80;
            // 
            // 制作时间
            // 
            制作时间.Text = "制作时间";
            制作时间.TextAlign = HorizontalAlignment.Center;
            制作时间.Width = 100;
            // 
            // dingdan
            // 
            dingdan.Controls.Add(groupBox1);
            dingdan.Location = new Point(8, 45);
            dingdan.Name = "dingdan";
            dingdan.Padding = new Padding(3);
            dingdan.Size = new Size(1595, 936);
            dingdan.TabIndex = 1;
            dingdan.Text = "订单管理";
            dingdan.UseVisualStyleBackColor = true;
            dingdan.Click += dingdan_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dingdan_lst);
            groupBox1.Location = new Point(89, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1408, 772);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "全部订单";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1011, 163);
            label1.Name = "label1";
            label1.Size = new Size(158, 31);
            label1.TabIndex = 2;
            label1.Text = "选择订单类型";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "全部订单", "新订单", "已接餐", "待取餐", "售后单" });
            comboBox1.Location = new Point(1011, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 39);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dingdan_lst
            // 
            dingdan_lst.Columns.AddRange(new ColumnHeader[] { 订单号, 餐食号, 窗口号, 订单状态 });
            dingdan_lst.FullRowSelect = true;
            dingdan_lst.Location = new Point(32, 59);
            dingdan_lst.MultiSelect = false;
            dingdan_lst.Name = "dingdan_lst";
            dingdan_lst.Size = new Size(945, 686);
            dingdan_lst.TabIndex = 0;
            dingdan_lst.UseCompatibleStateImageBehavior = false;
            dingdan_lst.View = View.Details;
            dingdan_lst.SelectedIndexChanged += dingdan_lst_SelectedIndexChanged;
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
            // cafteria_manage
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1712, 1023);
            Controls.Add(tabControl1);
            Name = "cafteria_manage";
            Text = "cafteria_manage";
            Load += cafteria_manage_Load_1;
            tabControl1.ResumeLayout(false);
            caipin.ResumeLayout(false);
            dingdan.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TabControl tabControl1;
        private TabPage dingdan;
        private GroupBox groupBox1;
        private ListView dingdan_lst;
        private ColumnHeader 订单号;
        private ColumnHeader 餐食号;
        private ColumnHeader 窗口号;
        private ColumnHeader 订单状态;
        private ComboBox comboBox1;
        private Label label1;
        private Button button1;
        private ListView caipin_lst;
        private ColumnHeader 编号;
        private ColumnHeader 菜品;
        private ColumnHeader 价格;
        private ColumnHeader 制作时间;
        public TabPage caipin;
    }
}