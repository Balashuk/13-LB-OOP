namespace OOP_13lb_
{
    partial class FormPorodgeno
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
            this.ДатаНародження = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ДатаНародження
            // 
            this.ДатаНародження.Location = new System.Drawing.Point(268, 263);
            this.ДатаНародження.Name = "ДатаНародження";
            this.ДатаНародження.Size = new System.Drawing.Size(322, 22);
            this.ДатаНародження.TabIndex = 8;
            this.ДатаНародження.Value = new System.DateTime(2002, 8, 7, 0, 0, 0, 0);
            this.ДатаНародження.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // FormPorodgeno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ДатаНародження);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormPorodgeno";
            this.Text = "Друга форма Лб 13";
            this.Load += new System.EventHandler(this.FormPorodgeno_Load);
            this.Controls.SetChildIndex(this.ДатаНародження, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ДатаНародження;
    }
}