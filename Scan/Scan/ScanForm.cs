using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scan
{
    public partial class ScanForm : Form
    {
        public ScanForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.Items.Add((listBox1.Items.Count).ToString());
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }
    }
}
