using SST.DesktopUI.Code;
using SST.Entities;
using SST.Repositories.Classes;
using SST.Repositories.Intefaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SST.DesktopUI.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository _userRepository;

        public bool IsEntered { get; set; }

        public LoginForm()
        {
            _userRepository = new SqlUserRepository(ConfigurationManager.ConnectionStrings["SSTDb"].ConnectionString);
            IsEntered = false;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //InsertUsers();
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            User user = _userRepository.GetUserByLogin(login, Encryptor.MD5Hash(password));

            if (user == null)
            {
                MessageBox.Show(this, "Invalid user name or password", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtLogin.Focus();
                txtLogin.SelectAll();
            }
            else
            {
                CurrentUser.Initialize(user);
                IsEntered = true;
                this.Close();
            }
        }

        private void InsertUsers()
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SSTDb"].ConnectionString))
            {
                connection.Open();
                string q = @"INSERT INTO tblUser(FirstName, LastName, Login, Password, Disabled) VALUES (@fn, @ln, @l, @p, 0);";
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = q;
                    command.Parameters.AddWithValue("@fn", "Taras");
                    command.Parameters.AddWithValue("@ln", "Tarasenko");
                    command.Parameters.AddWithValue("@l", "tarasenko");
                    command.Parameters.AddWithValue("@p", Encryptor.MD5Hash("tarasenko"));
                    command.ExecuteNonQuery();
                }
                
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = q;

                    command.Parameters.AddWithValue("@fn", "Stepan");
                    command.Parameters.AddWithValue("@ln", "Stepanenko");
                    command.Parameters.AddWithValue("@l", "stepanenko");
                    command.Parameters.AddWithValue("@p", Encryptor.MD5Hash("stepanenko"));
                    command.ExecuteNonQuery();
                }
                    

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = q;

                    command.Parameters.AddWithValue("@fn", "Iryna");
                    command.Parameters.AddWithValue("@ln", "Kolisnychenko");
                    command.Parameters.AddWithValue("@l", "kolisnychenko");
                    command.Parameters.AddWithValue("@p", Encryptor.MD5Hash("kolisnychenko"));
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
