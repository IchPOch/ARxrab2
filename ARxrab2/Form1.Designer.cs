
namespace ARxrab2
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.folderCh = new System.Windows.Forms.CheckBox();
            this.Properties = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Ren = new System.Windows.Forms.Button();
            this.RenameTxt = new System.Windows.Forms.TextBox();
            this.Threads = new System.Windows.Forms.Button();
            this.ThreadCombo = new System.Windows.Forms.ComboBox();
            this.arg1 = new System.Windows.Forms.TextBox();
            this.arg2 = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Calc = new System.Windows.Forms.Button();
            this.dllCheck = new System.Windows.Forms.CheckBox();
            this.Close = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Papka";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Copy";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 23);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(310, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 23);
            this.textBox2.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(362, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Move";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "form2";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(414, 209);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(48, 23);
            this.del.TabIndex = 9;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // folderCh
            // 
            this.folderCh.AutoSize = true;
            this.folderCh.Location = new System.Drawing.Point(289, 184);
            this.folderCh.Name = "folderCh";
            this.folderCh.Size = new System.Drawing.Size(15, 14);
            this.folderCh.TabIndex = 10;
            this.folderCh.UseVisualStyleBackColor = true;
            this.folderCh.CheckedChanged += new System.EventHandler(this.folderCh_CheckedChanged);
            // 
            // Properties
            // 
            this.Properties.Location = new System.Drawing.Point(468, 209);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(40, 23);
            this.Properties.TabIndex = 11;
            this.Properties.Text = "Prop";
            this.Properties.UseVisualStyleBackColor = true;
            this.Properties.Click += new System.EventHandler(this.Properties_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // Ren
            // 
            this.Ren.Location = new System.Drawing.Point(243, 237);
            this.Ren.Name = "Ren";
            this.Ren.Size = new System.Drawing.Size(61, 23);
            this.Ren.TabIndex = 15;
            this.Ren.Text = "Rename";
            this.Ren.UseVisualStyleBackColor = true;
            this.Ren.Click += new System.EventHandler(this.Ren_Click);
            // 
            // RenameTxt
            // 
            this.RenameTxt.Location = new System.Drawing.Point(310, 238);
            this.RenameTxt.Name = "RenameTxt";
            this.RenameTxt.Size = new System.Drawing.Size(100, 23);
            this.RenameTxt.TabIndex = 16;
            // 
            // Threads
            // 
            this.Threads.Location = new System.Drawing.Point(310, 285);
            this.Threads.Name = "Threads";
            this.Threads.Size = new System.Drawing.Size(75, 23);
            this.Threads.TabIndex = 17;
            this.Threads.Text = "Потоки";
            this.Threads.UseVisualStyleBackColor = true;
            this.Threads.Click += new System.EventHandler(this.Threads_Click);
            // 
            // ThreadCombo
            // 
            this.ThreadCombo.FormattingEnabled = true;
            this.ThreadCombo.Items.AddRange(new object[] {
            "Highest",
            "Above normal",
            "Normal",
            "Below normal",
            "Lowest"});
            this.ThreadCombo.Location = new System.Drawing.Point(287, 314);
            this.ThreadCombo.Name = "ThreadCombo";
            this.ThreadCombo.Size = new System.Drawing.Size(121, 23);
            this.ThreadCombo.TabIndex = 18;
            // 
            // arg1
            // 
            this.arg1.Location = new System.Drawing.Point(434, 12);
            this.arg1.Name = "arg1";
            this.arg1.Size = new System.Drawing.Size(100, 23);
            this.arg1.TabIndex = 19;
            // 
            // arg2
            // 
            this.arg2.Location = new System.Drawing.Point(561, 12);
            this.arg2.Name = "arg2";
            this.arg2.Size = new System.Drawing.Size(100, 23);
            this.arg2.TabIndex = 20;
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(688, 12);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(100, 23);
            this.answer.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(540, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "=";
            // 
            // Calc
            // 
            this.Calc.Location = new System.Drawing.Point(511, 41);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(75, 23);
            this.Calc.TabIndex = 24;
            this.Calc.Text = "Reshenie";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // dllCheck
            // 
            this.dllCheck.AutoSize = true;
            this.dllCheck.Location = new System.Drawing.Point(599, 45);
            this.dllCheck.Name = "dllCheck";
            this.dllCheck.Size = new System.Drawing.Size(165, 19);
            this.dllCheck.TabIndex = 25;
            this.dllCheck.Text = "Подключена библиотека";
            this.dllCheck.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.Location = new System.Drawing.Point(12, 419);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(117, 19);
            this.Close.TabIndex = 26;
            this.Close.Text = "Ты не закроешь ";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.dllCheck);
            this.Controls.Add(this.Calc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.arg2);
            this.Controls.Add(this.arg1);
            this.Controls.Add(this.ThreadCombo);
            this.Controls.Add(this.Threads);
            this.Controls.Add(this.RenameTxt);
            this.Controls.Add(this.Ren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Properties);
            this.Controls.Add(this.folderCh);
            this.Controls.Add(this.del);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Z";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.CheckBox folderCh;
        private System.Windows.Forms.Button Properties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ren;
        private System.Windows.Forms.TextBox RenameTxt;
        private System.Windows.Forms.Button Threads;
        private System.Windows.Forms.ComboBox ThreadCombo;
        private System.Windows.Forms.TextBox arg1;
        private System.Windows.Forms.TextBox arg2;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.CheckBox dllCheck;
        private System.Windows.Forms.CheckBox Close;
    }
}

