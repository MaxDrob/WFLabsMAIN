namespace Lab1Task5part1ELLIPSE
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
            this.CLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CLOSE
            // 
            this.CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.CLOSE.Location = new System.Drawing.Point(211, 99);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(75, 23);
            this.CLOSE.TabIndex = 0;
            this.CLOSE.Text = "CLOSE";
            this.CLOSE.UseVisualStyleBackColor = false;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.CLOSE);
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.Text = "OVAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CLOSE;
    }
}

