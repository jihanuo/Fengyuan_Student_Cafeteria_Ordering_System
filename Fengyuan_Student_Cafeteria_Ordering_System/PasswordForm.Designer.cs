namespace Studentssystem
{
    partial class PasswordForm
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
            txtoldPassword = new TextBox();
            txtNo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNewPassword = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtoldPassword
            // 
            txtoldPassword.Location = new Point(166, 129);
            txtoldPassword.Margin = new Padding(7, 8, 7, 8);
            txtoldPassword.Name = "txtoldPassword";
            txtoldPassword.PasswordChar = '*';
            txtoldPassword.Size = new Size(510, 38);
            txtoldPassword.TabIndex = 14;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(166, 31);
            txtNo.Margin = new Padding(7, 8, 7, 8);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(510, 38);
            txtNo.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 137);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 12;
            label2.Text = "原密码：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 39);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 31);
            label1.TabIndex = 11;
            label1.Text = "账号:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(166, 214);
            txtNewPassword.Margin = new Padding(7, 8, 7, 8);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(510, 38);
            txtNewPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 222);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 15;
            label3.Text = "新密码：";
            // 
            // button1
            // 
            button1.Location = new Point(135, 333);
            button1.Margin = new Padding(7, 8, 7, 8);
            button1.Name = "button1";
            button1.Size = new Size(175, 59);
            button1.TabIndex = 17;
            button1.Text = "修改";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(476, 333);
            button2.Margin = new Padding(7, 8, 7, 8);
            button2.Name = "button2";
            button2.Size = new Size(175, 59);
            button2.TabIndex = 18;
            button2.Text = "取消";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 444);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNewPassword);
            Controls.Add(label3);
            Controls.Add(txtoldPassword);
            Controls.Add(txtNo);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(7, 8, 7, 8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "修改密码";
            Load += PasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtoldPassword;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}