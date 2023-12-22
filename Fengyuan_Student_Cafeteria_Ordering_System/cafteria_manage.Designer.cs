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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.caipin = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.caipin_lst = new System.Windows.Forms.ListView();
            this.编号 = new System.Windows.Forms.ColumnHeader();
            this.菜品 = new System.Windows.Forms.ColumnHeader();
            this.价格 = new System.Windows.Forms.ColumnHeader();
            this.制作时间 = new System.Windows.Forms.ColumnHeader();
            this.dingdan = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dingdan_lst = new System.Windows.Forms.ListView();
            this.订单号 = new System.Windows.Forms.ColumnHeader();
            this.餐食号 = new System.Windows.Forms.ColumnHeader();
            this.窗口号 = new System.Windows.Forms.ColumnHeader();
            this.订单状态 = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.caipin.SuspendLayout();
            this.dingdan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.caipin);
            this.tabControl1.Controls.Add(this.dingdan);
            this.tabControl1.Location = new System.Drawing.Point(9, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1266, 766);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // caipin
            // 
            this.caipin.Controls.Add(this.button1);
            this.caipin.Controls.Add(this.caipin_lst);
            this.caipin.Location = new System.Drawing.Point(4, 33);
            this.caipin.Margin = new System.Windows.Forms.Padding(2);
            this.caipin.Name = "caipin";
            this.caipin.Padding = new System.Windows.Forms.Padding(2);
            this.caipin.Size = new System.Drawing.Size(1258, 729);
            this.caipin.TabIndex = 0;
            this.caipin.Text = "菜品管理";
            this.caipin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // caipin_lst
            // 
            this.caipin_lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.编号,
            this.菜品,
            this.价格,
            this.制作时间});
            this.caipin_lst.Location = new System.Drawing.Point(66, 95);
            this.caipin_lst.Name = "caipin_lst";
            this.caipin_lst.Size = new System.Drawing.Size(338, 208);
            this.caipin_lst.TabIndex = 0;
            this.caipin_lst.UseCompatibleStateImageBehavior = false;
            this.caipin_lst.View = System.Windows.Forms.View.Details;
            this.caipin_lst.SelectedIndexChanged += new System.EventHandler(this.caipin_lst_SelectedIndexChanged);
            // 
            // 编号
            // 
            this.编号.Text = "编号";
            this.编号.Width = 50;
            // 
            // 菜品
            // 
            this.菜品.Text = "菜品";
            this.菜品.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.菜品.Width = 100;
            // 
            // 价格
            // 
            this.价格.Text = "价格";
            this.价格.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.价格.Width = 80;
            // 
            // 制作时间
            // 
            this.制作时间.Text = "制作时间";
            this.制作时间.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.制作时间.Width = 100;
            // 
            // dingdan
            // 
            this.dingdan.Controls.Add(this.groupBox1);
            this.dingdan.Location = new System.Drawing.Point(4, 33);
            this.dingdan.Margin = new System.Windows.Forms.Padding(2);
            this.dingdan.Name = "dingdan";
            this.dingdan.Padding = new System.Windows.Forms.Padding(2);
            this.dingdan.Size = new System.Drawing.Size(1258, 729);
            this.dingdan.TabIndex = 1;
            this.dingdan.Text = "订单管理";
            this.dingdan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dingdan_lst);
            this.groupBox1.Location = new System.Drawing.Point(70, 72);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1106, 598);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "全部订单";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(794, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "选择订单类型";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "全部订单",
            "新订单",
            "已接餐",
            "待取餐",
            "售后单"});
            this.comboBox1.Location = new System.Drawing.Point(794, 166);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(191, 32);
            this.comboBox1.TabIndex = 1;
            // 
            // dingdan_lst
            // 
            this.dingdan_lst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.订单号,
            this.餐食号,
            this.窗口号,
            this.订单状态});
            this.dingdan_lst.FullRowSelect = true;
            this.dingdan_lst.Location = new System.Drawing.Point(25, 46);
            this.dingdan_lst.Margin = new System.Windows.Forms.Padding(2);
            this.dingdan_lst.MultiSelect = false;
            this.dingdan_lst.Name = "dingdan_lst";
            this.dingdan_lst.Size = new System.Drawing.Size(743, 532);
            this.dingdan_lst.TabIndex = 0;
            this.dingdan_lst.UseCompatibleStateImageBehavior = false;
            this.dingdan_lst.View = System.Windows.Forms.View.Details;
            this.dingdan_lst.SelectedIndexChanged += new System.EventHandler(this.dingdan_lst_SelectedIndexChanged);
            // 
            // 订单号
            // 
            this.订单号.Text = "订单号";
            this.订单号.Width = 100;
            // 
            // 餐食号
            // 
            this.餐食号.Text = "餐食号";
            this.餐食号.Width = 100;
            // 
            // 窗口号
            // 
            this.窗口号.Text = "窗口号";
            this.窗口号.Width = 100;
            // 
            // 订单状态
            // 
            this.订单状态.Text = "订单状态";
            this.订单状态.Width = 150;
            // 
            // cafteria_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 792);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cafteria_manage";
            this.Text = "cafteria_manage";
            this.tabControl1.ResumeLayout(false);
            this.caipin.ResumeLayout(false);
            this.dingdan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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