namespace WinForms2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvData = new DataGridView();
            mybindingSource = new BindingSource(components);
            savebtn = new Button();
            loadbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mybindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.Location = new Point(12, 41);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(1170, 554);
            dgvData.TabIndex = 3;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(231, 12);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(75, 23);
            savebtn.TabIndex = 1;
            savebtn.Text = "save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // loadbtn
            // 
            loadbtn.Location = new Point(12, 12);
            loadbtn.Name = "loadbtn";
            loadbtn.Size = new Size(75, 23);
            loadbtn.TabIndex = 2;
            loadbtn.Text = "load";
            loadbtn.UseVisualStyleBackColor = true;
            loadbtn.Click += loadbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 607);
            Controls.Add(loadbtn);
            Controls.Add(savebtn);
            Controls.Add(dgvData);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)mybindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvData;
        private Button savebtn;
        private BindingSource mybindingSource;
        private Button loadbtn;
    }
}
