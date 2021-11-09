namespace WindowsApp.Forms
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using WindowsApp.Database;

    /// <summary>
    /// Defines the <see cref="MainForm" />.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Экземпляр базы данных..
        /// </summary>
        internal gibddEntities db = new gibddEntities();

        /// <summary>
        /// Правило для проверки E-mail, к примеру:
        /// <c>something.email@domain.com</c>.
        /// </summary>
        private readonly Regex emailRule = new Regex(
            @"^.+?@(.+\..+)+$", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        /// <summary>
        /// Правило для проверки номера телефона по следующим шаблонам:
        /// <list type="bullet">
        ///     <item>8-800-555-35-35</item>
        ///     <item>8 800 555 35 35</item>
        ///     <item>88005553535</item>
        /// </list>
        /// </summary>
        private readonly Regex phoneRule = new Regex(
            @"^\d[\s\-]{0,1}\d{3}[\s\-]{0,1}\d{3}[\s\-]{0,1}\d{2}[\s\-]{0,1}\d{2}$",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);

        /// <summary>
        /// Правило для проверки почтового индекса..
        /// </summary>
        private readonly Regex indexRule = new Regex(
            @"^\d{1,6}$", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызывается при открытии формы.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gibddDataSet.drivers". При необходимости она может быть перемещена или удалена.
            driversTableAdapter.Fill(gibddDataSet.drivers);
        }

        /// <summary>
        /// The DriversBindingNavigatorSaveItemClick.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void DriversBindingNavigatorSaveItemClick(object sender, EventArgs e)
        {
            Validate();
            driversBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(gibddDataSet);
        }

        /// <summary>
        /// Отображает информацию по предыдущему водителю.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void BackClick(object sender, EventArgs e)
        {
            bindingNavigatorMovePreviousItem.PerformClick();
        }

        /// <summary>
        /// Удаляет выбранного водителя.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void DeleteDataClick(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }

        /// <summary>
        /// Создает нового водителя.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void NewDataClick(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

        /// <summary>
        /// Отображает информацию по следующему водителю.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void NextClick(object sender, EventArgs e)
        {
            bindingNavigatorMoveNextItem.PerformClick();
        }

        /// <summary>
        /// Сохраняет текущего водителя.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private void SaveDataClick(object sender, EventArgs e)
        {
            if (!emailRule.Match(emailTextBox.Text).Success)
                MessageBox.Show("E-mail is wrong!");
            else if (!phoneRule.Match(phoneTextBox.Text).Success)
                MessageBox.Show("Phone number is wrong!");
            else if (!indexRule.Match(postcodeTextBox.Text).Success)
                MessageBox.Show("Postcode is wrong!");
            else
                driversBindingNavigatorSaveItem.PerformClick();
        }

        /// <summary>
        /// Возвращает штрафы за дату
        /// </summary>
        /// <param name="participant"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public JObject GetFines(string participant, string date)
        {
            string url = $"http://solutions2019.hakta.pro/api/getFines?participant={participant}&modified=date";
            return (JObject)JsonConvert.DeserializeObject(SendGetRequest(url));
        }

        /// <summary>
        /// Отправляет сообщение о том, что регистрационный номер не опознан.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public JObject PostFine(string id, string message)
        {
            string url = $"http://solutions2019.hakta.pro/api/postFine?id={id}&message={message}";
            return (JObject)JsonConvert.DeserializeObject(SendPostRequest(url));
        }

        /// <summary>
        /// Срабатывает при нажатии на кнопку "GET".
        /// Отправляет GET запросы и стягивает картинки.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private async void TryToGetClick(object sender, EventArgs e)
        {
            JArray data = (JArray)GetFines(partBox.Text, modifedDate.Value.ToString())["data"];
            response.Text = data.ToString();
            for (int i = 0; i < data.Count; i++)
            {
                try
                {
                    carPic.Image = Image.FromStream(
                        new MemoryStream(new WebClient().DownloadData(data[i]["photo"].ToString())));
                }
                catch
                {
                    continue;
                }
                finally
                {
                    await Task.Delay(2000);
                }
            }
        }

        /// <summary>
        /// Отправляет GET запрос.
        /// </summary>
        /// <param name="url">URL, куда следует отправить запрос.</param>
        /// <returns>Ответ.</returns>
        public string SendGetRequest(string url)
        {
            Stream stream = WebRequest.Create(url).GetResponse().GetResponseStream();

            StreamReader streamReader = new StreamReader(stream);
            string response = streamReader.ReadToEnd();
            streamReader.Close();

            return response;
        }

        public string SendPostRequest(string url)
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

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
