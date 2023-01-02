namespace TelegramSendMessage
{
    partial class FormTelegram
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
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtBotApiKey = new System.Windows.Forms.TextBox();
            this.txtBotName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameChannel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSelectImg = new System.Windows.Forms.Button();
            this.txtPathImg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPostImg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSendMessage.Location = new System.Drawing.Point(3, 93);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(440, 40);
            this.btnSendMessage.TabIndex = 0;
            this.btnSendMessage.Text = "Enviar Mensagem";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMessage.Location = new System.Drawing.Point(3, 26);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(440, 64);
            this.txtMessage.TabIndex = 1;
            // 
            // txtBotApiKey
            // 
            this.txtBotApiKey.Location = new System.Drawing.Point(108, 67);
            this.txtBotApiKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBotApiKey.Name = "txtBotApiKey";
            this.txtBotApiKey.Size = new System.Drawing.Size(321, 30);
            this.txtBotApiKey.TabIndex = 2;
            // 
            // txtBotName
            // 
            this.txtBotName.Location = new System.Drawing.Point(108, 34);
            this.txtBotName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBotName.Name = "txtBotName";
            this.txtBotName.Size = new System.Drawing.Size(321, 30);
            this.txtBotName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "BotApiKey:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "BotName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Channel:";
            // 
            // txtNameChannel
            // 
            this.txtNameChannel.Location = new System.Drawing.Point(108, 100);
            this.txtNameChannel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameChannel.Name = "txtNameChannel";
            this.txtNameChannel.Size = new System.Drawing.Size(321, 30);
            this.txtNameChannel.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNameChannel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBotApiKey);
            this.groupBox1.Controls.Add(this.txtBotName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 136);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Controls.Add(this.btnSendMessage);
            this.groupBox2.Location = new System.Drawing.Point(21, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 136);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mensagem";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSelectImg);
            this.groupBox3.Controls.Add(this.txtPathImg);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnPostImg);
            this.groupBox3.Location = new System.Drawing.Point(18, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 136);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagem";
            // 
            // btnSelectImg
            // 
            this.btnSelectImg.Location = new System.Drawing.Point(408, 41);
            this.btnSelectImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSelectImg.Name = "btnSelectImg";
            this.btnSelectImg.Size = new System.Drawing.Size(31, 26);
            this.btnSelectImg.TabIndex = 8;
            this.btnSelectImg.Text = "...";
            this.btnSelectImg.UseVisualStyleBackColor = true;
            this.btnSelectImg.Click += new System.EventHandler(this.btnSelectImg_Click);
            // 
            // txtPathImg
            // 
            this.txtPathImg.Location = new System.Drawing.Point(79, 41);
            this.txtPathImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPathImg.Name = "txtPathImg";
            this.txtPathImg.Size = new System.Drawing.Size(321, 30);
            this.txtPathImg.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Diretório:";
            // 
            // btnPostImg
            // 
            this.btnPostImg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPostImg.Location = new System.Drawing.Point(3, 93);
            this.btnPostImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPostImg.Name = "btnPostImg";
            this.btnPostImg.Size = new System.Drawing.Size(440, 40);
            this.btnPostImg.TabIndex = 0;
            this.btnPostImg.Text = "Enviar Imagem";
            this.btnPostImg.UseVisualStyleBackColor = true;
            this.btnPostImg.Click += new System.EventHandler(this.btnPostImg_Click);
            // 
            // FormTelegram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(500, 497);
            this.MinimumSize = new System.Drawing.Size(500, 497);
            this.Name = "FormTelegram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMO_Telegram";
            this.Load += new System.EventHandler(this.FormTelegram_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtBotApiKey;
        private System.Windows.Forms.TextBox txtBotName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameChannel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPostImg;
        private System.Windows.Forms.Button btnSelectImg;
        private System.Windows.Forms.TextBox txtPathImg;
        private System.Windows.Forms.Label label4;
    }
}

