namespace ConnectionTables
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
        private void InitializeComponent()
        {
            lbl1 = new Label();
            lbl2 = new Label();
            txt2 = new TextBox();
            btn1 = new Button();
            txt1 = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(159, 57);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(39, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Name";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(462, 57);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(59, 15);
            lbl2.TabIndex = 1;
            lbl2.Text = "Name_BG";
            // 
            // txt2
            // 
            txt2.Location = new Point(462, 75);
            txt2.Name = "txt2";
            txt2.Size = new Size(107, 23);
            txt2.TabIndex = 3;
            // 
            // btn1
            // 
            btn1.Location = new Point(241, 241);
            btn1.Name = "btn1";
            btn1.Size = new Size(245, 61);
            btn1.TabIndex = 5;
            btn1.Text = "btn1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // txt1
            // 
            txt1.Location = new Point(159, 75);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt1);
            Controls.Add(btn1);
            Controls.Add(txt2);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private Label lbl2;
        private TextBox textBox1;
        private TextBox txt2;
        private Button btn1;
        private TextBox txt1;
        private CheckBox checkBox1;
    }
}
