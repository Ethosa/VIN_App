using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsApp.Modules
{
    class API
    {
        /// <summary>
        /// Возвращает штрафы за эту дату.
        /// </summary>
        /// <param name="participant"></param>
        /// <param name="date"></param>
        /// <returns>результат в виде JObject</returns>
        public static JObject GetFines(string participant, string date)
        {
            string url = $"http://solutions2019.hakta.pro/api/getFines?participant={participant}&modified=date";
            return (JObject)JsonConvert.DeserializeObject(SendGetRequest(url));
        }

        /// <summary>
        /// Делает то же, что и <seealso cref="GetFines(string, string)"/>
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static JObject GetFines(string date)
        {
            return GetFines("05", date);
        }

        /// <summary>
        /// Отправляет сообщение о том, что регистрационный номер не опознан.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static JObject PostFine(string id, string message)
        {
            string url = $"http://solutions2019.hakta.pro/api/postFine?id={id}&message={message}";
            return (JObject)JsonConvert.DeserializeObject(SendPostRequest(url));
        }

        /// <summary>
        /// Делает то же, что и <seealso cref="PostFine(string, string)"/>
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static JObject PostFine(string id)
        {
            return PostFine(id, "Unable to recognize regmark.");
        }


        private static string SendGetRequest(string url)
        {
            Stream stream = WebRequest.Create(url).GetResponse().GetResponseStream();

            StreamReader streamReader = new StreamReader(stream);
            string response = streamReader.ReadToEnd();
            streamReader.Close();

            return response;
        }

        private static string SendPostRequest(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.Timeout = 5000;
            Stream stream = request.GetResponse().GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string response = streamReader.ReadToEnd();
            streamReader.Close();

            return response;
        }
    }
}
