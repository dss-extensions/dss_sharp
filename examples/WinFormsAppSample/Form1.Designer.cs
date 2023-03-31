namespace WinFormsAppSample
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            formsPlot1 = new ScottPlot.FormsPlot();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(26, 12);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Version";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(144, 12);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Run";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 52);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(762, 123);
            textBox1.TabIndex = 2;
            textBox1.Text = "compile \"C:\\Program Files\\OpenDSS\\IEEETestCases\\13Bus\\IEEE13Nodeckt.dss\"\r\nshow voltages ln\r\n";
            // 
            // button3
            // 
            button3.Location = new Point(262, 12);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 3;
            button3.Text = "Compare";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.Location = new Point(15, 183);
            formsPlot1.Margin = new Padding(6, 5, 6, 5);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(770, 527);
            formsPlot1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 711);
            Controls.Add(formsPlot1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private ScottPlot.FormsPlot formsPlot1;
    }
}