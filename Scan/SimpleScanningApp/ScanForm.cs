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

using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Threading;

namespace SimpleScanningApp
{
    public partial class ScanForm : Form
    {
        private string SRC;
        private Paper PaperSize;
        private int DocumentCount;

        public ScanForm(string src)
        {
            SRC = src;
            DocumentCount = 0;
            PaperSize = new Paper("A5");

            InitializeComponent();
        }

        private int ScanTime = 0;
        private bool isScan = false;

        private void Stop_MouseClick(object sender, MouseEventArgs e)
        {
            Run.Enabled = true;
            Stop.Enabled = false;

            ScanTime = 0;
            //this.Text = "Scan";

            isScan = false;
        }

        private void ThreadScan()
        {
            while (isScan)
            {
                ScanTime += 1;
                //this.Text = (Interval.Value - ScanTime).ToString();
                this.BeginInvoke(new MethodInvoker(() => this.Text = (Interval.Value - ScanTime).ToString()));

                if (ScanTime == 16)
                {
                    ScanTime = 0;
                    this.BeginInvoke(new MethodInvoker(() => this.Text = "Scaning start"));
                    Scan();
                    this.BeginInvoke(new MethodInvoker(() => this.Text = "Scaning end"));
                }

                Thread.Sleep(1000);
            }
        }

        private void Run_MouseClick(object sender, MouseEventArgs e)
        {
            Run.Enabled = false;
            Stop.Enabled = true;
            isScan = true;
            Thread thread1 = new Thread(ThreadScan);
            thread1.Start();


        }

        private void RunOne_MouseClick(object sender, MouseEventArgs e)
        {
            RunOne.Enabled = false;
            Run.Enabled = false;

            Scan();

            Run.Enabled = true;
            RunOne.Enabled = true;
        }

        private void Scan()
        {
            try
            {
                var deviceManager = new DeviceManager();

                DeviceInfo AvailableScanner = null;

                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++) // Loop Through the get List Of Devices.
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType) // Skip device If it is not a scanner
                    {
                        continue;
                    }

                    AvailableScanner = deviceManager.DeviceInfos[i];

                    break;
                }

                var device = AvailableScanner.Connect(); //Connect to the available scanner.

                var ScanerItem = device.Items[1]; // select the scanner.

                var imgFile = (ImageFile)ScanerItem.Transfer(FormatID.wiaFormatJPEG); //Retrive an image in Jpg format and store it into a variable.


                DocumentCount += 1;
                var Path = SRC + DocumentCount.ToString() + "D.jpg"; // save the image in some path with filename.

                if (File.Exists(Path))
                {
                    File.Delete(Path);
                }

                imgFile.SaveFile(Path);

                СroppingDocument(Path);

                //File.Delete(Path);


            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void СroppingDocument(string path)
        {

            var img = new Bitmap(Image.FromFile(path));


            if (PaperSize.isDefaultType){
                img.Save(SRC + DocumentCount.ToString() + ".jpg");
                pictureBox1.ImageLocation = SRC + DocumentCount.ToString() + ".jpg";
                return;
            }


            int x1 = 0;
            int x2 = PaperSize.Width;
            int y1 = 0;
            int y2 = PaperSize.Height;

            int width = x2 - x1 + 1;
            int height = y2 - y1 + 1;

            var result = new Bitmap(width, height);

            for (int i = x1; i <= x2; i++)
                for (int j = y1; j <= y2; j++)
                    result.SetPixel(i - x1, j - y1, img.GetPixel(i, j));


            result.Save(SRC + DocumentCount.ToString() + ".jpg");
            pictureBox1.ImageLocation = SRC + DocumentCount.ToString() + ".jpg";
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked) { 
                PaperSize = new Paper(radioButton.Text);
                //MessageBox.Show(PaperSize.Width.ToString());
            }
        }

        private void toPDF_MouseClick(object sender, MouseEventArgs e)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created using PDFsharp";

            for (int i = 1; i <= DocumentCount; i++)
            {
                string fileSpec = SRC + i + ".jpg";
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                DrawImage(gfx, fileSpec, 0, 0, (int)page.Width, (int)page.Height);
            }

            document.Save(SRC + "testScan.pdf");


        }

        void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
        {
            XImage image = XImage.FromFile(jpegSamplePath);
            gfx.DrawImage(image, x, y, width, height);
        }
    }
}
