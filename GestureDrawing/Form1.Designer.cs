namespace GestureDrawing
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
            this.button1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.txtElementCount = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.RadioButton();
            this.button8 = new System.Windows.Forms.RadioButton();
            this.button9 = new System.Windows.Forms.RadioButton();
            this.button10 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select a folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(324, 318);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(134, 38);
            this.button11.TabIndex = 10;
            this.button11.Text = "Lets draw!";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(238, 153);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(305, 20);
            this.txtFolderPath.TabIndex = 11;
            this.txtFolderPath.Text = "txtFolderPath";
            this.txtFolderPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtElementCount
            // 
            this.txtElementCount.Location = new System.Drawing.Point(345, 179);
            this.txtElementCount.Name = "txtElementCount";
            this.txtElementCount.Size = new System.Drawing.Size(83, 20);
            this.txtElementCount.TabIndex = 12;
            this.txtElementCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(283, 221);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Fixed time for all images";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Location = new System.Drawing.Point(238, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 65);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(6, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 17);
            this.button5.TabIndex = 0;
            this.button5.TabStop = true;
            this.button5.Text = "30s";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(54, 28);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 17);
            this.button6.TabIndex = 1;
            this.button6.TabStop = true;
            this.button6.Text = "45s";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(102, 28);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(39, 17);
            this.button7.TabIndex = 16;
            this.button7.TabStop = true;
            this.button7.Text = "1m";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(147, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(39, 17);
            this.button8.TabIndex = 17;
            this.button8.TabStop = true;
            this.button8.Text = "2m";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Location = new System.Drawing.Point(192, 28);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(39, 17);
            this.button9.TabIndex = 18;
            this.button9.TabStop = true;
            this.button9.Text = "5m";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Location = new System.Drawing.Point(237, 28);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(45, 17);
            this.button10.TabIndex = 19;
            this.button10.TabStop = true;
            this.button10.Text = "10m";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtElementCount);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox txtFolderPath;
        public System.Windows.Forms.TextBox txtElementCount;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton button6;
        private System.Windows.Forms.RadioButton button5;
        private System.Windows.Forms.RadioButton button7;
        private System.Windows.Forms.RadioButton button8;
        private System.Windows.Forms.RadioButton button9;
        private System.Windows.Forms.RadioButton button10;
    }
}

