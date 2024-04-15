using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            //Строка подключения
            string connectionString = "Server=DESKTOP-5C285N8;Database=users;User Id=admin;Password=1234;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Проверка пользователя в таблице users_user
                string queryUser = "SELECT COUNT(*) FROM users_user WHERE login = @login AND password = @password";
                SqlCommand commandUser = new SqlCommand(queryUser, connection);
                commandUser.Parameters.AddWithValue("@login", login);
                commandUser.Parameters.AddWithValue("@password", password);
                int countUser = (int)commandUser.ExecuteScalar();

                // Проверка пользователя в таблице users_pro
                string queryPro = "SELECT COUNT(*) FROM users_pro WHERE login = @login AND password = @password";
                SqlCommand commandPro = new SqlCommand(queryPro, connection);
                commandPro.Parameters.AddWithValue("@login", login);
                commandPro.Parameters.AddWithValue("@password", password);
                int countPro = (int)commandPro.ExecuteScalar();

                // Проверка пользователя в таблице users_admin
                string queryAdmin = "SELECT COUNT(*) FROM users_admin WHERE login = @login AND password = @password";
                SqlCommand commandAdmin = new SqlCommand(queryAdmin, connection);
                commandAdmin.Parameters.AddWithValue("@login", login);
                commandAdmin.Parameters.AddWithValue("@password", password);
                int countAdmin = (int)commandAdmin.ExecuteScalar();

                if (countUser > 0)
                {
                    MessageBox.Show("Авторизация успешна!");
                    MenuUser menu = new MenuUser();
                    menu.Show();
                    this.Hide();
                }
                if (countPro > 0)
                {
                    MessageBox.Show("Авторизация успешна!");
                    MenuPro menu = new MenuPro();
                    menu.Show();
                    this.Hide();
                }
                if (countAdmin > 0)
                {
                    MessageBox.Show("Авторизация успешна!");
                    MenuAdmin menu = new MenuAdmin();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    label4.Text = "Ошибка авторизации! Неверные логин или пароль";
                    var timer = new System.Windows.Forms.Timer();
                    timer.Interval = 1500;
                    timer.Tick += (s, eventArgs) =>
                    {
                        label4.Text = "";
                        timer.Stop();
                        timer.Dispose();
                    };
                    timer.Start();
                }
            }
        }

        private void buttonGoReg_Click(object sender, EventArgs e)
        {
            Reg goReg = new Reg();
            goReg.Show();
            this.Hide();
        }
    }
}
