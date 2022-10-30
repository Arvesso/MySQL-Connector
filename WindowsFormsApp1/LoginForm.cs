using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQLconnector
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            panel1.Select();

            loginField.Text = "Логин";
            loginField.ForeColor = Color.Gray;
            passwordField.Text = "Пароль";
            passwordField.ForeColor = Color.Gray;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string loginUser = loginField.Text;
            string passwordUser = passwordField.Text;

            var dataBase = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();

            if (dataBase.GetConnection() == null)
            {
                MessageBox.Show("Нет соединения с базой данных", "Connection error");
                return;
            }

            var command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", dataBase.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Успешное подключение", "Autorization");
                var mainForm = new MainForm();
                mainForm.Show();
                Hide();
            }
            else
                MessageBox.Show("Неверные данные входа", "Autorization");
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Пароль")
            {
                passwordField.Text = "";
                passwordField.UseSystemPasswordChar = true;
                passwordField.ForeColor = Color.Black;
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")
            {
                passwordField.Text = "Пароль";
                passwordField.UseSystemPasswordChar = false;
                passwordField.ForeColor = Color.Gray;
            }
        }

        private void loginField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
                e.SuppressKeyPress = true;
        }

        private void passwordField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
                e.SuppressKeyPress = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            buttonLogin.Focus();
        }

        private void gotoRegister_MouseEnter(object sender, EventArgs e)
        {
            gotoRegister.ForeColor = Color.Gray;
        }

        private void gotoRegister_MouseLeave(object sender, EventArgs e)
        {
            gotoRegister.ForeColor = Color.White;
        }

        private void gotoRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}
