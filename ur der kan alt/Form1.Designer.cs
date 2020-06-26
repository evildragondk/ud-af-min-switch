namespace ur_der_kan_alt
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
            this.components = new System.ComponentModel.Container();
            this.kl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.nåstil = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.min = new System.Windows.Forms.Label();
            this.sec = new System.Windows.Forms.Label();
            this.cs = new System.Windows.Forms.Label();
            this.Nedtælletime = new System.Windows.Forms.TextBox();
            this.Nedtællesec = new System.Windows.Forms.TextBox();
            this.Nedtællemin = new System.Windows.Forms.TextBox();
            this.Nedtællecs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Nedtælle = new System.Windows.Forms.Button();
            this.Alame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kl
            // 
            this.kl.AutoSize = true;
            this.kl.BackColor = System.Drawing.Color.Transparent;
            this.kl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.kl.Location = new System.Drawing.Point(32, 50);
            this.kl.Name = "kl";
            this.kl.Size = new System.Drawing.Size(220, 55);
            this.kl.TabIndex = 0;
            this.kl.Text = "00:00:00";
            this.kl.Click += new System.EventHandler(this.kl_Click);
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.BackColor = System.Drawing.Color.Transparent;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.timer.Location = new System.Drawing.Point(474, 50);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(94, 55);
            this.timer.TabIndex = 1;
            this.timer.Text = "00:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(481, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "stop ur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(35, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "kl";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(32, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "2020";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(32, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 68);
            this.label2.TabIndex = 6;
            this.label2.Text = "001110101";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // start
            // 
            this.start.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.start.BackColor = System.Drawing.Color.Black;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.start.Location = new System.Drawing.Point(453, 108);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(115, 64);
            this.start.TabIndex = 7;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.stop.BackColor = System.Drawing.Color.Black;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.stop.Location = new System.Drawing.Point(575, 108);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(115, 64);
            this.stop.TabIndex = 8;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // nåstil
            // 
            this.nåstil.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.nåstil.BackColor = System.Drawing.Color.Black;
            this.nåstil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nåstil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nåstil.Location = new System.Drawing.Point(696, 108);
            this.nåstil.Name = "nåstil";
            this.nåstil.Size = new System.Drawing.Size(115, 64);
            this.nåstil.TabIndex = 10;
            this.nåstil.Text = "nåstil";
            this.nåstil.UseVisualStyleBackColor = false;
            this.nåstil.Click += new System.EventHandler(this.nåstil_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.min.Location = new System.Drawing.Point(584, 52);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(94, 55);
            this.min.TabIndex = 11;
            this.min.Text = "00:";
            // 
            // sec
            // 
            this.sec.AutoSize = true;
            this.sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sec.Location = new System.Drawing.Point(696, 52);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(94, 55);
            this.sec.TabIndex = 12;
            this.sec.Text = "00:";
            // 
            // cs
            // 
            this.cs.AutoSize = true;
            this.cs.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cs.Location = new System.Drawing.Point(812, 52);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(80, 55);
            this.cs.TabIndex = 13;
            this.cs.Text = "00";
            // 
            // Nedtælletime
            // 
            this.Nedtælletime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nedtælletime.Location = new System.Drawing.Point(484, 189);
            this.Nedtælletime.Multiline = true;
            this.Nedtælletime.Name = "Nedtælletime";
            this.Nedtælletime.Size = new System.Drawing.Size(51, 43);
            this.Nedtælletime.TabIndex = 14;
            this.Nedtælletime.Text = "0";
            // 
            // Nedtællesec
            // 
            this.Nedtællesec.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nedtællesec.Location = new System.Drawing.Point(726, 189);
            this.Nedtællesec.Multiline = true;
            this.Nedtællesec.Name = "Nedtællesec";
            this.Nedtællesec.Size = new System.Drawing.Size(51, 43);
            this.Nedtællesec.TabIndex = 15;
            this.Nedtællesec.Text = "0";
            // 
            // Nedtællemin
            // 
            this.Nedtællemin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nedtællemin.Location = new System.Drawing.Point(605, 189);
            this.Nedtællemin.Multiline = true;
            this.Nedtællemin.Name = "Nedtællemin";
            this.Nedtællemin.Size = new System.Drawing.Size(51, 43);
            this.Nedtællemin.TabIndex = 16;
            this.Nedtællemin.Text = "0";
            this.Nedtællemin.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Nedtællecs
            // 
            this.Nedtællecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nedtællecs.Location = new System.Drawing.Point(833, 189);
            this.Nedtællecs.Multiline = true;
            this.Nedtællecs.Name = "Nedtællecs";
            this.Nedtællecs.Size = new System.Drawing.Size(51, 43);
            this.Nedtællecs.TabIndex = 17;
            this.Nedtællecs.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(399, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "timer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(544, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 31);
            this.label6.TabIndex = 19;
            this.label6.Text = "min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(662, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 31);
            this.label7.TabIndex = 20;
            this.label7.Text = "sec";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(783, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 31);
            this.label8.TabIndex = 21;
            this.label8.Text = "cs";
            // 
            // Nedtælle
            // 
            this.Nedtælle.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Nedtælle.BackColor = System.Drawing.Color.Black;
            this.Nedtælle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nedtælle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Nedtælle.Location = new System.Drawing.Point(817, 108);
            this.Nedtælle.Name = "Nedtælle";
            this.Nedtælle.Size = new System.Drawing.Size(115, 64);
            this.Nedtælle.TabIndex = 22;
            this.Nedtælle.Text = "Nedtælle";
            this.Nedtælle.UseVisualStyleBackColor = false;
            this.Nedtælle.Click += new System.EventHandler(this.Nedtælle_Click);
            // 
            // Alame
            // 
            this.Alame.BackColor = System.Drawing.Color.Black;
            this.Alame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Alame.Location = new System.Drawing.Point(12, 391);
            this.Alame.Name = "Alame";
            this.Alame.Size = new System.Drawing.Size(152, 64);
            this.Alame.TabIndex = 23;
            this.Alame.Text = "Alame";
            this.Alame.UseVisualStyleBackColor = false;
            this.Alame.Click += new System.EventHandler(this.Alame_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(941, 464);
            this.Controls.Add(this.Alame);
            this.Controls.Add(this.Nedtælle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nedtællecs);
            this.Controls.Add(this.Nedtællemin);
            this.Controls.Add(this.Nedtællesec);
            this.Controls.Add(this.Nedtælletime);
            this.Controls.Add(this.cs);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.min);
            this.Controls.Add(this.nåstil);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.kl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kl;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button nåstil;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label sec;
        private System.Windows.Forms.Label cs;
        private System.Windows.Forms.TextBox Nedtælletime;
        private System.Windows.Forms.TextBox Nedtællesec;
        private System.Windows.Forms.TextBox Nedtællemin;
        private System.Windows.Forms.TextBox Nedtællecs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Nedtælle;
        private System.Windows.Forms.Button Alame;
    }
}

