namespace WindowsApp
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using WindowsApp.Database;
    using WindowsApp.Modules;
    using System.Configuration;


    /// <summary>
    /// Defines the <see cref="Auth" />.
    /// </summary>
    public partial class Auth : Form
    {
        /// <summary>
        /// Defines the wrongAuthCount.
        /// </summary>
        internal int wrongAuthCount;

        /// <summary>
        /// Defines the of.
        /// </summary>
        internal OpenForms of = new OpenForms();
        internal gibddEntities db = new gibddEntities();
        internal Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        /// <summary>
        /// Initializes a new instance of the <see cref="Auth"/> class.
        /// </summary>
        public Auth()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызывается при клике на кнопку.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void authButton_Click(object sender, EventArgs e)
        {
            warnLabel.Text = null;
            if (string.IsNullOrEmpty(loginText.Text) || string.IsNullOrEmpty(passText.Text))
                warnLabel.Text = "Проверьте заполненность полей";
            else
            {
                user user = db.user.AsNoTracking().FirstOrDefault(u => u.uname == loginText.Text && u.upass == passText.Text);
                // Если не нашелся
                if (user == null)
                {
                    if (wrongAuthCount == 3)
                        await AttemptsTimer(60);
                    else
                        wrongAuthCount++;
                    warnLabel.Text = "Пользователя не существует";
                }
                else
                {
                    of.MainForm();
                    Hide();
                }
            }
        }

        /// <summary>
        /// Блокировка входа на определенное время.
        /// </summary>
        /// <param name="sec">Timeout seconds<see cref="int"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        private async Task AttemptsTimer(int sec)
        {
            warnLabel.Text = $"Совершено {wrongAuthCount} неудачных попытки входа. Вход заблокирован на {sec} секунд";
            authButton.Enabled = false;
            while (sec > 0)
                sec = await UpdateTimeout(sec);
            warnLabel.Text = null;
            authButton.Enabled = true;
            wrongAuthCount = 0;
        }

        /// <summary>
        /// Обновляет и сохраняет таймаут в конфиге.
        /// </summary>
        /// <param name="sec"></param>
        /// <returns></returns>
        private async Task<int> UpdateTimeout(int sec)
        {
            warnLabel.Text = $"Совершено {wrongAuthCount} неудачных попытки входа. Вход заблокирован на {sec} секунд";
            --sec;
            SaveTimeout(sec);
            await Task.Delay(1000);
            return sec;
        }

        /// <summary>
        /// Подгружает сохраненный таймаут из конфига.
        /// </summary>
        /// <returns>таймаут</returns>
        private async Task LoadTimeout()
        {
            int timeout = Convert.ToInt32(config.AppSettings.Settings["timeout"].Value);
            await AttemptsTimer(timeout);
        }

        /// <summary>
        /// Сохраняет таймаут в конфиг.
        /// </summary>
        /// <param name="sec">таймаут</param>
        private void SaveTimeout(int sec)
        {
            config.AppSettings.Settings["timeout"].Value = sec.ToString();
            config.Save();
        }

        /// <summary>
        /// The Auth_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private async void Auth_Load(object sender, EventArgs e)
        {
            await LoadTimeout();
        }

        private void showPassBtn_MouseHover(object sender, EventArgs e)
        {
            passText.PasswordChar='\0';
        }

        private void showPassBtn_MouseLeave(object sender, EventArgs e)
        {
            passText.PasswordChar = '*';
        }
    }
}
