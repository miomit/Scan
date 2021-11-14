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

namespace Scan
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void NewFileButton_MouseClick(object sender, MouseEventArgs e)
        {
            ScanForm scanForm = new ScanForm();
            this.Hide();
            scanForm.ShowDialog();
            this.Show();
        }
    }
}
