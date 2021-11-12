namespace WindowsApp.Forms
{
    using Newtonsoft.Json.Linq;
    using System;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Text.RegularExpressions;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gibddDataSet._Drivers_Cars". При необходимости она может быть перемещена или удалена.
            this.drivers_CarsTableAdapter.Fill(this.gibddDataSet._Drivers_Cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gibddDataSet._Drivers_Lics". При необходимости она может быть перемещена или удалена.
            this.drivers_LicsTableAdapter.Fill(this.gibddDataSet._Drivers_Lics);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gibddDataSet.licences". При необходимости она может быть перемещена или удалена.
            this.licencesTableAdapter.Fill(this.gibddDataSet.licences);
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
            driversBindingNavigatorSaveItem.PerformClick();
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
        private void TryToGetClick(object sender, EventArgs e)
        {
            JArray data = (JArray)API.GetFines(partBox.Text, modifedDate.Value.ToString())["data"];
            ExportFines(data);
            response.Text = data.ToString();
            FinesSummary.DataSource = data;
            FinesSummary.Columns[0].Name = "Номер";
            FinesSummary.Columns[1].Name = "Гос.номер";
            FinesSummary.Columns[2].Name = "Вод. удостоверение";
            FinesSummary.Columns[3].Name = "Дата";
            FinesSummary.Columns[4].Name = "Фото";
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

        /// <summary>
        /// Экспорт штрафов в CSV файлы.
        /// </summary>
        /// <param name="data"></param>
        private void ExportFines(JArray data)
        {
            if (!Directory.Exists("fines"))
                Directory.CreateDirectory("fines");
            foreach (JObject fine in data)
            {
                fines fineInfo = db.fines.SqlQuery($"SELECT * FROM fines WHERE[id] = {fine["id"]}").AsNoTracking().SingleAsync().Result;
                string firstname = fineInfo.firstname.ToUpper();
                string lastname = fineInfo.lastname.ToUpper();
                string status = fineInfo.status;
                string carNum = fine["car_num"].ToString();

                if (string.IsNullOrEmpty(status) || !status.Equals("Передан в ФССП"))
                {
                    db.fines.SqlQuery($"UPDATE fines SET status = N'Передан в ФССП' WHERE id = {fine["id"]}").AsNoTracking().FirstOrDefaultAsync();
                    db.SaveChanges();
                    string path = "fines/fines_" + lastname + "_" + firstname + ".csv";
                    
                    if (!File.Exists(path))
                    {
                        using (FileStream fs = File.Create(path))
                        {
                            byte[] s = new UTF8Encoding(true).GetBytes(
                                $"id;create_date;car_num;license_num;\n{fine["id"]};{fine["create_date"]};{fine["car_num"]};{fine["license_num"]}");
                            fs.Write(s, 0, s.Length);
                        }
                    }
                    else
                    {
                        using (FileStream fs = File.Open(path, FileMode.Append))
                        {
                            byte[] s = new UTF8Encoding(true).GetBytes($"\n{fine["id"]};{fine["create_date"]};{fine["car_num"]};{fine["license_num"]}");
                            fs.Write(s, 0, s.Length);
                            fs.Close();
                        }
                    }
                }
            }
        }

        private void DriverLicenseSaveItem(object sender, EventArgs e)
        {
            // TODO: Допилить сохранение ВУ -_-
            Validate();
            drivers_LicsBindingSource.EndEdit();
            licencesBindingSource.AddNew();
            // drivers_LicsTableAdapter.Update(gibddDataSet._Drivers_Lics);
        }

        private void DriverCarsSaveItem(object sender, EventArgs e)
        {
            // TODO: Допилить сохранение автомобилей -_-
            Validate();
            drivers_CarsBindingSource.EndEdit();
        }
    }
}
