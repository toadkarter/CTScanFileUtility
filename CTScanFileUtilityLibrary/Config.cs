using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CTScanFileUtilityLibrary
{
    public class Config
    {
        private static Config instance = null;
        private static readonly object padlock = new object();

        private Config() { }

        public static Config Instance
        {
            get
            {
                lock(padlock)
                {
                    if (instance == null)
                    {
                        instance = new Config();
                    }
                    return instance;
                }
            }
        }

        public string DirectoryPath { get; set; } = null;
        public int CurrentFolder { get; set; } = -1;
        public string UserName { get; set; } = null;
        public string ProjectId { get; set; } = null;
        public string SampleId { get; set; } = null;
        public int CurrentSample { get; set; } = -1;
        public string FileName { get; set; } = null;

        public void IncrementToNextSample()
        {
            IncrementCurrentFolder();
            IncrementCurrentSample();
            ConstructFileName();
        }

        public void GenerateCurrentFolderNumber(string directoryPath)
        {
            DirectoryPath = directoryPath;
            string[] subDirectories = Directory.GetDirectories(DirectoryPath);

            int maxFolder = -1;

            foreach (string subDirectory in subDirectories)
            {
                try
                {
                    int currentFolder = Int32.Parse(Path.GetFileName(subDirectory));
                    if (currentFolder > maxFolder)
                    {
                        maxFolder = currentFolder;
                    }

                }
                catch (Exception)
                {

                    throw;
                }

            }
            CurrentFolder = maxFolder + 1;
        }

        private void ConstructFileName()
        {
            FileName = $"{CurrentFolder}_{UserName}_{ProjectId}_{SampleId}{CurrentSample}";
        }

        private void SetFileNameToClipboard()
        {
            
        }

        private void IncrementCurrentFolder()
        {
            CurrentFolder += 1;
        }

        private void IncrementCurrentSample()
        {
            CurrentSample += 1;
        }
        
        public bool IsInitialised()
        {
            return DirectoryPath != null && 
                CurrentFolder != -1 &&
                UserName != null &&
                ProjectId != null &&
                SampleId != null &&
                CurrentSample != -1;
        }

    }
}
