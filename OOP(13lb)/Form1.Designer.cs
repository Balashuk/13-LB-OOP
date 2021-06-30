namespace OOP_13lb_
{
    partial class FormBase
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
            this.PrizvFo = new System.Windows.Forms.TextBox();
            this.NameFo = new System.Windows.Forms.TextBox();
            this.FNameFo = new System.Windows.Forms.TextBox();
            this.Rez = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrizvFo
            // 
            this.PrizvFo.Location = new System.Drawing.Point(268, 90);
            this.PrizvFo.Name = "PrizvFo";
            this.PrizvFo.Size = new System.Drawing.Size(475, 22);
            this.PrizvFo.TabIndex = 0;
            this.PrizvFo.Text = "Балашук";
            this.PrizvFo.TextChanged += new System.EventHandler(this.PrizvFo_TextChanged);
            // 
            // NameFo
            // 
            this.NameFo.Location = new System.Drawing.Point(268, 145);
            this.NameFo.Name = "NameFo";
            this.NameFo.Size = new System.Drawing.Size(475, 22);
            this.NameFo.TabIndex = 1;
            this.NameFo.Text = "Ярослав";
            this.NameFo.TextChanged += new System.EventHandler(this.NameFo_TextChanged);
            // 
            // FNameFo
            // 
            this.FNameFo.Location = new System.Drawing.Point(268, 211);
            this.FNameFo.Name = "FNameFo";
            this.FNameFo.Size = new System.Drawing.Size(475, 22);
            this.FNameFo.TabIndex = 2;
            this.FNameFo.Text = "Іванович";
            this.FNameFo.TextChanged += new System.EventHandler(this.FNameFo_TextChanged);
            // 
            // Rez
            // 
            this.Rez.Enabled = false;
            this.Rez.Location = new System.Drawing.Point(268, 306);
            this.Rez.Name = "Rez";
            this.Rez.Size = new System.Drawing.Size(475, 22);
            this.Rez.TabIndex = 3;
            this.Rez.TextChanged += new System.EventHandler(this.Rez_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "По батькові";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дані співробітника";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rez);
            this.Controls.Add(this.FNameFo);
            this.Controls.Add(this.NameFo);
            this.Controls.Add(this.PrizvFo);
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перша форма";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PrizvFo;
        private System.Windows.Forms.TextBox NameFo;
        private System.Windows.Forms.TextBox FNameFo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Rez;
    }
}