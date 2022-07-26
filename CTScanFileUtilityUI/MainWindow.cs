using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CTScanFileUtilityLibrary;

namespace CTScanFileUtilityUI
{
    public partial class MainWindow : Form
    {
        private readonly Config _config = Config.Instance;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //Clipboard.SetText(fbd.SelectedPath);
                
                currentFolderTextBox.Text = 
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            currentFolderTextBox
        }
    }
}
