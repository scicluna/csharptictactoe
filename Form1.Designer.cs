namespace tictactoe
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(327, 175);
            button1.Name = "button1";
            button1.Size = new Size(78, 73);
            button1.TabIndex = 0;
            button1.Tag = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(399, 175);
            button2.Name = "button2";
            button2.Size = new Size(78, 73);
            button2.TabIndex = 1;
            button2.Tag = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(472, 175);
            button3.Name = "button3";
            button3.Size = new Size(78, 73);
            button3.TabIndex = 2;
            button3.Tag = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(472, 245);
            button4.Name = "button4";
            button4.Size = new Size(78, 73);
            button4.TabIndex = 5;
            button4.Tag = "5";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(399, 245);
            button5.Name = "button5";
            button5.Size = new Size(78, 73);
            button5.TabIndex = 4;
            button5.Tag = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(327, 245);
            button6.Name = "button6";
            button6.Size = new Size(78, 73);
            button6.TabIndex = 3;
            button6.Tag = "3";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(472, 312);
            button7.Name = "button7";
            button7.Size = new Size(78, 73);
            button7.TabIndex = 8;
            button7.Tag = "8";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(399, 312);
            button8.Name = "button8";
            button8.Size = new Size(78, 73);
            button8.TabIndex = 7;
            button8.Tag = "7";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(327, 312);
            button9.Name = "button9";
            button9.Size = new Size(78, 73);
            button9.TabIndex = 6;
            button9.Tag = "6";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 542);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}