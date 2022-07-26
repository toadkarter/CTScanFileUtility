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
                Config.Instance.GenerateCurrentFolderNumber(fbd.SelectedPath);
                currentFolderTextBox.Text = Convert.ToString(Config.Instance.CurrentFolder);
            }
        }

        private void CollectInfoFromFields()
        {
            Config.Instance.CurrentFolder = Int32.Parse(currentFolderTextBox.Text);
            Config.Instance.UserName= userNameTextBox.Text;
            Config.Instance.ProjectId = projectIdTextBox.Text;
            Config.Instance.SampleId = sampleIdTextBox.Text;
            Config.Instance.CurrentSample = Int32.Parse(currentSampleTextBox.Text);

            Config.Instance.ConstructFileName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Config.Instance.IsInitialised())
            {
                MessageBox.Show("Please initialise all fields before clicking this button");
                return;
            }
            CollectInfoFromFields();
            fileNameLabel.Text = Config.Instance.FileName;
            fileNameLabel.Visible = true;
            introTextLabel.Visible = true;
        }
    }
}
