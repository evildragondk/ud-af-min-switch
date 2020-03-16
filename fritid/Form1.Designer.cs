namespace fritid
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
            this.plus = new System.Windows.Forms.Button();
            this.muls = new System.Windows.Forms.Button();
            this.gang = new System.Windows.Forms.Button();
            this.dividere = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nummer1 = new System.Windows.Forms.TextBox();
            this.nummer2 = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(12, 197);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(155, 78);
            this.plus.TabIndex = 9;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // muls
            // 
            this.muls.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muls.Location = new System.Drawing.Point(173, 197);
            this.muls.Name = "muls";
            this.muls.Size = new System.Drawing.Size(155, 78);
            this.muls.TabIndex = 10;
            this.muls.Text = "-";
            this.muls.UseVisualStyleBackColor = true;
            this.muls.Click += new System.EventHandler(this.Muls_Click);
            // 
            // gang
            // 
            this.gang.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gang.Location = new System.Drawing.Point(334, 197);
            this.gang.Name = "gang";
            this.gang.Size = new System.Drawing.Size(155, 78);
            this.gang.TabIndex = 11;
            this.gang.Text = "*";
            this.gang.UseVisualStyleBackColor = true;
            this.gang.Click += new System.EventHandler(this.Gang_Click);
            // 
            // dividere
            // 
            this.dividere.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividere.Location = new System.Drawing.Point(495, 197);
            this.dividere.Name = "dividere";
            this.dividere.Size = new System.Drawing.Size(155, 78);
            this.dividere.TabIndex = 12;
            this.dividere.Text = "/";
            this.dividere.UseVisualStyleBackColor = true;
            this.dividere.Click += new System.EventHandler(this.Dividere_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "nummer 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "nummer 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total";
            // 
            // nummer1
            // 
            this.nummer1.Location = new System.Drawing.Point(156, 38);
            this.nummer1.Name = "nummer1";
            this.nummer1.Size = new System.Drawing.Size(419, 20);
            this.nummer1.TabIndex = 16;
            // 
            // nummer2
            // 
            this.nummer2.Location = new System.Drawing.Point(156, 133);
            this.nummer2.Name = "nummer2";
            this.nummer2.Size = new System.Drawing.Size(419, 20);
            this.nummer2.TabIndex = 17;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(156, 361);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(419, 20);
            this.Total.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 470);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.nummer2);
            this.Controls.Add(this.nummer1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dividere);
            this.Controls.Add(this.gang);
            this.Controls.Add(this.muls);
            this.Controls.Add(this.plus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button muls;
        private System.Windows.Forms.Button gang;
        private System.Windows.Forms.Button dividere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nummer1;
        private System.Windows.Forms.TextBox nummer2;
        private System.Windows.Forms.TextBox Total;
    }
}

