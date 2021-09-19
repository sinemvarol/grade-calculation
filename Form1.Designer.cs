
namespace GradeCalculation
{
    partial class Form1
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
            this.textname = new System.Windows.Forms.TextBox();
            this.textsurname = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listname = new System.Windows.Forms.ListBox();
            this.listsurname = new System.Windows.Forms.ListBox();
            this.list1 = new System.Windows.Forms.ListBox();
            this.list2 = new System.Windows.Forms.ListBox();
            this.listavg = new System.Windows.Forms.ListBox();
            this.listresult = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(112, 30);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(100, 22);
            this.textname.TabIndex = 0;
            // 
            // textsurname
            // 
            this.textsurname.Location = new System.Drawing.Point(112, 73);
            this.textsurname.Name = "textsurname";
            this.textsurname.Size = new System.Drawing.Size(100, 22);
            this.textsurname.TabIndex = 1;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(112, 119);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 22);
            this.text1.TabIndex = 2;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(112, 165);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 22);
            this.text2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "1.Grade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "2. Grade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 65);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 65);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listname
            // 
            this.listname.FormattingEnabled = true;
            this.listname.ItemHeight = 16;
            this.listname.Location = new System.Drawing.Point(12, 257);
            this.listname.Name = "listname";
            this.listname.Size = new System.Drawing.Size(120, 84);
            this.listname.TabIndex = 10;
            // 
            // listsurname
            // 
            this.listsurname.FormattingEnabled = true;
            this.listsurname.ItemHeight = 16;
            this.listsurname.Location = new System.Drawing.Point(154, 257);
            this.listsurname.Name = "listsurname";
            this.listsurname.Size = new System.Drawing.Size(120, 84);
            this.listsurname.TabIndex = 11;
            this.listsurname.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.ItemHeight = 16;
            this.list1.Location = new System.Drawing.Point(299, 257);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(120, 84);
            this.list1.TabIndex = 12;
            // 
            // list2
            // 
            this.list2.FormattingEnabled = true;
            this.list2.ItemHeight = 16;
            this.list2.Location = new System.Drawing.Point(442, 257);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(120, 84);
            this.list2.TabIndex = 13;
            // 
            // listavg
            // 
            this.listavg.FormattingEnabled = true;
            this.listavg.ItemHeight = 16;
            this.listavg.Location = new System.Drawing.Point(584, 257);
            this.listavg.Name = "listavg";
            this.listavg.Size = new System.Drawing.Size(120, 84);
            this.listavg.TabIndex = 14;
            // 
            // listresult
            // 
            this.listresult.FormattingEnabled = true;
            this.listresult.ItemHeight = 16;
            this.listresult.Location = new System.Drawing.Point(743, 257);
            this.listresult.Name = "listresult";
            this.listresult.Size = new System.Drawing.Size(120, 84);
            this.listresult.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Surrname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Grade1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Grade2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(621, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Average";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(765, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listresult);
            this.Controls.Add(this.listavg);
            this.Controls.Add(this.list2);
            this.Controls.Add(this.list1);
            this.Controls.Add(this.listsurname);
            this.Controls.Add(this.listname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.textsurname);
            this.Controls.Add(this.textname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textsurname;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listname;
        private System.Windows.Forms.ListBox listsurname;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.ListBox list2;
        private System.Windows.Forms.ListBox listavg;
        private System.Windows.Forms.ListBox listresult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

