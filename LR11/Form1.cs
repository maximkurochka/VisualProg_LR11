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
    public partial class MainForm : Form
    {
        private static List<char> mBirthGoodSymbols = new List<char>()
        {
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.'
        };

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
