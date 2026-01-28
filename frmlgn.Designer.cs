namespace WinForms2
{
    partial class frmlgn
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
            passtxt = new TextBox();
            lgntxt = new TextBox();
            signbtn = new Button();
            regbtn = new Button();
            forgetpassbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 178);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 223);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // passtxt
            // 
            passtxt.Location = new Point(333, 220);
            passtxt.Name = "passtxt";
            passtxt.Size = new Size(168, 23);
            passtxt.TabIndex = 2;
            // 
            // lgntxt
            // 
            lgntxt.Location = new Point(333, 175);
            lgntxt.Name = "lgntxt";
            lgntxt.Size = new Size(168, 23);
            lgntxt.TabIndex = 3;
            // 
            // signbtn
            // 
            signbtn.Location = new Point(353, 286);
            signbtn.Name = "signbtn";
            signbtn.Size = new Size(128, 32);
            signbtn.TabIndex = 4;
            signbtn.Text = "Войти";
            signbtn.UseVisualStyleBackColor = true;
            signbtn.Click += signbtn_Click;
            // 
            // regbtn
            // 
            regbtn.Location = new Point(353, 337);
            regbtn.Name = "regbtn";
            regbtn.Size = new Size(128, 31);
            regbtn.TabIndex = 5;
            regbtn.Text = "Зарегистрироваться ";
            regbtn.UseVisualStyleBackColor = true;
            regbtn.Click += regbtn_Click;
            // 
            // forgetpassbtn
            // 
            forgetpassbtn.Location = new Point(366, 385);
            forgetpassbtn.Name = "forgetpassbtn";
            forgetpassbtn.Size = new Size(103, 26);
            forgetpassbtn.TabIndex = 6;
            forgetpassbtn.Text = "забыли пароль";
            forgetpassbtn.UseVisualStyleBackColor = true;
            forgetpassbtn.Click += forgetpassbtn_Click;
            // 
            // frmlgn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(forgetpassbtn);
            Controls.Add(regbtn);
            Controls.Add(signbtn);
            Controls.Add(lgntxt);
            Controls.Add(passtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmlgn";
            Text = "frmlgn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox passtxt;
        private TextBox lgntxt;
        private Button signbtn;
        private Button regbtn;
        private Button forgetpassbtn;
    }
}