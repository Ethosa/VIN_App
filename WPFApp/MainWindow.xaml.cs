using System;
using System.IO;
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

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Количество неправильных попыток входа.
        /// </summary>
        private int wrongAuthCount = 0;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        /// <summary>
        /// Событие, срабатывающее при загрузке окна.
        /// <para>Подгружает таймаут.</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public async void MainWindow_Loaded(object sender, RoutedEventArgs args)
        {
            int timeout = Properties.Settings.Default.timeout;
            if (timeout > 0)
                wrongAuthCount = 3;
            await AttemptsTimer(timeout);
        }

        /// <summary>
        /// Событие, срабатывающее при нажатии на кнопку входа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ButtonOnClick(object sender, RoutedEventArgs e)
        {
            errorLabel.Text = null;
            if (string.IsNullOrEmpty(authLogin.Text) || string.IsNullOrEmpty(authPassword.Text))
                errorLabel.Text = "Заполните Логин и Пароль!";
            else
            {
                if (wrongAuthCount < 3)
                    ++wrongAuthCount;
                else
                    await AttemptsTimer(60);
            }
        }

        /// <summary>
        /// Блокировка входа на определенное время.
        /// </summary>
        /// <param name="sec">Timeout seconds<see cref="int"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        private async Task AttemptsTimer(int timeout)
        {
            errorLabel.Text = $"Совершено {wrongAuthCount} неудачных попытки входа. Вход заблокирован на {timeout} секунд";
            authButton.IsEnabled = false;
            while (timeout > 0)
                timeout = await UpdateTimeout(timeout);
            errorLabel.Text = null;
            authButton.IsEnabled = true;
            wrongAuthCount = 0;
        }

        private async Task<int> UpdateTimeout(int timeout)
        {
            errorLabel.Text = $"Совершено {wrongAuthCount} неудачных попытки входа. Вход заблокирован на {timeout} секунд";
            --timeout;
            SaveTimeout(timeout);
            await Task.Delay(1000);
            return timeout;
        }

        private void SaveTimeout(int timeout)
        {
            Properties.Settings.Default["timeout"] = timeout;
            Properties.Settings.Default.Save();
        }
    }
}
