namespace client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonJoin = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.textBoxMove = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(92, 25);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(146, 22);
            this.textBoxIP.TabIndex = 2;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(280, 25);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(146, 22);
            this.textBoxPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(515, 25);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(146, 22);
            this.textBoxUsername.TabIndex = 5;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(19, 70);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(126, 36);
            this.buttonConnect.TabIndex = 6;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonJoin
            // 
            this.buttonJoin.Enabled = false;
            this.buttonJoin.Location = new System.Drawing.Point(104, 124);
            this.buttonJoin.Name = "buttonJoin";
            this.buttonJoin.Size = new System.Drawing.Size(126, 36);
            this.buttonJoin.TabIndex = 7;
            this.buttonJoin.Text = "Join Game";
            this.buttonJoin.UseVisualStyleBackColor = true;
            // 
            // buttonLeave
            // 
            this.buttonLeave.Enabled = false;
            this.buttonLeave.Location = new System.Drawing.Point(486, 124);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(126, 36);
            this.buttonLeave.TabIndex = 8;
            this.buttonLeave.Text = "Leave Game";
            this.buttonLeave.UseVisualStyleBackColor = true;
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(104, 175);
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(508, 328);
            this.logs.TabIndex = 9;
            this.logs.Text = "";
            // 
            // buttonMove
            // 
            this.buttonMove.Enabled = false;
            this.buttonMove.Location = new System.Drawing.Point(486, 510);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(126, 34);
            this.buttonMove.TabIndex = 10;
            this.buttonMove.Text = "Make Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            // 
            // textBoxMove
            // 
            this.textBoxMove.Enabled = false;
            this.textBoxMove.Location = new System.Drawing.Point(104, 516);
            this.textBoxMove.Name = "textBoxMove";
            this.textBoxMove.Size = new System.Drawing.Size(376, 22);
            this.textBoxMove.TabIndex = 11;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(156, 70);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(126, 36);
            this.buttonDisconnect.TabIndex = 12;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 581);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.textBoxMove);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonJoin);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonJoin;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.TextBox textBoxMove;
        private System.Windows.Forms.Button buttonDisconnect;
    }
}

