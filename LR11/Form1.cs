using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR11
{
    enum ActionMode
    {
        CleanScreen,
        Searching,
        AddingNewInfo
    }

    public partial class MainForm : Form
    {
        private static List<char> mBirthAndSquareAllowSymbols = new List<char>()
        {
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.'
        };

        private static List<char> mFlatSymbols = new List<char>()
        {
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
        };

        private ActionMode mActionMode;

        public MainForm()
        {
            InitializeComponent();

            mActionMode = ActionMode.CleanScreen;
            UpdateMainFormForActionMode(mActionMode);
        }

        private void ChangeEnabledPropertyForAllControlsAtTheMainGroupBox(bool isEnabled)
        {
            fioTextBox.Enabled = isEnabled;
            birthTextBox.Enabled = isEnabled;
            streetTextBox.Enabled = isEnabled;
            houseTextBox.Enabled = isEnabled;

            maleRadioButton.Enabled = isEnabled;
            femaleRadioButton.Enabled = isEnabled;
        }

        private void CleanUpAllControls()
        {
            fioTextBox.Text = "";
            birthTextBox.Text = "";
            streetTextBox.Text = "";
            houseTextBox.Text = "";
            flatTextBox.Text = "";
            squareTextBox.Text = "";

            searchKeyComboBox.Text = "";

            maleRadioButton.Checked = true;

            searchResultListBox.Items.Clear();
        }

        private void UpdateMainFormForActionMode(ActionMode actionMode)
        {
            CleanUpAllControls();

            switch (actionMode)
            {
                case ActionMode.AddingNewInfo:
                    actionButton.Text = "Добавить";

                    mainDataGroupBox.Visible = true;
                    addDataGroupBox.Visible = true;
                    generalButtonsGroupBox.Visible = true;
                    searchDataGroupBox.Visible = false;

                    ChangeEnabledPropertyForAllControlsAtTheMainGroupBox(true);
                    break;

                case ActionMode.Searching:
                    actionButton.Text = "Искать";

                    mainDataGroupBox.Visible = true;
                    addDataGroupBox.Visible = false;
                    generalButtonsGroupBox.Visible = true;
                    searchDataGroupBox.Visible = true;
                    break;

                case ActionMode.CleanScreen:
                default:
                    mainDataGroupBox.Visible = false;
                    addDataGroupBox.Visible = false;
                    generalButtonsGroupBox.Visible = false;
                    searchDataGroupBox.Visible = false;
                    break;
            }
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            mActionMode = ActionMode.AddingNewInfo;
            UpdateMainFormForActionMode(mActionMode);
        }

        private void searchDataButton_Click(object sender, EventArgs e)
        {
            mActionMode = ActionMode.Searching;
            UpdateMainFormForActionMode(mActionMode);
            ChangeEnabledPropertyForAllControlsAtTheMainGroupBox(false);
        }

        private void birthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = mBirthAndSquareAllowSymbols.TrueForAll(allowedSymbol => (e.KeyChar != allowedSymbol));
        }

        private void squareTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = mBirthAndSquareAllowSymbols.TrueForAll(allowedSymbol => (e.KeyChar != allowedSymbol));
        }

        private void flatTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = mFlatSymbols.TrueForAll(allowedSymbol => (e.KeyChar != allowedSymbol));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            mActionMode = ActionMode.CleanScreen;
            UpdateMainFormForActionMode(mActionMode);
        }

        private void revertButton_Click(object sender, EventArgs e)
        {
            CleanUpAllControls();
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            Person person;
            switch (mActionMode)
            {
                case ActionMode.AddingNewInfo:
                    if (!fioTextBox.Text.Any() || birthTextBox.Text.Count() != 10 || !streetTextBox.Text.Any() 
                        || !houseTextBox.Text.Any() || !flatTextBox.Text.Any() || !squareTextBox.Text.Any())
                    {
                        return;
                    }

                    person = new Person(fioTextBox.Text, maleRadioButton.Checked, birthTextBox.Text, streetTextBox.Text,
                        houseTextBox.Text, Convert.ToUInt16(flatTextBox.Text), Convert.ToSingle(squareTextBox.Text));
                    Utils.SerializeObject<Person>(person, @"./db.txt");
                    CleanUpAllControls();
                    break;

                case ActionMode.Searching:
                    var searchKey = Utils.GetSearchKeyByText(searchKeyComboBox.Text);
                    var textBoxName = Utils.GetTextBoxNameBySearchKey(searchKey);
                    var arr = this.Controls.Find(textBoxName, true);
                    if (!arr.Any() || !arr.ElementAt(0).Text.Any())
                    {
                        return;
                    }

                    person = new Person(searchKey, arr.ElementAt(0).Text);
                    var personsList = Utils.SearchInTheSerializedFile<Person>(person, @"./db.txt");
                    if(!personsList.Any())
                    {
                        return;
                    }

                    personsList.ForEach(p => searchResultListBox.Items.Add(p.mFio + "; " + p.mBirth));
                    break;

                case ActionMode.CleanScreen:
                default:
                    break;
            }
        }

        private void searchKeyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(mActionMode != ActionMode.Searching || searchKeyComboBox.SelectedIndex == -1)
            {
                return;
            }

            ChangeEnabledPropertyForAllControlsAtTheMainGroupBox(false);
            var searchKey = Utils.GetSearchKeyByText(searchKeyComboBox.Text);
            var textBoxName = Utils.GetTextBoxNameBySearchKey(searchKey);
            var arr = this.Controls.Find(textBoxName, true);
            if(!arr.Any())
            {
                return;
            }

            arr.ElementAt(0).Enabled = true;
        }
    }
}
