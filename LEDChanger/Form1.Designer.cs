namespace LEDChanger
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
            this.cntbutt = new System.Windows.Forms.Button();
            this.colorslist = new System.Windows.Forms.ComboBox();
            this.ipinput = new System.Windows.Forms.TextBox();
            this.setcolor = new System.Windows.Forms.Button();
            this.usernameinput = new System.Windows.Forms.TextBox();
            this.passwordinput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.poweron = new System.Windows.Forms.Button();
            this.poweroff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btinput = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntbutt
            // 
            this.cntbutt.Location = new System.Drawing.Point(166, 115);
            this.cntbutt.Name = "cntbutt";
            this.cntbutt.Size = new System.Drawing.Size(75, 23);
            this.cntbutt.TabIndex = 0;
            this.cntbutt.Text = "Connect";
            this.cntbutt.UseVisualStyleBackColor = true;
            this.cntbutt.Click += new System.EventHandler(this.cntbutt_Click);
            // 
            // colorslist
            // 
            this.colorslist.FormattingEnabled = true;
            this.colorslist.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.colorslist.Location = new System.Drawing.Point(16, 169);
            this.colorslist.Name = "colorslist";
            this.colorslist.Size = new System.Drawing.Size(123, 21);
            this.colorslist.TabIndex = 1;
            // 
            // ipinput
            // 
            this.ipinput.Location = new System.Drawing.Point(13, 43);
            this.ipinput.Name = "ipinput";
            this.ipinput.Size = new System.Drawing.Size(147, 20);
            this.ipinput.TabIndex = 2;
            // 
            // setcolor
            // 
            this.setcolor.Location = new System.Drawing.Point(16, 196);
            this.setcolor.Name = "setcolor";
            this.setcolor.Size = new System.Drawing.Size(75, 23);
            this.setcolor.TabIndex = 3;
            this.setcolor.Text = "Set Color";
            this.setcolor.UseVisualStyleBackColor = true;
            this.setcolor.Click += new System.EventHandler(this.setcolor_Click);
            // 
            // usernameinput
            // 
            this.usernameinput.Location = new System.Drawing.Point(166, 43);
            this.usernameinput.Name = "usernameinput";
            this.usernameinput.Size = new System.Drawing.Size(147, 20);
            this.usernameinput.TabIndex = 4;
            // 
            // passwordinput
            // 
            this.passwordinput.Location = new System.Drawing.Point(166, 89);
            this.passwordinput.Name = "passwordinput";
            this.passwordinput.Size = new System.Drawing.Size(147, 20);
            this.passwordinput.TabIndex = 5;
            this.passwordinput.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 234);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(332, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connectionstatus
            // 
            this.connectionstatus.ForeColor = System.Drawing.Color.Red;
            this.connectionstatus.Name = "connectionstatus";
            this.connectionstatus.Size = new System.Drawing.Size(29, 17);
            this.connectionstatus.Text = "N/A";
            // 
            // poweron
            // 
            this.poweron.Location = new System.Drawing.Point(146, 169);
            this.poweron.Name = "poweron";
            this.poweron.Size = new System.Drawing.Size(75, 23);
            this.poweron.TabIndex = 10;
            this.poweron.Text = "Power On";
            this.poweron.UseVisualStyleBackColor = true;
            this.poweron.Click += new System.EventHandler(this.poweron_Click);
            // 
            // poweroff
            // 
            this.poweroff.Location = new System.Drawing.Point(227, 169);
            this.poweroff.Name = "poweroff";
            this.poweroff.Size = new System.Drawing.Size(75, 23);
            this.poweroff.TabIndex = 11;
            this.poweroff.Text = "Power Off";
            this.poweroff.UseVisualStyleBackColor = true;
            this.poweroff.Click += new System.EventHandler(this.poweroff_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Find LEDs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btinput
            // 
            this.btinput.Location = new System.Drawing.Point(13, 89);
            this.btinput.Name = "btinput";
            this.btinput.Size = new System.Drawing.Size(147, 20);
            this.btinput.TabIndex = 13;
            this.btinput.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Colour Wheel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Device mac address";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 256);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btinput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.poweroff);
            this.Controls.Add(this.poweron);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordinput);
            this.Controls.Add(this.usernameinput);
            this.Controls.Add(this.setcolor);
            this.Controls.Add(this.ipinput);
            this.Controls.Add(this.colorslist);
            this.Controls.Add(this.cntbutt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DuoCo LED Strip Changer";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cntbutt;
        private System.Windows.Forms.ComboBox colorslist;
        private System.Windows.Forms.TextBox ipinput;
        private System.Windows.Forms.Button setcolor;
        private System.Windows.Forms.TextBox usernameinput;
        private System.Windows.Forms.TextBox passwordinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionstatus;
        private System.Windows.Forms.Button poweron;
        private System.Windows.Forms.Button poweroff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox btinput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

