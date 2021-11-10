using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WPFApp.Classes
{
    class API
    {
        /// <summary>
        /// Отправляет GET запрос к API и возвращает результат
        /// </summary>
        /// <param name="participant"></param>
        /// <param name="date"></param>
        /// <returns>результат в виде JObject</returns>
        public JObject GetFines(string participant, string date)
        {
            string url = $"http://solutions2019.hakta.pro/api/getFines?participant={participant}&modified=date";
            return (JObject)JsonConvert.DeserializeObject(SendGetRequest(url));
        }

        /// <summary>
        /// <seealso cref="GetFines(string, string)"/>
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public JObject GetFines(string date)
        {
            return GetFines("05", date);
        }

        private string SendGetRequest(string url)
        {
            Stream stream = WebRequest.Create(url).GetResponse().GetResponseStream();

            StreamReader streamReader = new StreamReader(stream);
            string response = streamReader.ReadToEnd();
            streamReader.Close();

            return response;
        }
    }
}
