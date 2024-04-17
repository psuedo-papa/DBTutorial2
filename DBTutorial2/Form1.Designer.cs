
namespace DBTutorial2
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
            this.lstBox1 = new System.Windows.Forms.ListBox();
            this.lstBox2 = new System.Windows.Forms.ListBox();
            this.lstBox3 = new System.Windows.Forms.ListBox();
            this.lstBox4 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBox1
            // 
            this.lstBox1.FormattingEnabled = true;
            this.lstBox1.Location = new System.Drawing.Point(41, 111);
            this.lstBox1.Name = "lstBox1";
            this.lstBox1.Size = new System.Drawing.Size(185, 459);
            this.lstBox1.TabIndex = 0;
            // 
            // lstBox2
            // 
            this.lstBox2.FormattingEnabled = true;
            this.lstBox2.Location = new System.Drawing.Point(263, 111);
            this.lstBox2.Name = "lstBox2";
            this.lstBox2.Size = new System.Drawing.Size(185, 459);
            this.lstBox2.TabIndex = 1;
            // 
            // lstBox3
            // 
            this.lstBox3.FormattingEnabled = true;
            this.lstBox3.Location = new System.Drawing.Point(486, 111);
            this.lstBox3.Name = "lstBox3";
            this.lstBox3.Size = new System.Drawing.Size(185, 459);
            this.lstBox3.TabIndex = 2;
            // 
            // lstBox4
            // 
            this.lstBox4.FormattingEnabled = true;
            this.lstBox4.Location = new System.Drawing.Point(711, 111);
            this.lstBox4.Name = "lstBox4";
            this.lstBox4.Size = new System.Drawing.Size(185, 459);
            this.lstBox4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 639);
            this.Controls.Add(this.lstBox4);
            this.Controls.Add(this.lstBox3);
            this.Controls.Add(this.lstBox2);
            this.Controls.Add(this.lstBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox1;
        private System.Windows.Forms.ListBox lstBox2;
        private System.Windows.Forms.ListBox lstBox3;
        private System.Windows.Forms.ListBox lstBox4;
    }
}

