namespace Test
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
            this.txtUnicode = new System.Windows.Forms.TextBox();
            this.btntoLimon = new System.Windows.Forms.Button();
            this.txtLimon = new System.Windows.Forms.TextBox();
            this.btnToUnicode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnicode
            // 
            this.txtUnicode.Font = new System.Drawing.Font("Khmer OS Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnicode.Location = new System.Drawing.Point(12, 14);
            this.txtUnicode.Multiline = true;
            this.txtUnicode.Name = "txtUnicode";
            this.txtUnicode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUnicode.Size = new System.Drawing.Size(356, 218);
            this.txtUnicode.TabIndex = 0;
            this.txtUnicode.Text = "ញ៉ សុភាព";
            // 
            // btntoLimon
            // 
            this.btntoLimon.Location = new System.Drawing.Point(374, 96);
            this.btntoLimon.Name = "btntoLimon";
            this.btntoLimon.Size = new System.Drawing.Size(75, 23);
            this.btntoLimon.TabIndex = 1;
            this.btntoLimon.Text = "To Limon";
            this.btntoLimon.UseVisualStyleBackColor = true;
            this.btntoLimon.Click += new System.EventHandler(this.btntoLimon_Click);
            // 
            // txtLimon
            // 
            this.txtLimon.Font = new System.Drawing.Font("Limon S1", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimon.Location = new System.Drawing.Point(455, 10);
            this.txtLimon.Multiline = true;
            this.txtLimon.Name = "txtLimon";
            this.txtLimon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLimon.Size = new System.Drawing.Size(356, 218);
            this.txtLimon.TabIndex = 2;
            // 
            // btnToUnicode
            // 
            this.btnToUnicode.Location = new System.Drawing.Point(374, 125);
            this.btnToUnicode.Name = "btnToUnicode";
            this.btnToUnicode.Size = new System.Drawing.Size(75, 23);
            this.btnToUnicode.TabIndex = 3;
            this.btnToUnicode.Text = "To Unicode";
            this.btnToUnicode.UseVisualStyleBackColor = true;
            this.btnToUnicode.Click += new System.EventHandler(this.btnToUnicode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 248);
            this.Controls.Add(this.btnToUnicode);
            this.Controls.Add(this.txtLimon);
            this.Controls.Add(this.btntoLimon);
            this.Controls.Add(this.txtUnicode);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toma Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnicode;
        private System.Windows.Forms.Button btntoLimon;
        private System.Windows.Forms.TextBox txtLimon;
        private System.Windows.Forms.Button btnToUnicode;
    }
}

