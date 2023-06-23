namespace CafeManagement
{
    partial class Form3
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
            this.rtfReceipt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // rtfReceipt
            // 
            this.rtfReceipt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtfReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfReceipt.Location = new System.Drawing.Point(3, 3);
            this.rtfReceipt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtfReceipt.Name = "rtfReceipt";
            this.rtfReceipt.ReadOnly = true;
            this.rtfReceipt.Size = new System.Drawing.Size(407, 436);
            this.rtfReceipt.TabIndex = 6;
            this.rtfReceipt.Text = "";
            this.rtfReceipt.TextChanged += new System.EventHandler(this.rtfReceipt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Font = new System.Drawing.Font("Baskerville Old Face", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(79, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 49);
            this.label13.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtfReceipt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.RichTextBox rtfReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.Timer timer1;
    }
}