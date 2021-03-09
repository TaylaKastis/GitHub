namespace GitHub
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
            this.textLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.InputTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textLbl
            // 
            this.textLbl.AutoSize = true;
            this.textLbl.Location = new System.Drawing.Point(75, 94);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(183, 17);
            this.textLbl.TabIndex = 0;
            this.textLbl.Text = "Your text will display here ...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open Textbox";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputTb
            // 
            this.InputTb.Location = new System.Drawing.Point(114, 12);
            this.InputTb.Name = "InputTb";
            this.InputTb.Size = new System.Drawing.Size(100, 22);
            this.InputTb.TabIndex = 2;
            this.InputTb.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 259);
            this.Controls.Add(this.InputTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textLbl);
            this.Name = "Form1";
            this.Text = "GitHub Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InputTb;
    }
}

