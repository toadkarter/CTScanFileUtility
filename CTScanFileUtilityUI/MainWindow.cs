﻿using System;
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
                try
                {
                    Config.Instance.GenerateCurrentFolderNumber(fbd.SelectedPath);
                    currentFolderTextBox.Text = Convert.ToString(Config.Instance.CurrentFolder);
                }
                catch (Exception)
                {
                    MessageBox.Show("Some of the subdirectcories are not in the correct format");
                }
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
            if (!FieldsAreCompleted())
            {
                MessageBox.Show("Please initialise all fields before clicking this button");
                return;
            }
            try
            {
                CollectInfoFromFields();
                fileNameLabel.Text = Config.Instance.FileName;
                fileNameLabel.Visible = true;
                introTextLabel.Visible = true;
                startButton.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, some of the fields are not in the correct format.");
            }

        }

        private bool FieldsAreCompleted()
        {
            return currentFolderTextBox.Text != "" &&
                userNameTextBox.Text != "" && 
                projectIdTextBox.Text != "" &&
                sampleIdTextBox.Text != "" &&
                currentFolderTextBox.Text != "";
        }

        private void GenerateNewSampleAction()
        {
            Directory.CreateDirectory($"{Config.Instance.DirectoryPath}\\{Config.Instance.CurrentFolder}");
            Clipboard.SetText(Config.Instance.FileName);
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            ActionWindow actionWindow = new ActionWindow();
            actionWindow.Show();
            GenerateNewSampleAction();
        }
    }
}
