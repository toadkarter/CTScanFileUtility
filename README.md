# CT Scan File Utility
A Windows utility to generate folders and file names for CT Scanning in UCD.

### How do I run this utility?
---

Clone the repository and run the executable at `CTScanFileUtility/CTScanFileUtilityUI/bin/Debug/CTScanFileUtilityUI.exe`.

### What does this utility do?
---

This utility assists with creation of folders and generation of file names in the appropriate format. 

Once the configuration is complete, upon the user's request the application will:
* Create a new folder with the appropriate number;
* Generate a filename for the new scan, making changes as appropriate;
* Copy the filename to the clipboard, so that the user can paste it where required; and
* Generate an entry to be handwritten into the hard copy log book. 

### How do I set up this utility?
---

First, select the directory where all the scans are currently being saved.

This utility will check all the subdirectories and will attempt to guess what the next folder name should be.

Next, the details of the filename format should be included in the relevant fields.

Filenames in the UCD scanning facility are set up in the following format:

`1077_User_1059_SZC21`

where:

* 1077 is the name of the folder in which the scan is located;
* User is the username;
* 1059 is the Project ID;
* SZC is the general Sample ID; and
* 21 is the Sample No. in a given batch. 

The Current Folder and the Sample No. will be incremeneted with each subsequent scan. 

After pressing "Check File Name", the user will have an opportunity to see what the file name will look like. After pressing "Begin", the user will be able to increment the file names and directory names accordingly. 

**END**

