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
            string botApiKey = string.Empty;
            try
            {
                botApiKey = (string)ConfigurationManager.AppSettings["BotApiKey"];
                txtBotApiKey.Text = botApiKey;
            }
            catch { }

            string botName = string.Empty;
            try
            {
                botName = (string)ConfigurationManager.AppSettings["BotName"];
                txtBotName.Text = botName;
            }
            catch { }

            bot = new BotTelegram(botApiKey, botName);
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
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
