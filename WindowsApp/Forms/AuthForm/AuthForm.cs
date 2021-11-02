namespace WindowsApp
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using WindowsApp.Database;
    using WindowsApp.Modules;


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

        /// <summary>
        /// Initializes a new instance of the <see cref="Auth"/> class.
        /// </summary>
        public Auth()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The authButton_Click.
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
                var user = db.user.AsNoTracking().FirstOrDefault(u => u.uname == loginText.Text && u.upass == passText.Text);
                //Если не нашелся
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
                    this.Hide();
                }
            }
        }

        /// <summary>
        /// The AttemptsTimer.
        /// </summary>
        /// <param name="sec">Timeout seconds<see cref="int"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        private async Task AttemptsTimer(int sec)
        {
            warnLabel.Text = $"Совершено {wrongAuthCount} неудачных попытки входа. Вход заблокирован на {sec} секунд";
            authButton.Enabled = false;
            while (sec > 0)
            {
                sec = await UpdateTimeout(sec);
            }
            warnLabel.Text = null;
            authButton.Enabled = true;
            wrongAuthCount = 0;
        }

        private async Task<int> UpdateTimeout(int sec)
        {
            warnLabel.Text = $"Совершено {wrongAuthCount} неудачных попытки входа. Вход заблокирован на {sec} секунд";
            --sec;
            SaveTimeout(sec);
            await Task.Delay(1000);
            return sec;
        }

        private async Task LoadTimeout()
        {
            int timeout = (int) Properties.Settings.Default["sec"];
            await AttemptsTimer(timeout);
        }

        private void SaveTimeout(int sec)
        {
            Properties.Settings.Default["sec"] = sec;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// The Auth_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void Auth_Load(object sender, EventArgs e)
        {
            LoadTimeout().Wait();
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
