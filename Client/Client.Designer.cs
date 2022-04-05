namespace WIN___Chat_Applicatie
{
    partial class Client
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
            this.btnClientJoin = new System.Windows.Forms.Button();
            this.btnClientSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBufferSize = new System.Windows.Forms.TextBox();
            this.labelBuffersize = new System.Windows.Forms.Label();
            this.labelChatserverPort = new System.Windows.Forms.Label();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.btnClientLeave = new System.Windows.Forms.Button();
            this.txtClientIp = new System.Windows.Forms.TextBox();
            this.labelChatserverIP = new System.Windows.Forms.Label();
            this.lsbClient = new System.Windows.Forms.ListBox();
            this.txtClientSend = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClientJoin
            // 
            this.btnClientJoin.Location = new System.Drawing.Point(9, 173);
            this.btnClientJoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientJoin.Name = "btnClientJoin";
            this.btnClientJoin.Size = new System.Drawing.Size(179, 22);
            this.btnClientJoin.TabIndex = 1;
            this.btnClientJoin.Text = "Meedoen";
            this.btnClientJoin.UseVisualStyleBackColor = true;
            this.btnClientJoin.Click += new System.EventHandler(this.buttonConnectToServer_Click);
            // 
            // btnClientSend
            // 
            this.btnClientSend.Enabled = false;
            this.btnClientSend.Location = new System.Drawing.Point(370, 296);
            this.btnClientSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientSend.Name = "btnClientSend";
            this.btnClientSend.Size = new System.Drawing.Size(82, 23);
            this.btnClientSend.TabIndex = 2;
            this.btnClientSend.Text = "Stuur";
            this.btnClientSend.UseVisualStyleBackColor = true;
            this.btnClientSend.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBufferSize);
            this.groupBox1.Controls.Add(this.labelBuffersize);
            this.groupBox1.Controls.Add(this.labelChatserverPort);
            this.groupBox1.Controls.Add(this.txtClientPort);
            this.groupBox1.Controls.Add(this.btnClientLeave);
            this.groupBox1.Controls.Add(this.txtClientIp);
            this.groupBox1.Controls.Add(this.labelChatserverIP);
            this.groupBox1.Controls.Add(this.btnClientJoin);
            this.groupBox1.Location = new System.Drawing.Point(458, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(192, 206);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Met server verbinden";
            // 
            // txtBufferSize
            // 
            this.txtBufferSize.Location = new System.Drawing.Point(9, 137);
            this.txtBufferSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBufferSize.Name = "txtBufferSize";
            this.txtBufferSize.Size = new System.Drawing.Size(179, 23);
            this.txtBufferSize.TabIndex = 8;
            this.txtBufferSize.Text = "10";
            // 
            // labelBuffersize
            // 
            this.labelBuffersize.AutoSize = true;
            this.labelBuffersize.Location = new System.Drawing.Point(9, 120);
            this.labelBuffersize.Name = "labelBuffersize";
            this.labelBuffersize.Size = new System.Drawing.Size(81, 15);
            this.labelBuffersize.TabIndex = 7;
            this.labelBuffersize.Text = "Buffergrootte:";
            // 
            // labelChatserverPort
            // 
            this.labelChatserverPort.AutoSize = true;
            this.labelChatserverPort.Location = new System.Drawing.Point(9, 69);
            this.labelChatserverPort.Name = "labelChatserverPort";
            this.labelChatserverPort.Size = new System.Drawing.Size(32, 15);
            this.labelChatserverPort.TabIndex = 6;
            this.labelChatserverPort.Text = "Port:";
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(9, 87);
            this.txtClientPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(179, 23);
            this.txtClientPort.TabIndex = 5;
            this.txtClientPort.Text = "8080";
            // 
            // btnClientLeave
            // 
            this.btnClientLeave.Location = new System.Drawing.Point(9, 173);
            this.btnClientLeave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClientLeave.Name = "btnClientLeave";
            this.btnClientLeave.Size = new System.Drawing.Size(179, 22);
            this.btnClientLeave.TabIndex = 4;
            this.btnClientLeave.Text = "Verlaten";
            this.btnClientLeave.UseVisualStyleBackColor = true;
            this.btnClientLeave.Visible = false;
            this.btnClientLeave.Click += new System.EventHandler(this.buttonDisconnectFromServer_Click);
            // 
            // txtClientIp
            // 
            this.txtClientIp.Location = new System.Drawing.Point(9, 40);
            this.txtClientIp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientIp.Name = "txtClientIp";
            this.txtClientIp.Size = new System.Drawing.Size(179, 23);
            this.txtClientIp.TabIndex = 3;
            this.txtClientIp.Text = "127.0.0.1";
            // 
            // labelChatserverIP
            // 
            this.labelChatserverIP.AutoSize = true;
            this.labelChatserverIP.Location = new System.Drawing.Point(9, 22);
            this.labelChatserverIP.Name = "labelChatserverIP";
            this.labelChatserverIP.Size = new System.Drawing.Size(52, 15);
            this.labelChatserverIP.TabIndex = 2;
            this.labelChatserverIP.Text = "IP-Adres";
            // 
            // lsbClient
            // 
            this.lsbClient.FormattingEnabled = true;
            this.lsbClient.ItemHeight = 15;
            this.lsbClient.Location = new System.Drawing.Point(10, 9);
            this.lsbClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbClient.Name = "lsbClient";
            this.lsbClient.Size = new System.Drawing.Size(442, 274);
            this.lsbClient.TabIndex = 4;
            // 
            // txtClientSend
            // 
            this.txtClientSend.Location = new System.Drawing.Point(10, 296);
            this.txtClientSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtClientSend.Name = "txtClientSend";
            this.txtClientSend.Size = new System.Drawing.Size(354, 23);
            this.txtClientSend.TabIndex = 5;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 326);
            this.Controls.Add(this.txtClientSend);
            this.Controls.Add(this.lsbClient);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClientSend);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Client";
            this.Text = "Chatapplicatie - Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnClientJoin;
        private Button btnClientSend;
        private GroupBox groupBox1;
        private Label labelChatserverIP;
        private ListBox lsbClient;
        private TextBox txtClientSend;
        private TextBox txtClientIp;
        private Button btnClientLeave;
        private Label labelChatserverPort;
        private TextBox txtClientPort;
        private TextBox txtBufferSize;
        private Label labelBuffersize;
    }
}