namespace WinFormsApp1
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
            firstNameTxt = new TextBox();
            lastNameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            confirmTag = new CheckBox();
            submitBtn = new Button();
            finalResult = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(124, 45);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(147, 23);
            firstNameTxt.TabIndex = 0;
            firstNameTxt.TextChanged += textBox1_TextChanged;
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(124, 73);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(147, 23);
            lastNameTxt.TabIndex = 1;
            lastNameTxt.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(45, 48);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "First Name :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 76);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Last Name :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 152);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 5;
            label3.Text = "Your Subject :";
            // 
            // confirmTag
            // 
            confirmTag.AutoSize = true;
            confirmTag.Location = new Point(131, 345);
            confirmTag.Name = "confirmTag";
            confirmTag.Size = new Size(70, 19);
            confirmTag.TabIndex = 6;
            confirmTag.Text = "Confirm";
            confirmTag.UseVisualStyleBackColor = true;
            confirmTag.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // submitBtn
            // 
            submitBtn.BackColor = SystemColors.MenuHighlight;
            submitBtn.ForeColor = SystemColors.ButtonHighlight;
            submitBtn.Location = new Point(163, 383);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(75, 23);
            submitBtn.TabIndex = 7;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += button1_Click_1;
            // 
            // finalResult
            // 
            finalResult.AutoSize = true;
            finalResult.Location = new Point(471, 234);
            finalResult.Name = "finalResult";
            finalResult.Size = new Size(81, 15);
            finalResult.TabIndex = 8;
            finalResult.Text = "Student Data :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 149);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(finalResult);
            Controls.Add(submitBtn);
            Controls.Add(confirmTag);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lastNameTxt);
            Controls.Add(firstNameTxt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTxt;
        private TextBox lastNameTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox confirmTag;
        private Button submitBtn;
        private Label finalResult;
        private TextBox textBox1;
    }
}