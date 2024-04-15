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
    public partial class AdmDeleteUser : Form
    {
        public AdmDeleteUser()
        {
            InitializeComponent();
            buttonDeleteUser_users.Hide();
            buttonDeleteUser_pro.Hide();
            buttonDeleteUser_admin.Hide();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void LoadUsers()
        {
            // Подключение к базе данных и выполнение запроса на выборку всех пользователей
            string connectionString = "Server=DESKTOP-5C285N8;Database=users;User Id=admin;Password=1234;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM users_user;"; // Запрос на выборку всех пользователей из таблицы "users_user"
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Отображение данных в DataGridView
                dataGridViewUsers.DataSource = dt;
            }
        }
        private void LoadUsersPro()
        {
            string connectionString = "Server=DESKTOP-5C285N8;Database=users;User Id=admin;Password=1234;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM users_pro;"; // Запрос на выборку всех пользователей из таблицы "users_pro"
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Отображение данных в DataGridView
                dataGridViewUsers.DataSource = dt;
            }
        }
        private void LoadUsersAdmin()
        {
            string connectionString = "Server=DESKTOP-5C285N8;Database=users;User Id=admin;Password=1234;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM users_admin;"; // Запрос на выборку всех пользователей из таблицы "users_admin"
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Отображение данных в DataGridView
                dataGridViewUsers.DataSource = dt;
            }
        }
        public void DeleteUserById_users(int userId)
        {
            string connectionString = "Server=DESKTOP-5C285N8;Database=users;User Id=admin;Password=1234;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM users_user WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", userId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteUserById_pro(int userId)
        {
            string connectionString = "Server=DESKTOP-5C285N8;Database=users;User Id=admin;Password=1234;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryPro = "DELETE FROM users_pro WHERE id = @id";

                using (SqlCommand command = new SqlCommand(queryPro, connection))
                {
                    command.Parameters.AddWithValue("@id", userId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteUserById_admin(int userId)
        {
            string connectionString = "Server=DESKTOP-5C285N8;Database=users;User Id=admin;Password=1234;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryAdmin = "DELETE FROM users_admin WHERE id = @id";

                using (SqlCommand command = new SqlCommand(queryAdmin, connection))
                {
                    command.Parameters.AddWithValue("@id", userId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private void buttonList_users_user_Click(object sender, EventArgs e)
        {
            LoadUsers();
            label1.Text = "Таблица: users_user";
            buttonDeleteUser_users.Show();
            buttonDeleteUser_pro.Hide();
            buttonDeleteUser_admin.Hide();
        }

        private void buttonList_users_pro_Click(object sender, EventArgs e)
        {
            LoadUsersPro();
            label1.Text = "Таблица: users_pro";
            buttonDeleteUser_pro.Show();
            buttonDeleteUser_admin.Hide();
            buttonDeleteUser_users.Hide();
        }

        private void buttonList_users_admin_Click(object sender, EventArgs e)
        {
            LoadUsersAdmin();
            label1.Text = "Таблица: users_admin";
            buttonDeleteUser_admin.Show();
            buttonDeleteUser_users.Hide();
            buttonDeleteUser_pro.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonDeleteUser_users_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["id"].Value);
                DeleteUserById_users(userId);
                dataGridViewUsers.Refresh();
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Выберите пользователя для удаления");
            }
        }

        private void buttonDeleteUser_pro_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["id"].Value);
                DeleteUserById_pro(userId);
                dataGridViewUsers.Refresh();
                LoadUsersPro();
            }
            else
            {
                MessageBox.Show("Выберите пользователя для удаления");
            }
        }

        private void buttonDeleteUser_admin_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["id"].Value);
                DeleteUserById_admin(userId);
                dataGridViewUsers.Refresh();
                LoadUsersAdmin();
            }
            else
            {
                MessageBox.Show("Выберите пользователя для удаления");
            }
        }
    }
}
