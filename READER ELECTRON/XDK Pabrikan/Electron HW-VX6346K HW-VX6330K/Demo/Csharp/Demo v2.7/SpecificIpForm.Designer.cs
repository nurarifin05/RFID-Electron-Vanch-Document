namespace HwVx6330K
{
    partial class SpecificIpForm
    {
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ip4TextBox = new System.Windows.Forms.TextBox();
            this.ip3TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ip2TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ip1TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ip4TextBox);
            this.panel1.Controls.Add(this.ip3TextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ip2TextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ip1TextBox);
            this.panel1.Location = new System.Drawing.Point(131, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 21);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(90, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = ".";
            // 
            // ip4TextBox
            // 
            this.ip4TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip4TextBox.Location = new System.Drawing.Point(103, 1);
            this.ip4TextBox.MaxLength = 3;
            this.ip4TextBox.Name = "ip4TextBox";
            this.ip4TextBox.Size = new System.Drawing.Size(19, 13);
            this.ip4TextBox.TabIndex = 7;
            this.ip4TextBox.TextChanged += new System.EventHandler(this.ipTextBox_TextChanged);
            this.ip4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipTextBox_KeyPress);
            // 
            // ip3TextBox
            // 
            this.ip3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip3TextBox.Location = new System.Drawing.Point(69, 1);
            this.ip3TextBox.MaxLength = 3;
            this.ip3TextBox.Name = "ip3TextBox";
            this.ip3TextBox.Size = new System.Drawing.Size(19, 13);
            this.ip3TextBox.TabIndex = 6;
            this.ip3TextBox.TextChanged += new System.EventHandler(this.ipTextBox_TextChanged);
            this.ip3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(57, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ".";
            // 
            // ip2TextBox
            // 
            this.ip2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip2TextBox.Location = new System.Drawing.Point(36, 1);
            this.ip2TextBox.MaxLength = 3;
            this.ip2TextBox.Name = "ip2TextBox";
            this.ip2TextBox.Size = new System.Drawing.Size(19, 13);
            this.ip2TextBox.TabIndex = 4;
            this.ip2TextBox.TextChanged += new System.EventHandler(this.ipTextBox_TextChanged);
            this.ip2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(24, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = ".";
            // 
            // ip1TextBox
            // 
            this.ip1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip1TextBox.Location = new System.Drawing.Point(3, 1);
            this.ip1TextBox.MaxLength = 3;
            this.ip1TextBox.Name = "ip1TextBox";
            this.ip1TextBox.Size = new System.Drawing.Size(19, 13);
            this.ip1TextBox.TabIndex = 2;
            this.ip1TextBox.TextChanged += new System.EventHandler(this.ipTextBox_TextChanged);
            this.ip1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ipTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please input device IP：";
            // 
            // SpecificIpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 84);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpecificIpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Specific  Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ip1TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ip4TextBox;
        private System.Windows.Forms.TextBox ip3TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ip2TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}