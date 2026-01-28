namespace WinForms2
{
    partial class frmupdpass
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
            newpasstext = new TextBox();
            newpassconftxt = new TextBox();
            updpassbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 154);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 198);
            label2.Name = "label2";
            label2.Size = new Size(137, 15);
            label2.TabIndex = 1;
            label2.Text = "Подтверждение пароля";
            // 
            // newpasstext
            // 
            newpasstext.Location = new Point(344, 151);
            newpasstext.Name = "newpasstext";
            newpasstext.Size = new Size(169, 23);
            newpasstext.TabIndex = 2;
            // 
            // newpassconftxt
            // 
            newpassconftxt.Location = new Point(344, 195);
            newpassconftxt.Name = "newpassconftxt";
            newpassconftxt.Size = new Size(169, 23);
            newpassconftxt.TabIndex = 3;
            // 
            // updpassbtn
            // 
            updpassbtn.Location = new Point(370, 258);
            updpassbtn.Name = "updpassbtn";
            updpassbtn.Size = new Size(119, 26);
            updpassbtn.TabIndex = 4;
            updpassbtn.Text = "Обновить пароль";
            updpassbtn.UseVisualStyleBackColor = true;
            // 
            // frmupdpass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updpassbtn);
            Controls.Add(newpassconftxt);
            Controls.Add(newpasstext);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmupdpass";
            Text = "frmupdpass";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox newpasstext;
        private TextBox newpassconftxt;
        private Button updpassbtn;
    }
}