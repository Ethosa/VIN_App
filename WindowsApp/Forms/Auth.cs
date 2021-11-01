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
            var user = db.user.AsNoTracking().FirstOrDefault(u => u.uname == loginText.Text && u.upass == passText.Text);
            //Если не нашелся

            if (user == null)
            {
                if (wrongAuthCount == 3)
                    await AttemptsTimer(60);
                else
                    wrongAuthCount++;
                warnLabel.Text = "Пользователя не существует";
            } else
            {
                of.MainForm();
                this.Hide();
            }
           
        }

        /// <summary>
        /// The AttemptsTimer.
        /// </summary>
        /// <param name="sec">Timeout seconds<see cref="int"/>.</param>
        /// <returns>The <see cref="Task"/>.</returns>
        public async Task AttemptsTimer(int sec)
        {
            warnLabel.Text = $"Совершено {wrongAuthCount} неудачных попытки входа. Вход заблокирован на {sec} секунд";
            authButton.Enabled = false;
            db.Database.ExecuteSqlCommand($"UPDATE blockLoginTime SET time={sec}");
            await Task.Delay(sec * 1000);
            warnLabel.Text = null;
            authButton.Enabled = true;
            db.Database.ExecuteSqlCommand($"UPDATE blockLoginTime SET time=0");
            wrongAuthCount = 0;
        }

        /// <summary>
        /// The Auth_Load.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void Auth_Load(object sender, EventArgs e)
        {
        }
    }
}
