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
    }
}
