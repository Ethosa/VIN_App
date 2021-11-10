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

namespace WPFApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int wrongAuthCount = 0;
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
                return;
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
