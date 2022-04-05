namespace ServerApp
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnServerStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnServerStop = new System.Windows.Forms.Button();
            this.labelBuffersize = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtBufferSize = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.listBoxServer = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(16, 184);
            this.btnServerStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(170, 22);
            this.btnServerStart.TabIndex = 0;
            this.btnServerStart.Text = "Start server";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.startServerButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnServerStop);
            this.groupBox1.Controls.Add(this.labelBuffersize);
            this.groupBox1.Controls.Add(this.lblPort);
            this.groupBox1.Controls.Add(this.lblIp);
            this.groupBox1.Controls.Add(this.txtBufferSize);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIp);
            this.groupBox1.Controls.Add(this.btnServerStart);
            this.groupBox1.Location = new System.Drawing.Point(452, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(201, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server instellingen";
            // 
            // btnServerStop
            // 
            this.btnServerStop.Location = new System.Drawing.Point(15, 184);
            this.btnServerStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServerStop.Name = "btnServerStop";
            this.btnServerStop.Size = new System.Drawing.Size(170, 22);
            this.btnServerStop.TabIndex = 8;
            this.btnServerStop.Text = "Stop server";
            this.btnServerStop.UseVisualStyleBackColor = true;
            this.btnServerStop.Visible = false;
            this.btnServerStop.Click += new System.EventHandler(this.buttonStopServer_Click);
            // 
            // labelBuffersize
            // 
            this.labelBuffersize.AutoSize = true;
            this.labelBuffersize.Location = new System.Drawing.Point(15, 130);
            this.labelBuffersize.Name = "labelBuffersize";
            this.labelBuffersize.Size = new System.Drawing.Size(81, 15);
            this.labelBuffersize.TabIndex = 7;
            this.labelBuffersize.Text = "Buffergrootte:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(16, 78);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(32, 15);
            this.lblPort.TabIndex = 6;
            this.lblPort.Text = "Port:";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(15, 24);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(52, 15);
            this.lblIp.TabIndex = 5;
            this.lblIp.Text = "IP-Adres";
            // 
            // txtBufferSize
            // 
            this.txtBufferSize.Location = new System.Drawing.Point(15, 147);
            this.txtBufferSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBufferSize.Name = "txtBufferSize";
            this.txtBufferSize.Size = new System.Drawing.Size(170, 23);
            this.txtBufferSize.TabIndex = 3;
            this.txtBufferSize.Text = "10";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(15, 96);
            this.txtPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(170, 23);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "8080";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(15, 42);
            this.txtIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(170, 23);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "127.0.0.1";
            // 
            // listBoxServer
            // 
            this.listBoxServer.FormattingEnabled = true;
            this.listBoxServer.ItemHeight = 15;
            this.listBoxServer.Location = new System.Drawing.Point(10, 9);
            this.listBoxServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxServer.Name = "listBoxServer";
            this.listBoxServer.Size = new System.Drawing.Size(436, 319);
            this.listBoxServer.TabIndex = 2;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 338);
            this.Controls.Add(this.listBoxServer);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Server";
            this.Text = "Chatapplicatie - Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnServerStart;
        private GroupBox groupBox1;
        private Label labelBuffersize;
        private Label lblPort;
        private Label lblIp;
        private TextBox txtBufferSize;
        private TextBox txtPort;
        private TextBox txtIp;
        private ListBox listBoxServer;
        private Button btnServerStop;
    }
}