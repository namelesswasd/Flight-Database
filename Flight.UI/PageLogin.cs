using Flight.DataAccess.BaseClasses;
using Flight.DataAccess.Repositories;
using Flight.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.UI
{
    public partial class PageLogin : UserControl, State
    {
        UserRepository userRepository = new UserRepository();
        private IEnumerable<User> users;

        public PageLogin()
        {
            InitializeComponent();
            textBox_password.PasswordChar = '*';
        }

        private void PageLogin_Load(object sender, EventArgs e)
        {
            if (File.Exists(Globals.PATH_USER_REPO))
            {
                userRepository.LoadFromJson(Globals.PATH_USER_REPO);
            }
            else { FormHost.MessageBoxGenerator("No users found, make an account in the Registration tab!", "Information"); }
            if(File.Exists(Globals.PATH_LOGGED_USER))
            {
                var u = new User().LoadUserFromDisk(Globals.PATH_LOGGED_USER); 
                label_logged.Text = "Logged in as: " +
                    u.Username + " (" + u.UserEnum.ToString() + " account)";
            }
        }

        public UserControl Content
        {
            get { return this; }
        }

        public bool PageValid
        {
            get { return true; }
        }

        public string ValidationMessage
        {
            get { return ""; }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (File.Exists(Globals.PATH_USER_REPO))
            {
                userRepository.LoadFromJson(Globals.PATH_USER_REPO);
            }

            if (textBox_username.Text.Length == 0 ||
               textBox_password.Text.Length == 0)
            {
                FormHost.MessageBoxGenerator("Please fill in all of the fields", "Warning");
                return;
            }

            users = userRepository.GetAll();

            foreach (User u in users)
            {
                if (u.Username == textBox_username.Text &&
                   u.Password == textBox_password.Text)
                {
                    FormHost.MessageBoxGenerator("Login Succesful!", "Information");

                    label_logged.Text = "Logged in as: " +
                        u.Username + " (" + u.UserEnum.ToString() + " account)";

                    u.SaveUserToDisk(Globals.PATH_LOGGED_USER, u);

                    return;
                }
            }

            FormHost.MessageBoxGenerator("Login Incorrect", "Warning");
            return;
        }

    }
}
