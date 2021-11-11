namespace WindowsApp.Forms
{
    using Newtonsoft.Json.Linq;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using WindowsApp.Database;
    using WindowsApp.Modules;

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
        /// Срабатывает при нажатии на кнопку "GET".
        /// Отправляет GET запросы и стягивает картинки.
        /// </summary>
        /// <param name="sender">.</param>
        /// <param name="e">.</param>
        private async void TryToGetClick(object sender, EventArgs e)
        {
            JArray data = (JArray)API.GetFines(partBox.Text, modifedDate.Value.ToString())["data"];
            response.Text = data.ToString();
            for (int i = 0; i < data.Count; i++)
            {
                FinesSummary.DataSource = data;
                FinesSummary.Columns[0].Name = "Номер";
                FinesSummary.Columns[1].Name = "Гос.номер";
                FinesSummary.Columns[2].Name = "Вод. удостоверение";
                FinesSummary.Columns[3].Name = "Дата";
                FinesSummary.Columns[4].Name = "Фото";
            }
        }

        private void FinesSummary_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string link = FinesSummary.CurrentCell.Value.ToString();
            Console.WriteLine(link);
            try
            {
                CarFinePic.Image = Image.FromStream(
                    new MemoryStream(new WebClient().DownloadData(link)));
            }
            catch
            {
            }
        }
    }
}
