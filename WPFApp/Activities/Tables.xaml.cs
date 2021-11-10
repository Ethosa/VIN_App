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
            Loaded += new RoutedEventHandler(OnCreate);
        }

        private async void OnCreate(object sender, RoutedEventArgs args)
        {
            
        }
    }
}
