using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace LibTelegram
{
    public class BotTelegram
    {
        private readonly HttpClient _httpClient;

        public string _botApiKey { get; private set; }

        public string _botName { get; private set; }

        public BotTelegram(string botApiKey, string botName)
        {
            _httpClient = new HttpClient();

            _botApiKey = botApiKey;
            _botName = botName;
        }


        /// <summary>
        /// Check reponse of bot.
        /// </summary>
        /// <returns>True bot OK and False bot FAIL.</returns>
        public bool CheckBot()
        {
            if(string.IsNullOrEmpty(_botApiKey))
                throw new ArgumentNullException("botApiKey", "Param null or empty");

            string url = "https://api.telegram.org/bot" + _botApiKey + "/getMe";
            var result = Get(url);
            return result.ok;
        }

        /// <summary>
        /// Send message to channel.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="chatId"></param>
        public void SendMessage(string message, string chatId)
        {
            if (string.IsNullOrEmpty(_botApiKey))
                throw new ArgumentNullException("botApiKey", "Param null or empty");

            if (string.IsNullOrEmpty(message))
                throw new ArgumentNullException("message", "Param null or empty");

            if (string.IsNullOrEmpty(chatId))
                throw new ArgumentNullException("chatId", "Param null or empty");

            if (CheckBot())
            {
                try
                {
                    string url = "https://api.telegram.org/bot" + _botApiKey + "/sendMessage?chat_id=" + chatId + "&text=" + message;

                    var result = Get(url);
                    if (result.error != null)
                    {
                        Message.ShowError("Erro (SendMessage) : " + result.error);
                        return;
                    }

                    if (result.ok)
                        Message.ShowSucess("Mensagem enviada com sucesso !");
                    else
                        Message.ShowAlert("Falha ao enviar mensagem !");

                }
                catch (Exception ex)
                {
                    Message.ShowError("Erro (SendMessage): " + ex.Message);
                }
            }
            else
            {
                Message.ShowError($"Erro (SendMessage): Bot {_botName} não encontrado!");
            }
        }

        /// <summary>
        /// Send image to telegram channel.
        /// </summary>
        /// <param name="pathImage"></param>
        /// <param name="chatId"></param>
        public void UploadImage(string pathImage, string chatId)
        {
            if (string.IsNullOrEmpty(_botApiKey))
                throw new ArgumentNullException("botApiKey", "Param null or empty");

            if (string.IsNullOrEmpty(chatId))
                throw new ArgumentNullException("chatId", "Param null or empty");

            if (string.IsNullOrEmpty(pathImage))
                throw new ArgumentNullException("pathImage", "Param null or empty");

            if (!File.Exists(pathImage))
                throw new FileNotFoundException("Image not found: "+Path.GetFileName(pathImage), Path.GetFileName(pathImage));

            string sUrl = "https://api.telegram.org/bot" + _botApiKey + "/sendPhoto";

            try
            {
                byte[] bImage = File.ReadAllBytes(pathImage);
                using (MultipartFormDataContent form = new MultipartFormDataContent())
                {
                    form.Add(new StringContent(chatId), "chat_id");
                    form.Add(new ByteArrayContent(bImage, 0, bImage.Length), "photo", Path.GetFileName(pathImage));

                    var response = _httpClient.PostAsync(sUrl, form).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var result = response.Content.ReadAsStringAsync().Result;
                        TelegramResult Result = JsonConvert.DeserializeObject<TelegramResult>(result);
                        if (Result.ok)
                            Message.ShowSucess("Imagem enviada com sucesso !");
                        else
                            Message.ShowAlert("Falha ao enviar imagem !");

                    }
                }
            }
            catch (Exception ex)
            {
                Message.ShowError("Erro (UploadImage): " + ex.Message);
            }
        }

        /// <summary>
        /// Get request to telegram url.
        /// </summary>
        /// <param name="url"></param>
        /// <returns>If "TelegramModel.error" != null, the request fail.</returns>
        private TelegramResult Get(string url)
        {
            TelegramResult Result = new TelegramResult();
            try
            {
                Uri Uri = new Uri(url);
                var response = _httpClient.GetAsync(Uri.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content;
                    string sRet = content.ReadAsStringAsync().Result;
                    Result = JsonConvert.DeserializeObject<TelegramResult>(sRet);
                }
                else
                    Result.error = response.StatusCode.ToString();
            }
            catch (Exception ex)
            {
                Result.error = "Erro (Get): " + ex.Message;
            }

            return Result;
        }
    }

    public static class Message
    {
        public static void ShowSucess(string message) 
        {
             MessageBox.Show(message, ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowAlert(string message)
        {
            MessageBox.Show(message, ":l", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
