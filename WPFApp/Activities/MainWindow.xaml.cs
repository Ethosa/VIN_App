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

        private async void OnCreate(object sender, RoutedEventArgs args)
        {
            int timeout = Properties.Settings.Default.timeout;
            if (timeout > 0)
            {
                wrongAuthCount = 3;
                await AttemtsTimer(timeout);
            }
        }

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
                    Hide();
                    Tables window = new Tables();
                    window.ShowDialog();
                    Close();
                }
            }
        }

        private async Task<int> UpdateTimeout(int timeout)
        {
            await Task.Delay(1000);
            --timeout;
            errorLabel.Text = $"Совершено {wrongAuthCount} неудачных попытки входа. Вход заблокирован на {timeout} секунд";
            SaveTimeout(timeout);
            return timeout;
        }

        private void SaveTimeout(int timeout)
        {
            Properties.Settings.Default["timeout"] = timeout;
            Properties.Settings.Default.Save();
        }
    }
}
