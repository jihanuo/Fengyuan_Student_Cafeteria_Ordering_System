namespace Fengyuan_Student_Cafeteria_Ordering_System
{
    partial class menu_edit
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
            菜品 = new TextBox();
            价格 = new TextBox();
            制作时长 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            introduce = new TextBox();
            introduce_label = new Label();
            SuspendLayout();
            // 
            // 菜品
            // 
            菜品.Location = new Point(243, 205);
            菜品.Margin = new Padding(4, 4, 4, 4);
            菜品.Name = "菜品";
            菜品.Size = new Size(190, 38);
            菜品.TabIndex = 0;
            菜品.TextChanged += 菜品_TextChanged;
            // 
            // 价格
            // 
            价格.Location = new Point(627, 198);
            价格.Margin = new Padding(4, 4, 4, 4);
            价格.Name = "价格";
            价格.Size = new Size(225, 38);
            价格.TabIndex = 1;
            // 
            // 制作时长
            // 
            制作时长.Location = new Point(243, 297);
            制作时长.Margin = new Padding(4, 4, 4, 4);
            制作时长.Name = "制作时长";
            制作时长.Size = new Size(190, 38);
            制作时长.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 205);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 31);
            label1.TabIndex = 3;
            label1.Text = "菜品";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 205);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 31);
            label2.TabIndex = 4;
            label2.Text = "价格";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 304);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 5;
            label3.Text = "制作时长";
            // 
            // button1
            // 
            button1.Location = new Point(660, 480);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(142, 44);
            button1.TabIndex = 6;
            button1.Text = "添加";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(391, 482);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(142, 44);
            button2.TabIndex = 7;
            button2.Text = "删除";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 111);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 31);
            label4.TabIndex = 8;
            label4.Text = "编号";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 111);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 31);
            label5.TabIndex = 9;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(136, 484);
            button3.Margin = new Padding(6, 5, 6, 5);
            button3.Name = "button3";
            button3.Size = new Size(150, 42);
            button3.TabIndex = 10;
            button3.Text = "编辑";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // introduce
            // 
            introduce.Location = new Point(627, 297);
            introduce.Name = "introduce";
            introduce.Size = new Size(225, 38);
            introduce.TabIndex = 11;
            introduce.TextChanged += introduce_TextChanged;
            // 
            // introduce_label
            // 
            introduce_label.AutoSize = true;
            introduce_label.Location = new Point(519, 304);
            introduce_label.Name = "introduce_label";
            introduce_label.Size = new Size(62, 31);
            introduce_label.TabIndex = 12;
            introduce_label.Text = "介绍";
            // 
            // menu_edit
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 654);
            Controls.Add(introduce_label);
            Controls.Add(introduce);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(制作时长);
            Controls.Add(价格);
            Controls.Add(菜品);
            Margin = new Padding(4, 4, 4, 4);
            Name = "menu_edit";
            Text = "menu_edit";
            Load += menu_edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox 菜品;
        private TextBox 价格;
        private TextBox 制作时长;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label5;
        private Button button3;
        private TextBox introduce;
        private Label introduce_label;
    }
}