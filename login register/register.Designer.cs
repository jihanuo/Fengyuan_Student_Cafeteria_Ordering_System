namespace login
{
    partial class register
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
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 36);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 0;
            label1.Text = "账号：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 90);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 1;
            label2.Text = "密码：";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            //Lostfocus当一个控件失去焦点时触发,定义控件失去焦点时的方法
            this.textBox1.LostFocus += new System.EventHandler(this.textBox1_LostFocus);
            //GotFocus是在一个对象得到焦点时发生，定义控件得到焦点时的方法
            this.textBox1.GotFocus += new System.EventHandler(this.textBox1_GotFocus);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 197);
            label3.Name = "label3";
            label3.Size = new Size(56, 17);
            label3.TabIndex = 4;
            label3.Text = "手机号：";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(214, 23);
            textBox3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 144);
            label4.Name = "label4";
            label4.Size = new Size(68, 17);
            label4.TabIndex = 5;
            label4.Text = "确认密码：";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(114, 191);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(214, 23);
            textBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(195, 226);
            button1.Name = "button1";
            button1.Size = new Size(133, 33);
            button1.TabIndex = 6;
            button1.Text = "点击注册";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 90);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 7;
            label5.Text = "姓名：";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(404, 90);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(93, 23);
            textBox5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(354, 144);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 9;
            label6.Text = "身份：";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "学生", "教职工", "外来人员" });
            comboBox1.Location = new Point(404, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(93, 25);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 271);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "register";
            Text = "注册";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Button button1;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private ComboBox comboBox1;
    }
}