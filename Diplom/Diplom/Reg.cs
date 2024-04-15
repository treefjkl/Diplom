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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void buttonGoAuth_Click(object sender, EventArgs e)
        {
            Auth goAuth = new Auth();
            goAuth.Show();
            this.Hide();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            string newLogin = textBoxLogin.Text;
            string newPassword = textBoxPassword.Text;
            string newName = textBoxName.Text;
            string newLastName = textBoxLastName.Text;
            string newMidName = textBoxMidName.Text;
            string newDepartment = textBoxDepartment.Text;
            string newPosition = textBoxPosition.Text;

            string connectionString = "Server=DESKTOP-5C285N8;Database=users;User Id=admin;Password=1234;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Проверка, существует ли пользователь с таким логином
                string checkUserQuery = "SELECT COUNT(*) FROM users_user WHERE login = @login";
                SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection);
                checkUserCommand.Parameters.AddWithValue("@login", newLogin);
                int existingUsers = (int)checkUserCommand.ExecuteScalar();

                if (existingUsers > 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textBoxLogin.Text) ||
                        string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                        string.IsNullOrWhiteSpace(textBoxName.Text) ||
                        string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                        string.IsNullOrWhiteSpace(textBoxMidName.Text) ||
                        string.IsNullOrWhiteSpace(textBoxDepartment.Text) ||
                        string.IsNullOrWhiteSpace(textBoxPosition.Text))
                    {
                        labelWarning.Text = "Ошибка регистрации! Пожалуйста, заполните все поля";
                        var timer = new System.Windows.Forms.Timer();
                        timer.Interval = 2500;
                        timer.Tick += (s, eventArgs) =>
                        {
                            labelWarning.Text = "";
                            timer.Stop();
                            timer.Dispose();
                        };
                        timer.Start();
                    }
                    else
                    {
                        // Добавление нового пользователя в таблицу users_user
                        string insertQuery = "INSERT users_user VALUES (@login, @password, 'user', @name, @lastName, @midName, @department, @position)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@login", newLogin);
                        insertCommand.Parameters.AddWithValue("@password", newPassword);
                        insertCommand.Parameters.AddWithValue("@name", newName);
                        insertCommand.Parameters.AddWithValue("@lastName", newLastName);
                        insertCommand.Parameters.AddWithValue("@midName", newMidName);
                        insertCommand.Parameters.AddWithValue("@department", newDepartment);
                        insertCommand.Parameters.AddWithValue("@position", newPosition);
                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Пользователь успешно зарегистрирован");
                        textBoxLogin.Clear();
                        textBoxPassword.Clear();
                        textBoxName.Clear();
                        textBoxLastName.Clear();
                        textBoxMidName.Clear();
                        textBoxDepartment.Clear();
                        textBoxPosition.Clear();
                    }
                }
            }
        }
    }
}
