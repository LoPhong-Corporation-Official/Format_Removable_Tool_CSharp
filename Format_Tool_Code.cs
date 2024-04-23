// Format removable tool
// Copy this code to any thing you need.
// The code is need an input is a removable
// It also need "System.Diagnostics"
 string usbName = comboBox1.SelectedItem.ToString // Replace comboBox1 to any comboBox
 string driveLetter = usbName.Substring(0, 2);
  Process process = new Process();
   process.StartInfo.FileName = "cmd.exe";
   process.StartInfo.Arguments = "/c format " + driveLetter + " /FS:NTFS /Q"; // Replace NTFS to any format you need like FAT32
   process.StartInfo.CreateNoWindow = true;
   process.Start();
   process.WaitForExit();
//Here is an example
using System;
using System.Diagnostics;
namespace Example1
{
    public partial class Form : Form1
    {
        public Form()
        {
            InitializeComponent();
        }
        private void bt_Format(object sender, EventArgs e)
        {
            string usbName = comboBox1.SelectedItem.ToString(); // Select USB from comboBox1
            string driveLetter = usbName.Substring(0, 2); // Get letter of USB
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c format " + driveLetter + " /FS:NTFS /Q"; // Format USB
            process.StartInfo.CreateNoWindow = true; // Create a new windows CMD
            process.Start();
            process.WaitForExit();
        }
    }
}