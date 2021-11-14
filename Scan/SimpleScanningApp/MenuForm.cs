using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WIA;
using System.Runtime.InteropServices;
using System.IO;

namespace SimpleScanningApp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void NewFileButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(folderBrowserDialog1.SelectedPath);
                ScanForm scanForm = new ScanForm(folderBrowserDialog1.SelectedPath + @"\");
                //ScanForm scanForm = new ScanForm(@"D:\testScan\");
                this.Hide();
                scanForm.ShowDialog();
                this.Show();
            }
            
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            try
            {
                var deviceManager = new DeviceManager();

                for(int i=1; i <= deviceManager.DeviceInfos.Count; i++) // Loop Through the get List Of Devices.
                {
                    if(deviceManager.DeviceInfos[i].Type!=WiaDeviceType.ScannerDeviceType) // Skip device If it is not a scanner
                    {
                        continue;
                    }
                    lstListOfScanner.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value());
                }
                if (lstListOfScanner.Items.Count == 0)
                {
                    MessageBox.Show("Where scan!!!)");
                    this.Close();
                }

            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
