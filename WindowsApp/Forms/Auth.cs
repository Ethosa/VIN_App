﻿using System;
using System.Windows.Forms;
using WindowsApp.Modules;

namespace WindowsApp
{
    public partial class Auth : Form
    {
        OpenForms of = new OpenForms();
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void authButton_Click(object sender, EventArgs e)
        {
           
        }

        private void authButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginText.Text) || string.IsNullOrEmpty(passText.Text))
                warnLabel.Text = "Проверьте заполненность полей";
            /*using (var db = new dbEntities()) //Инициализация базы
            {
                //Ищем пользователя в базе по заданным критериям
                var user = db.user.AsNoTracking().FirstOrDefault(u => u.uname == loginText.Text && u.upass == passText.Text);
                //Если не нашелся
                if (user == null)
                warnLabel.Text = "Пользователя не существует";
                return;
                of.MainForm();
            }*/
        }
    }
}
