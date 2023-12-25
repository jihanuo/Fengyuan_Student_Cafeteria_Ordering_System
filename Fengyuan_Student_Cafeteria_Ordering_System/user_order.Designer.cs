namespace Fengyuan_Student_Cafeteria_Ordering_System
{
    partial class user_order
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
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            listBox1 = new ListBox();
            commit = new Button();
            label3 = new Label();
            total_price_na = new Label();
            button1 = new Button();
            delete = new Button();
            dataGridView1 = new DataGridView();
            food_name = new DataGridViewTextBoxColumn();
            intro = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("华文彩云", 19.8749981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1667, 118);
            label1.TabIndex = 0;
            label1.Text = "点餐";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.94499F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.0550079F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 309F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(listBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(commit, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 3);
            tableLayoutPanel1.Controls.Add(total_price_na, 1, 2);
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(delete, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Font = new Font("Microsoft YaHei UI", 6.375F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(0, 645);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.4358978F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.5641022F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1667, 437);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(957, 102);
            label2.TabIndex = 0;
            label2.Text = "已选择的菜品";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 36;
            listBox1.Location = new Point(3, 105);
            listBox1.Name = "listBox1";
            tableLayoutPanel1.SetRowSpan(listBox1, 3);
            listBox1.Size = new Size(957, 329);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // commit
            // 
            commit.Dock = DockStyle.Fill;
            commit.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            commit.ForeColor = Color.DarkCyan;
            commit.Location = new Point(1360, 3);
            commit.Name = "commit";
            tableLayoutPanel1.SetRowSpan(commit, 4);
            commit.Size = new Size(304, 431);
            commit.TabIndex = 2;
            commit.Text = "确认订单";
            commit.UseVisualStyleBackColor = true;
            commit.Click += commit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("黑体", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(966, 348);
            label3.Name = "label3";
            label3.Size = new Size(388, 89);
            label3.TabIndex = 2;
            label3.Text = "money";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // total_price_na
            // 
            total_price_na.AutoSize = true;
            total_price_na.Dock = DockStyle.Fill;
            total_price_na.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            total_price_na.Location = new Point(966, 215);
            total_price_na.Name = "total_price_na";
            total_price_na.Size = new Size(388, 133);
            total_price_na.TabIndex = 3;
            total_price_na.Text = "您共消费";
            total_price_na.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(966, 3);
            button1.Name = "button1";
            button1.Size = new Size(388, 96);
            button1.TabIndex = 4;
            button1.Text = "添加";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // delete
            // 
            delete.Dock = DockStyle.Fill;
            delete.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            delete.Location = new Point(966, 105);
            delete.Name = "delete";
            delete.Size = new Size(388, 107);
            delete.TabIndex = 2;
            delete.Text = "删除";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { food_name, intro, price });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.Size = new Size(1667, 527);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // food_name
            // 
            food_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            food_name.HeaderText = "餐食";
            food_name.MinimumWidth = 10;
            food_name.Name = "food_name";
            food_name.ReadOnly = true;
            food_name.Width = 107;
            // 
            // intro
            // 
            intro.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            intro.HeaderText = "介绍";
            intro.MinimumWidth = 10;
            intro.Name = "intro";
            intro.ReadOnly = true;
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            price.HeaderText = "价格";
            price.MinimumWidth = 10;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 107;
            // 
            // user_order
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1667, 1082);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "user_order";
            Text = "user_order";
            Load += user_order_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private ListBox listBox1;
        private Button delete;
        private Label total_price_na;
        private Label label3;
        private Button commit;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn food_name;
        private DataGridViewTextBoxColumn intro;
        private DataGridViewTextBoxColumn price;
        private Button button1;
    }
}