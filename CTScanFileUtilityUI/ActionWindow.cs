using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTScanFileUtilityLibrary;
using System.IO;

namespace CTScanFileUtilityUI
{
    public partial class ActionWindow : Form
    {
        private readonly Config _config = Config.Instance;

        public ActionWindow()
        {
            InitializeComponent();
            actionFileLabel.Text = Config.Instance.FileName;
            SetLogbookEntryLabel();
        }

        private void SetLogbookEntryLabel()
        {
            logbookEntryLabel.Text = $"{Config.Instance.CurrentFolder} | {Config.Instance.ProjectId}_{Config.Instance.CurrentSample}";
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nextSampleButton_Click(object sender, EventArgs e)
        {
            Config.Instance.IncrementToNextSample();
            Clipboard.SetText(Config.Instance.FileName);
            actionFileLabel.Text = Config.Instance.FileName;
            SetLogbookEntryLabel();
            Directory.CreateDirectory($"{Config.Instance.DirectoryPath}\\{Config.Instance.CurrentFolder}");
        }
    }
}
