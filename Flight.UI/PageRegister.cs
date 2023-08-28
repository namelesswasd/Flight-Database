using Flight.DataAccess.BaseClasses;
using Flight.DataAccess.Repositories;
using Flight.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.UI
{
    public partial class PageRegister : UserControl, State
    {
        UserRepository userRepository = new UserRepository();

        public PageRegister()
        {
            InitializeComponent();
            textBox_password.PasswordChar = '*';
            comboBox_type.Items.AddRange(Enum.GetNames(typeof(UserEnum)).ToArray());

            if (File.Exists(Globals.PATH_USER_REPO))
            {
                userRepository.LoadFromJson(Globals.PATH_USER_REPO);
            }
        }

        public UserControl Content
        {
            get { return this; }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            if(textBox_username.Text.Length == 0 || 
               textBox_password.Text.Length == 0 ||
               comboBox_type.Text.Length == 0)
            {
                FormHost.MessageBoxGenerator("Please fill in all of the fields", "Warning");
                return;
            }

            var _temp = userRepository.GetLast();

            int _id;
            if (_temp == null) _id = 0;
            else _id = userRepository.GetLast().ID + 1;

            userRepository.Create(new User(
                _id,
                textBox_username.Text,
                textBox_password.Text,
                (UserEnum)Enum.Parse(typeof(UserEnum), comboBox_type.Text)
            ));

            FormHost.MessageBoxGenerator("Account created!", "Information");

            userRepository.SaveToJson(Globals.PATH_USER_REPO);
        }

        public bool PageValid
        {
            get { return true; }
        }

        public string ValidationMessage
        {
            get { return ""; }
        }
    }
}
