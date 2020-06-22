namespace ur_der_kan_alt
{
    partial class du_skal_op
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
            this.Tilbage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tilbage
            // 
            this.Tilbage.BackColor = System.Drawing.Color.Black;
            this.Tilbage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tilbage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Tilbage.Location = new System.Drawing.Point(12, 396);
            this.Tilbage.Name = "Tilbage";
            this.Tilbage.Size = new System.Drawing.Size(142, 56);
            this.Tilbage.TabIndex = 0;
            this.Tilbage.Text = "Tilbage";
            this.Tilbage.UseVisualStyleBackColor = false;
            this.Tilbage.Click += new System.EventHandler(this.Tilbage_Click);
            // 
            // du_skal_op
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(941, 464);
            this.Controls.Add(this.Tilbage);
            this.Name = "du_skal_op";
            this.Text = "du_skal_op";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Tilbage;
    }
}