using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFApp.Database;

namespace WPFApp.Activities
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Количество неправильных попыток входа.
        /// </summary>
        private int wrongAuthCount = 0;

        /// <summary>
        /// Доступ к БД.
        /// </summary>
        private gibddEntities db = new gibddEntities();


        public MainWindow()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(OnCreate);
        }

        /// <summary>
        /// Вызывается при загрузке окна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private async void OnCreate(object sender, RoutedEventArgs args)
        {
            authLogin.Text = "inspector";
            authPassword.Text = "inspector";
            int timeout = Properties.Settings.Default.timeout;
            if (timeout > 0)
            {
                wrongAuthCount = 3;
                await AttemtsTimer(timeout);
            }
        }

        /// <summary>
        /// Ждет указанное количество секунд.
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        private async Task AttemtsTimer(int timeout)
        {
            errorLabel.Text = $"Совершено {wrongAuthCount} неудачных попытки входа. Вход заблокирован на {timeout} секунд";
            authButton.IsEnabled = false;
            while (timeout > 0)
                timeout = await UpdateTimeout(timeout);
            authButton.IsEnabled = true;
            errorLabel.Text = null;
            wrongAuthCount = 0;
        }

        /// <summary>
        /// Срабатывает при клике на кнгопку входа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AuthButtonOnClick(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(authLogin.Text) || string.IsNullOrEmpty(authPassword.Text))
                return;
            else
            {
                user user = db.user.AsNoTracking().FirstOrDefault(u => u.uname == authLogin.Text && u.upass == authPassword.Text);
                if (user == null)
                {
                    errorLabel.Text = "Пользователя не существует";
                    if (wrongAuthCount < 3)
                        ++wrongAuthCount;
                    else
                        await AttemtsTimer(60);
                }
                else
                {
                    GoToTables();
                }
            }
        }

        /// <summary>
        /// Обновляет полученный таймаут
        /// </summary>
        /// <param name="timeout">таймаут</param>
        /// <returns>Обновленный таймаут</returns>
        private async Task<int> UpdateTimeout(int timeout)
        {
            await Task.Delay(1000);
            --timeout;
            errorLabel.Text = $"Совершено {wrongAuthCount} неудачных попытки входа. Вход заблокирован на {timeout} секунд";
            SaveTimeout(timeout);
            return timeout;
        }

        /// <summary>
        /// Сохраняет таймаут
        /// </summary>
        /// <param name="timeout">текущий таймаут</param>
        private void SaveTimeout(int timeout)
        {
            Properties.Settings.Default["timeout"] = timeout;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Смена окна на окно таблиц.
        /// </summary>
        private void GoToTables()
        {
            Hide();
            Tables window = new Tables();
            window.ShowDialog();
            Close();
        }
    }
}
