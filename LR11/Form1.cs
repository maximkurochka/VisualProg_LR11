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
    enum UpdateMainFormMode
    {
        HideAll,
        OpenAddData,
        OpenSearchData
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

        public MainForm()
        {
            InitializeComponent();

            UpdateMainForm(UpdateMainFormMode.HideAll);
        }

        private void CleanUpAllControls()
        {
            fioTextBox.Text = "";
            birthTextBox.Text = "";
            streetTextBox.Text = "";
            houseTextBox.Text = "";
            flatTextBox.Text = "";
            squareTextBox.Text = "";

            maleRadioButton.Checked = true;

            searchResultListBox.Items.Clear();
        }

        private void UpdateMainForm(UpdateMainFormMode updateMode)
        {
            CleanUpAllControls();

            switch (updateMode)
            {
                case UpdateMainFormMode.OpenAddData:
                    actionButton.Text = "Добавить";

                    mainDataGroupBox.Visible = true;
                    addDataGroupBox.Visible = true;
                    generalButtonsGroupBox.Visible = true;
                    searchResultListBox.Visible = true; 
                    break;

                case UpdateMainFormMode.OpenSearchData:
                    actionButton.Text = "Искать";

                    mainDataGroupBox.Visible = true;
                    addDataGroupBox.Visible = false;
                    generalButtonsGroupBox.Visible = true;
                    searchResultListBox.Visible = true;
                    break;

                case UpdateMainFormMode.HideAll:
                default:
                    mainDataGroupBox.Visible = false;
                    addDataGroupBox.Visible = false;
                    generalButtonsGroupBox.Visible = false;
                    searchResultListBox.Visible = false;
                    break;
            }
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            UpdateMainForm(UpdateMainFormMode.OpenAddData);
        }

        private void searchDataButton_Click(object sender, EventArgs e)
        {
            UpdateMainForm(UpdateMainFormMode.OpenSearchData);
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
            UpdateMainForm(UpdateMainFormMode.HideAll);
        }

        private void revertButton_Click(object sender, EventArgs e)
        {
            CleanUpAllControls();
        }
    }
}
