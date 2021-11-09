using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using WindowsApp.Database;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        internal gibddEntities db = new gibddEntities();
        private readonly Regex emailRule = new Regex(
            @"^.+?@(.+\..+)+$", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private readonly Regex phoneRule = new Regex(
            @"^\d[\s\-]{0,1}\d{3}[\s\-]{0,1}\d{3}[\s\-]{0,1}\d{2}[\s\-]{0,1}\d{2}$",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);
        private readonly Regex indexRule = new Regex(
            @"^\d{1,6}$", RegexOptions.IgnoreCase | RegexOptions.Compiled);


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gibddDataSet.drivers". При необходимости она может быть перемещена или удалена.
            driversTableAdapter.Fill(gibddDataSet.drivers);
      }

        private void DriversBindingNavigatorSaveItemClick(object sender, EventArgs e)
        {
            Validate();
            driversBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(gibddDataSet);
        }

        private void NextClick(object sender, EventArgs e)
        {
            bindingNavigatorMoveNextItem.PerformClick();
        }

        private void BackClick(object sender, EventArgs e)
        {
            bindingNavigatorMovePreviousItem.PerformClick();
        }

        private void NewDataClick(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.PerformClick();
        }

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

        private void DeleteDataClick(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }

        /// <summary>
        /// Срабатывает при нажатии на кнопку "GET". Отправляет GET запросы и стягивает картинки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void TryToGetClick(object sender, EventArgs e)
        {
            string url = $"http://solutions2019.hakta.pro/api/getFines?participant={partBox.Text}&modified={modifedDate.Value.ToString()}";
            getUrl.Text = url;
            JObject stuff = (JObject)JsonConvert.DeserializeObject(SendGetRequest(url));
            response.Text = stuff["data"].ToString();
            for (int i = 0; i < ((JArray)stuff["data"]).Count; i++)
            {
                try
                {
                    carPic.Image = Image.FromStream(
                        new MemoryStream(new WebClient().DownloadData(stuff["data"][i]["photo"].ToString())));
                } catch
                {
                    continue;
                } finally
                {
                    await Task.Delay(2000);
                }               
            }
        }

        /// <summary>
        /// Отправляет GET запрос.
        /// </summary>
        /// <param name="url">URL, куда следует отправить запрос.</param>
        /// <returns>Ответ</returns>
        public string SendGetRequest(string url)
        {
            Stream stream = WebRequest.Create(url).GetResponse().GetResponseStream();

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
