namespace Fengyuan_Student_Cafeteria_Ordering_System
{
    partial class user
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
            tableLayoutPanel1 = new TableLayoutPanel();
            zhongxikuaican = new Button();
            zhajihanbao = new Button();
            malaxiangguo = new Button();
            mianfenzhuanjia = new Button();
            nanfangweidao = new Button();
            yuansuzhushi = new Button();
            zzrishang = new Button();
            f_niuroufan = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            win_select = new Label();
            qucan_list = new ListView();
            name = new ColumnHeader();
            state = new ColumnHeader();
            for_time = new ColumnHeader();
            qucan_code = new ColumnHeader();
            window = new ColumnHeader();
            qucan = new Button();
            dingdan_view = new Label();
            user_center = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.2439041F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7560959F));
            tableLayoutPanel1.Controls.Add(zhongxikuaican, 1, 3);
            tableLayoutPanel1.Controls.Add(zhajihanbao, 0, 3);
            tableLayoutPanel1.Controls.Add(malaxiangguo, 1, 2);
            tableLayoutPanel1.Controls.Add(mianfenzhuanjia, 0, 2);
            tableLayoutPanel1.Controls.Add(nanfangweidao, 1, 1);
            tableLayoutPanel1.Controls.Add(yuansuzhushi, 0, 1);
            tableLayoutPanel1.Controls.Add(zzrishang, 1, 0);
            tableLayoutPanel1.Controls.Add(f_niuroufan, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 84);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel2.SetRowSpan(tableLayoutPanel1, 2);
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.8372078F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.1627922F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 238F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 213F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(742, 1023);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // zhongxikuaican
            // 
            zhongxikuaican.Dock = DockStyle.Fill;
            zhongxikuaican.Font = new Font("微软雅黑", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            zhongxikuaican.Location = new Point(375, 772);
            zhongxikuaican.Name = "zhongxikuaican";
            tableLayoutPanel1.SetRowSpan(zhongxikuaican, 3);
            zhongxikuaican.Size = new Size(364, 248);
            zhongxikuaican.TabIndex = 7;
            zhongxikuaican.Text = "中西快餐";
            zhongxikuaican.UseVisualStyleBackColor = true;
            zhongxikuaican.Click += zhongxikuaican_Click;
            // 
            // zhajihanbao
            // 
            zhajihanbao.Dock = DockStyle.Fill;
            zhajihanbao.Font = new Font("微软雅黑", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            zhajihanbao.Location = new Point(3, 772);
            zhajihanbao.Name = "zhajihanbao";
            tableLayoutPanel1.SetRowSpan(zhajihanbao, 3);
            zhajihanbao.Size = new Size(366, 248);
            zhajihanbao.TabIndex = 6;
            zhajihanbao.Text = "炸鸡汉堡";
            zhajihanbao.UseVisualStyleBackColor = true;
            zhajihanbao.Click += zhajihanbao_Click;
            // 
            // malaxiangguo
            // 
            malaxiangguo.Dock = DockStyle.Fill;
            malaxiangguo.Font = new Font("微软雅黑", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            malaxiangguo.Location = new Point(375, 534);
            malaxiangguo.Name = "malaxiangguo";
            malaxiangguo.Size = new Size(364, 232);
            malaxiangguo.TabIndex = 5;
            malaxiangguo.Text = "麻辣香锅";
            malaxiangguo.UseVisualStyleBackColor = true;
            malaxiangguo.Click += malaxiangguo_Click;
            // 
            // mianfenzhuanjia
            // 
            mianfenzhuanjia.Dock = DockStyle.Fill;
            mianfenzhuanjia.Font = new Font("微软雅黑", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            mianfenzhuanjia.Location = new Point(3, 534);
            mianfenzhuanjia.Name = "mianfenzhuanjia";
            mianfenzhuanjia.Size = new Size(366, 232);
            mianfenzhuanjia.TabIndex = 4;
            mianfenzhuanjia.Text = " 面粉专家";
            mianfenzhuanjia.UseVisualStyleBackColor = true;
            mianfenzhuanjia.Click += mianfenzhuanjia_Click;
            // 
            // nanfangweidao
            // 
            nanfangweidao.Dock = DockStyle.Fill;
            nanfangweidao.Font = new Font("微软雅黑", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            nanfangweidao.Location = new Point(375, 262);
            nanfangweidao.Name = "nanfangweidao";
            nanfangweidao.Size = new Size(364, 266);
            nanfangweidao.TabIndex = 3;
            nanfangweidao.Text = "南方味道";
            nanfangweidao.UseVisualStyleBackColor = true;
            nanfangweidao.Click += nanfangweidao_Click;
            // 
            // yuansuzhushi
            // 
            yuansuzhushi.Dock = DockStyle.Fill;
            yuansuzhushi.Font = new Font("微软雅黑", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            yuansuzhushi.Location = new Point(3, 262);
            yuansuzhushi.Name = "yuansuzhushi";
            yuansuzhushi.Size = new Size(366, 266);
            yuansuzhushi.TabIndex = 2;
            yuansuzhushi.Text = "元素主食";
            yuansuzhushi.UseVisualStyleBackColor = true;
            yuansuzhushi.Click += yuansuzhushi_Click;
            // 
            // zzrishang
            // 
            zzrishang.Dock = DockStyle.Fill;
            zzrishang.Font = new Font("微软雅黑", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            zzrishang.Location = new Point(375, 3);
            zzrishang.Name = "zzrishang";
            zzrishang.Size = new Size(364, 253);
            zzrishang.TabIndex = 1;
            zzrishang.Text = "蒸蒸日上";
            zzrishang.UseVisualStyleBackColor = true;
            zzrishang.Click += zzrishang_Click;
            // 
            // f_niuroufan
            // 
            f_niuroufan.Dock = DockStyle.Fill;
            f_niuroufan.Font = new Font("微软雅黑", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            f_niuroufan.Location = new Point(3, 3);
            f_niuroufan.Name = "f_niuroufan";
            f_niuroufan.Size = new Size(366, 253);
            f_niuroufan.TabIndex = 0;
            f_niuroufan.Text = "F牛肉饭";
            f_niuroufan.UseVisualStyleBackColor = true;
            f_niuroufan.Click += f_niuroufan_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 177F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(win_select, 0, 0);
            tableLayoutPanel2.Controls.Add(qucan_list, 1, 1);
            tableLayoutPanel2.Controls.Add(qucan, 2, 2);
            tableLayoutPanel2.Controls.Add(dingdan_view, 1, 0);
            tableLayoutPanel2.Controls.Add(user_center, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.7891073F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 86.21089F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 517F));
            tableLayoutPanel2.Size = new Size(1674, 1110);
            tableLayoutPanel2.TabIndex = 1;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // win_select
            // 
            win_select.AutoSize = true;
            win_select.Dock = DockStyle.Fill;
            win_select.Font = new Font("华文琥珀", 25.8749962F, FontStyle.Regular, GraphicsUnit.Point);
            win_select.Location = new Point(3, 0);
            win_select.Name = "win_select";
            win_select.Size = new Size(742, 81);
            win_select.TabIndex = 1;
            win_select.Text = "点菜";
            win_select.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // qucan_list
            // 
            qucan_list.Columns.AddRange(new ColumnHeader[] { name, state, for_time, qucan_code, window });
            qucan_list.Dock = DockStyle.Fill;
            qucan_list.Location = new Point(751, 84);
            qucan_list.Name = "qucan_list";
            tableLayoutPanel2.SetRowSpan(qucan_list, 2);
            qucan_list.Size = new Size(742, 1023);
            qucan_list.TabIndex = 3;
            qucan_list.UseCompatibleStateImageBehavior = false;
            qucan_list.View = View.Details;
            qucan_list.SelectedIndexChanged += qucan_list_SelectedIndexChanged;
            // 
            // name
            // 
            name.Text = "菜名";
            name.Width = 100;
            // 
            // state
            // 
            state.Text = "状态";
            state.Width = 100;
            // 
            // for_time
            // 
            for_time.Text = "预计取餐时间";
            for_time.Width = 200;
            // 
            // qucan_code
            // 
            qucan_code.Text = "取餐码";
            qucan_code.Width = 100;
            // 
            // window
            // 
            window.Text = "窗口";
            window.Width = 120;
            // 
            // qucan
            // 
            qucan.Dock = DockStyle.Fill;
            qucan.Font = new Font("Microsoft YaHei UI", 25.875F, FontStyle.Bold, GraphicsUnit.Point);
            qucan.Location = new Point(1499, 595);
            qucan.Name = "qucan";
            qucan.Size = new Size(172, 512);
            qucan.TabIndex = 5;
            qucan.Text = "确认取餐";
            qucan.UseVisualStyleBackColor = true;
            qucan.Click += qucan_Click;
            // 
            // dingdan_view
            // 
            dingdan_view.AutoSize = true;
            dingdan_view.Dock = DockStyle.Fill;
            dingdan_view.Font = new Font("华文琥珀", 25.8749962F, FontStyle.Regular, GraphicsUnit.Point);
            dingdan_view.Location = new Point(751, 0);
            dingdan_view.Name = "dingdan_view";
            dingdan_view.Size = new Size(742, 81);
            dingdan_view.TabIndex = 2;
            dingdan_view.Text = "我的订单";
            dingdan_view.TextAlign = ContentAlignment.MiddleCenter;
            dingdan_view.Click += dingdan_view_Click;
            // 
            // user_center
            // 
            user_center.AutoSize = true;
            user_center.Dock = DockStyle.Fill;
            user_center.Font = new Font("Microsoft YaHei UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point);
            user_center.ForeColor = Color.FromArgb(64, 64, 64);
            user_center.Location = new Point(1499, 0);
            user_center.Name = "user_center";
            user_center.Size = new Size(172, 81);
            user_center.TabIndex = 7;
            user_center.Text = "个人中心（修改密码）";
            user_center.TextAlign = ContentAlignment.MiddleCenter;
            user_center.Click += user_center_Click;
            // 
            // user
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1674, 1110);
            Controls.Add(tableLayoutPanel2);
            Name = "user";
            Text = "用户端";
            Load += user_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button malaxiangguo;
        private Button mianfenzhuanjia;
        private Button nanfangweidao;
        private Button yuansuzhushi;
        private Button zzrishang;
        private Button f_niuroufan;
        private TableLayoutPanel tableLayoutPanel2;
        private Label dingdan_view;
        private Label win_select;
        private ListView qucan_list;
        private ColumnHeader name;
        private ColumnHeader state;
        private ColumnHeader for_time;
        private ColumnHeader qucan_code;
        private Button zhongxikuaican;
        private Button zhajihanbao;
        private ColumnHeader window;
        private Button qucan;
        private Label user_center;
    }
}