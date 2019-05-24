namespace chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.redtHistory = new System.Windows.Forms.RichTextBox();
            this.edtToSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.edtServerPort = new System.Windows.Forms.TextBox();
            this.edtServerIP = new System.Windows.Forms.TextBox();
            this.btnClientStart = new System.Windows.Forms.Button();
            this.edtClientIP = new System.Windows.Forms.TextBox();
            this.edtClientPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redtHistory
            // 
            this.redtHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redtHistory.Location = new System.Drawing.Point(44, 321);
            this.redtHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.redtHistory.Name = "redtHistory";
            this.redtHistory.Size = new System.Drawing.Size(895, 146);
            this.redtHistory.TabIndex = 2;
            this.redtHistory.Text = "";
            // 
            // edtToSend
            // 
            this.edtToSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtToSend.Location = new System.Drawing.Point(45, 488);
            this.edtToSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtToSend.Name = "edtToSend";
            this.edtToSend.Size = new System.Drawing.Size(735, 26);
            this.edtToSend.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.Yellow;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSend.Location = new System.Drawing.Point(827, 489);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 35);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(795, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "5000->";
            // 
            // btnServerStart
            // 
            this.btnServerStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServerStart.BackColor = System.Drawing.Color.Gold;
            this.btnServerStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnServerStart.Location = new System.Drawing.Point(965, 33);
            this.btnServerStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(112, 35);
            this.btnServerStart.TabIndex = 7;
            this.btnServerStart.Text = "Start";
            this.btnServerStart.UseVisualStyleBackColor = false;
            // 
            // edtServerPort
            // 
            this.edtServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edtServerPort.Location = new System.Drawing.Point(796, 33);
            this.edtServerPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtServerPort.Name = "edtServerPort";
            this.edtServerPort.Size = new System.Drawing.Size(148, 26);
            this.edtServerPort.TabIndex = 6;
            // 
            // edtServerIP
            // 
            this.edtServerIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtServerIP.Location = new System.Drawing.Point(44, 33);
            this.edtServerIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtServerIP.Name = "edtServerIP";
            this.edtServerIP.Size = new System.Drawing.Size(741, 26);
            this.edtServerIP.TabIndex = 5;
            // 
            // btnClientStart
            // 
            this.btnClientStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientStart.BackColor = System.Drawing.Color.Gold;
            this.btnClientStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClientStart.Location = new System.Drawing.Point(966, 207);
            this.btnClientStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClientStart.Name = "btnClientStart";
            this.btnClientStart.Size = new System.Drawing.Size(112, 35);
            this.btnClientStart.TabIndex = 11;
            this.btnClientStart.Text = "Connect";
            this.btnClientStart.UseVisualStyleBackColor = false;
            // 
            // edtClientIP
            // 
            this.edtClientIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtClientIP.Location = new System.Drawing.Point(45, 211);
            this.edtClientIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtClientIP.Name = "edtClientIP";
            this.edtClientIP.Size = new System.Drawing.Size(741, 26);
            this.edtClientIP.TabIndex = 10;
            // 
            // edtClientPort
            // 
            this.edtClientPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edtClientPort.Location = new System.Drawing.Point(797, 211);
            this.edtClientPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edtClientPort.Name = "edtClientPort";
            this.edtClientPort.Size = new System.Drawing.Size(148, 26);
            this.edtClientPort.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "this is ip for your server";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(40, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "ip u want to connect to";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(795, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "port for wanted server";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1130, 692);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClientStart);
            this.Controls.Add(this.edtClientIP);
            this.Controls.Add(this.edtClientPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnServerStart);
            this.Controls.Add(this.edtServerPort);
            this.Controls.Add(this.edtServerIP);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.edtToSend);
            this.Controls.Add(this.redtHistory);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox redtHistory;
        private System.Windows.Forms.TextBox edtToSend;
        private System.Windows.Forms.Button btnSend;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.TextBox edtServerPort;
        private System.Windows.Forms.TextBox edtServerIP;
        private System.Windows.Forms.Button btnClientStart;
        private System.Windows.Forms.TextBox edtClientIP;
        private System.Windows.Forms.TextBox edtClientPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

