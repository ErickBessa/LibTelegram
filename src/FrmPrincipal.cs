using LibTelegram;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace TelegramSendMessage
{
    public partial class FormTelegram : Form
    {
        BotTelegram bot;
        OpenFileDialog openFile;

        public FormTelegram()
        {
            InitializeComponent();
            openFile = new OpenFileDialog();
        }

        private void FormTelegram_Load(object sender, EventArgs e)
        {
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {   
                if (bot == null)
                    bot = new BotTelegram(txtBotApiKey.Text, txtBotName.Text);

                bot.SendMessage(txtMessage.Text, txtNameChannel.Text);
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPostImg_Click(object sender, EventArgs e)
        {
            try
            {
                bot.UploadImage(txtPathImg.Text, txtNameChannel.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            txtPathImg.Text = openFile.FileName;
        }
    }
}
