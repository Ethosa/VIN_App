using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFApp.Database;
using WPFApp.Database.gibddDataSetTableAdapters;
using WPFApp.Classes;

namespace WPFApp.Activities
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Tables : Window
    {
        /// <summary>
        /// Доступ к БД.
        /// </summary>
        private gibddEntities db = new gibddEntities();

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


        public Tables()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызывается при загрузке окна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCreate(object sender, RoutedEventArgs args)
        {
            gibddDataSet gibddDataSet = ((gibddDataSet)(FindResource("gibddDataSet")));
            // Загрузить данные в таблицу drivers. Можно изменить этот код как требуется.
            driversTableAdapter gibddDataSetdriversTableAdapter = new driversTableAdapter();
            gibddDataSetdriversTableAdapter.Fill(gibddDataSet.drivers);
            CollectionViewSource driversViewSource = ((CollectionViewSource)(FindResource("driversViewSource")));
            driversViewSource.View.MoveCurrentToFirst();
        }

        /// <summary>
        /// Переходит к следующей ячейке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButtonOnClick(object sender, RoutedEventArgs e)
        {
            if (driversDataGrid.SelectedIndex < driversDataGrid.Items.Count)
                driversDataGrid.SelectedIndex++;
        }

        /// <summary>
        /// Переходит к предыдущей ячейке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrevButtonOnClick(object sender, RoutedEventArgs e)
        {
            if (driversDataGrid.SelectedIndex > 0)
                driversDataGrid.SelectedIndex--;
        }

        private void NewButtonOnClick(object sender, RoutedEventArgs e)
        {
            gibddDataSet dataSet = ((gibddDataSet)(FindResource("gibddDataSet")));
            dataSet.drivers.AdddriversRow("", "", "", 0, 0, 0, "", "", "", "", "", "", "");
            CollectionViewSource driversViewSource = ((CollectionViewSource)(FindResource("driversViewSource")));
            driversViewSource.View.MoveCurrentToFirst();
        }

        private void SaveButtonOnClick(object sender, RoutedEventArgs e)
        {
            gibddDataSet dataSet = ((gibddDataSet)(FindResource("gibddDataSet")));
            dataSet.drivers.AcceptChanges();
            CollectionViewSource driversViewSource = ((CollectionViewSource)(FindResource("driversViewSource")));
            driversViewSource.View.MoveCurrentToFirst();
        }

        private void DeleteButtonOnClick(object sender, RoutedEventArgs e)
        {
            gibddDataSet dataSet = ((gibddDataSet)(FindResource("gibddDataSet")));
            dataSet.drivers.RemovedriversRow(dataSet.drivers[driversDataGrid.SelectedIndex]);
            CollectionViewSource driversViewSource = ((CollectionViewSource)(FindResource("driversViewSource")));
            driversViewSource.View.MoveCurrentToFirst();
        }

        private void DriversDataGridOnAddingNewItem(object sender, AddingNewItemEventArgs e)
        {

        }
    }
}
