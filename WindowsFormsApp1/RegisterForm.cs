using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQLconnector
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            panel1.Select();

            userNameField.Text = "Ваше имя";
            userNameField.ForeColor = Color.Gray;
            userLastNameField.Text = "Ваша фамилия";
            userLastNameField.ForeColor = Color.Gray;
            loginField.Text = "Логин";
            loginField.ForeColor = Color.Gray;
            passwordField.UseSystemPasswordChar = false;
            passwordField.Text = "Пароль";
            passwordField.ForeColor = Color.Gray;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Ваше имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }             
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Ваше имя";
                userNameField.ForeColor = Color.Gray;
            }             
        }

        private void userLastNameField_Enter(object sender, EventArgs e)
        {
            if (userLastNameField.Text == "Ваша фамилия")
            {
                userLastNameField.Text = "";
                userLastNameField.ForeColor = Color.Black;
            }
        }

        private void userLastNameField_Leave(object sender, EventArgs e)
        {
            if (userLastNameField.Text == "")
            {
                userLastNameField.Text = "Ваша фамилия";
                userLastNameField.ForeColor = Color.Gray;
            }
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
                passwordField.UseSystemPasswordChar = false;
                passwordField.Text = "Пароль";
                passwordField.ForeColor = Color.Gray;
            }
        }

        private void userNameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
                e.SuppressKeyPress = true;
        }

        private void userLastNameField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
                e.SuppressKeyPress = true;
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
            buttonRegister.Focus();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if(loginField.Text == "Логин" || loginField.Text.Length <= 3)
            {
                MessageBox.Show("Введите минимум 4 символа в поле логин", "Registration");
                return;
            }
            if (passwordField.Text == "Пароль" || passwordField.Text.Length <= 5)
            {
                MessageBox.Show($"Пароль должен содержать минимум 6 символов", "Registration");
                return;
            }
            if (userNameField.Text == "Ваше имя" || userNameField.Text.Length <= 3)
            {
                MessageBox.Show("Некорректное имя (минимум 4 символа)", "Registration");
                return;
            }
            if (userLastNameField.Text == "Ваша фамилия" || userLastNameField.Text.Length <= 3)
            {
                MessageBox.Show("Некорректная фамилия (минимум 4 символа)", "Registration");
                return;
            }

            var dataBase = new DataBase();

            if (dataBase.GetConnection() == null)
            {
                MessageBox.Show("Нет соединения с базой данных", "Connection error");
                return;
            } 
            if (checkUser())
            {
                MessageBox.Show("Пользователь с таким логином уже зарегестрирован", "Registration");
                return;
            }

            var command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `lastName`) VALUES (@login, @pass, @name, @lastname)", dataBase.GetConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passwordField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = userLastNameField.Text;

            dataBase.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Успешная регистрация", "Registration");
            else
                MessageBox.Show("Ошибка регистрации", "Registration");

            dataBase.CloseConnection();
        }

        public bool checkUser()
        {
            var dataBase = new DataBase();
            var table = new DataTable();
            var adapter = new MySqlDataAdapter();

            var command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", dataBase.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
                return true;
            else
                return false;
        }
    }
}
