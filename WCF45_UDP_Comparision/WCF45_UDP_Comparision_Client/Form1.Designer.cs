namespace WCF45_UDP_Comparision_Client
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
            this.button1 = new System.Windows.Forms.Button();
            this.rdTcp = new System.Windows.Forms.RadioButton();
            this.rdHttp = new System.Windows.Forms.RadioButton();
            this.rdUdp = new System.Windows.Forms.RadioButton();
            this.lblTcpTime = new System.Windows.Forms.Label();
            this.lblHttpTime = new System.Windows.Forms.Label();
            this.lblUdpTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(747, 132);
            this.button1.TabIndex = 0;
            this.button1.Text = "Post Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdTcp
            // 
            this.rdTcp.AutoSize = true;
            this.rdTcp.Location = new System.Drawing.Point(35, 42);
            this.rdTcp.Name = "rdTcp";
            this.rdTcp.Size = new System.Drawing.Size(46, 17);
            this.rdTcp.TabIndex = 1;
            this.rdTcp.TabStop = true;
            this.rdTcp.Text = "TCP";
            this.rdTcp.UseVisualStyleBackColor = true;
            this.rdTcp.CheckedChanged += new System.EventHandler(this.rdTcp_CheckedChanged);
            // 
            // rdHttp
            // 
            this.rdHttp.AutoSize = true;
            this.rdHttp.Location = new System.Drawing.Point(360, 42);
            this.rdHttp.Name = "rdHttp";
            this.rdHttp.Size = new System.Drawing.Size(54, 17);
            this.rdHttp.TabIndex = 2;
            this.rdHttp.TabStop = true;
            this.rdHttp.Text = "HTTP";
            this.rdHttp.UseVisualStyleBackColor = true;
            this.rdHttp.CheckedChanged += new System.EventHandler(this.rdHttp_CheckedChanged);
            // 
            // rdUdp
            // 
            this.rdUdp.AutoSize = true;
            this.rdUdp.Location = new System.Drawing.Point(652, 42);
            this.rdUdp.Name = "rdUdp";
            this.rdUdp.Size = new System.Drawing.Size(48, 17);
            this.rdUdp.TabIndex = 3;
            this.rdUdp.TabStop = true;
            this.rdUdp.Text = "UDP";
            this.rdUdp.UseVisualStyleBackColor = true;
            this.rdUdp.CheckedChanged += new System.EventHandler(this.rdUdp_CheckedChanged);
            // 
            // lblTcpTime
            // 
            this.lblTcpTime.Location = new System.Drawing.Point(35, 395);
            this.lblTcpTime.Name = "lblTcpTime";
            this.lblTcpTime.Size = new System.Drawing.Size(176, 23);
            this.lblTcpTime.TabIndex = 4;
            this.lblTcpTime.Text = "Tcp Time:";
            // 
            // lblHttpTime
            // 
            this.lblHttpTime.Location = new System.Drawing.Point(357, 395);
            this.lblHttpTime.Name = "lblHttpTime";
            this.lblHttpTime.Size = new System.Drawing.Size(171, 23);
            this.lblHttpTime.TabIndex = 5;
            this.lblHttpTime.Text = "Http Time:";
            // 
            // lblUdpTime
            // 
            this.lblUdpTime.Location = new System.Drawing.Point(649, 395);
            this.lblUdpTime.Name = "lblUdpTime";
            this.lblUdpTime.Size = new System.Drawing.Size(88, 23);
            this.lblUdpTime.TabIndex = 6;
            this.lblUdpTime.Text = "Udp Time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 485);
            this.Controls.Add(this.lblUdpTime);
            this.Controls.Add(this.lblHttpTime);
            this.Controls.Add(this.lblTcpTime);
            this.Controls.Add(this.rdUdp);
            this.Controls.Add(this.rdHttp);
            this.Controls.Add(this.rdTcp);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdTcp;
        private System.Windows.Forms.RadioButton rdHttp;
        private System.Windows.Forms.RadioButton rdUdp;
        private System.Windows.Forms.Label lblTcpTime;
        private System.Windows.Forms.Label lblHttpTime;
        private System.Windows.Forms.Label lblUdpTime;
    }
}

