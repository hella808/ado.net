namespace WinForms2
{
    partial class LoginForm
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
            logbtn = new Button();
            label2 = new Label();
            logtxt = new TextBox();
            passtxt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(492, 217);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // logbtn
            // 
            logbtn.Location = new Point(461, 408);
            logbtn.Name = "logbtn";
            logbtn.Size = new Size(104, 25);
            logbtn.TabIndex = 1;
            logbtn.Text = "Регистрация";
            logbtn.UseVisualStyleBackColor = true;
            logbtn.Click += logbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(492, 305);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // logtxt
            // 
            logtxt.Location = new Point(430, 259);
            logtxt.Name = "logtxt";
            logtxt.Size = new Size(170, 23);
            logtxt.TabIndex = 3;
            // 
            // passtxt
            // 
            passtxt.Location = new Point(430, 333);
            passtxt.Name = "passtxt";
            passtxt.Size = new Size(170, 23);
            passtxt.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 597);
            Controls.Add(passtxt);
            Controls.Add(logtxt);
            Controls.Add(label2);
            Controls.Add(logbtn);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button logbtn;
        private Label label2;
        private TextBox logtxt;
        private TextBox passtxt;
    }
}