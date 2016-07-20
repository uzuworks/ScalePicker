namespace ScalePicker.View
{
    partial class MainForm
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
            this.CurrentPoint = new System.Windows.Forms.TextBox();
            this.DisplayBasePoint = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DisplayOffset = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DisplayLength = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DragBasePoint = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DragRadian = new System.Windows.Forms.TextBox();
            this.DragLength = new System.Windows.Forms.TextBox();
            this.DragOffset = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChangeModeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentPoint
            // 
            this.CurrentPoint.Location = new System.Drawing.Point(83, 6);
            this.CurrentPoint.Name = "CurrentPoint";
            this.CurrentPoint.ReadOnly = true;
            this.CurrentPoint.Size = new System.Drawing.Size(75, 19);
            this.CurrentPoint.TabIndex = 0;
            // 
            // DisplayBasePoint
            // 
            this.DisplayBasePoint.Location = new System.Drawing.Point(71, 18);
            this.DisplayBasePoint.Name = "DisplayBasePoint";
            this.DisplayBasePoint.ReadOnly = true;
            this.DisplayBasePoint.Size = new System.Drawing.Size(75, 19);
            this.DisplayBasePoint.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "基準座標：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "現座標：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "※ダブルクリックで基準点を指定";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Δ：";
            // 
            // DisplayOffset
            // 
            this.DisplayOffset.Location = new System.Drawing.Point(71, 43);
            this.DisplayOffset.Name = "DisplayOffset";
            this.DisplayOffset.ReadOnly = true;
            this.DisplayOffset.Size = new System.Drawing.Size(75, 19);
            this.DisplayOffset.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Length：";
            // 
            // DisplayLength
            // 
            this.DisplayLength.Location = new System.Drawing.Point(203, 43);
            this.DisplayLength.Name = "DisplayLength";
            this.DisplayLength.ReadOnly = true;
            this.DisplayLength.Size = new System.Drawing.Size(75, 19);
            this.DisplayLength.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DragBasePoint);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.DragRadian);
            this.groupBox1.Controls.Add(this.DragLength);
            this.groupBox1.Controls.Add(this.DragOffset);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 70);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MouseDrag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "Radian：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "基準座標：";
            // 
            // DragBasePoint
            // 
            this.DragBasePoint.Location = new System.Drawing.Point(71, 18);
            this.DragBasePoint.Name = "DragBasePoint";
            this.DragBasePoint.ReadOnly = true;
            this.DragBasePoint.Size = new System.Drawing.Size(75, 19);
            this.DragBasePoint.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "Length：";
            // 
            // DragRadian
            // 
            this.DragRadian.Location = new System.Drawing.Point(204, 18);
            this.DragRadian.Name = "DragRadian";
            this.DragRadian.ReadOnly = true;
            this.DragRadian.Size = new System.Drawing.Size(75, 19);
            this.DragRadian.TabIndex = 18;
            // 
            // DragLength
            // 
            this.DragLength.Location = new System.Drawing.Point(203, 43);
            this.DragLength.Name = "DragLength";
            this.DragLength.ReadOnly = true;
            this.DragLength.Size = new System.Drawing.Size(75, 19);
            this.DragLength.TabIndex = 18;
            // 
            // DragOffset
            // 
            this.DragOffset.Location = new System.Drawing.Point(71, 43);
            this.DragOffset.Name = "DragOffset";
            this.DragOffset.ReadOnly = true;
            this.DragOffset.Size = new System.Drawing.Size(75, 19);
            this.DragOffset.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "Δ：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DisplayBasePoint);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.DisplayLength);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DisplayOffset);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 70);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display";
            // 
            // ChangeModeButton
            // 
            this.ChangeModeButton.Location = new System.Drawing.Point(257, 4);
            this.ChangeModeButton.Name = "ChangeModeButton";
            this.ChangeModeButton.Size = new System.Drawing.Size(75, 23);
            this.ChangeModeButton.TabIndex = 14;
            this.ChangeModeButton.Text = "Pixel";
            this.ChangeModeButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(344, 188);
            this.Controls.Add(this.ChangeModeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CurrentPoint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(360, 225);
            this.MinimumSize = new System.Drawing.Size(360, 225);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox CurrentPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox DisplayBasePoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox DisplayOffset;
        public System.Windows.Forms.TextBox DisplayLength;
        public System.Windows.Forms.TextBox DragBasePoint;
        public System.Windows.Forms.TextBox DragOffset;
        public System.Windows.Forms.TextBox DragLength;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox DragRadian;
        public System.Windows.Forms.Button ChangeModeButton;



    }
}