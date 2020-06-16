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
            this.temperature = new System.Windows.Forms.Label();
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
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.temperature.Location = new System.Drawing.Point(340, 316);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(365, 55);
            this.temperature.TabIndex = 2;
            this.temperature.Text = "temperature 00";
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
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Black;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.start.Location = new System.Drawing.Point(484, 108);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(115, 64);
            this.start.TabIndex = 7;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Black;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.stop.Location = new System.Drawing.Point(605, 108);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(115, 64);
            this.stop.TabIndex = 8;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // nåstil
            // 
            this.nåstil.BackColor = System.Drawing.Color.Black;
            this.nåstil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nåstil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nåstil.Location = new System.Drawing.Point(726, 108);
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
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(941, 464);
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
            this.Controls.Add(this.temperature);
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
        private System.Windows.Forms.Label temperature;
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
    }
}

