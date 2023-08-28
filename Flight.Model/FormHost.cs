using Flight.DataAccess.BaseClasses;
using System.Runtime.CompilerServices;

namespace Flight.Model
{
    public partial class FormHost : Form
    {
        private const string UNVALID_MSG = "Warning.";

        public StateCollection States { get; set; }

        public static void MessageBoxGenerator(string msg, string type)
        {
            if (type == "Warning") MessageBox.Show(string.Concat(msg, Environment.NewLine), UNVALID_MSG, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (type == "Information") MessageBox.Show(string.Concat(msg, Environment.NewLine), UNVALID_MSG, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show(string.Concat(msg, Environment.NewLine), UNVALID_MSG, MessageBoxButtons.OK);
        }

        public FormHost()
        {
            InitializeComponent();
            States = new StateCollection();

            comboBox_main.Items.AddRange(Enum.GetNames(typeof(FormLocation)).ToArray());



        }

        public bool PageIsValid()
        {
            if (!States.CurrentPage.PageValid)
            {
                MessageBoxGenerator("This page does not exist yet.", "Warning");
                return false;
            }
            return true;
        }

        public void Setup()
        {
            States.MoveToPage(0);
        }

        public void LoadPageIndex(int page_index)
        {
            if (page_index >= 0)
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(States[page_index].Content);
            }
        }

        private void comboBox_main_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_proceed_Click(object sender, EventArgs e)
        {
            if (!PageIsValid())
            {
                return;
            }
            if (comboBox_main.Text.Length > 0)
            {
                var u = new User().LoadUserFromDisk("../../../../" + "LoggedUser.txt");

                if(comboBox_main.SelectedIndex >= 2 && u == null)
                {
                    MessageBoxGenerator("Please log in or make an account to proceed.", "Warning");
                    return;
                } else if ((comboBox_main.SelectedIndex >= 2 && comboBox_main.SelectedIndex <= 4) &&
                    u.UserEnum.Equals(UserEnum.Client))
                {
                    MessageBoxGenerator("This page is only accesible to administrators", "Warning");
                    return;
                }
                else
                {
                    if (States.MoveToPage(comboBox_main.SelectedIndex) == null)
                    {
                        MessageBoxGenerator("This page does not exist yet.", "Warning");
                        return;
                    }

                    LoadPageIndex(comboBox_main.SelectedIndex);
                }
            }
        }
    }
}