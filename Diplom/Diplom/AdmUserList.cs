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
    public partial class AdmUserList : Form
    {
        public AdmUserList()
        {
            InitializeComponent();
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

        private void buttonList_users_user_Click(object sender, EventArgs e)
        {
            LoadUsers();
            label1.Text = "Таблица: users_user";
        }

        private void buttonList_users_pro_Click(object sender, EventArgs e)
        {
            LoadUsersPro();
            label1.Text = "Таблица: users_pro";
        }

        private void buttonList_users_admin_Click(object sender, EventArgs e)
        {
            LoadUsersAdmin();
            label1.Text = "Таблица: users_admin";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
