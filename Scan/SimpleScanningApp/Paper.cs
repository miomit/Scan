using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleScanningApp
{
    internal class Paper
    {
        public bool isDefaultType {  get; set; }
        public int Width {  get; set; }
        public int Height { get; set; }

        public Paper(string typePaper = "A4")
        {
            isDefaultType = false;
            switch (typePaper)
            {
                case "A5":
                    Width = 1160;
                    Height = 1645;
                    break;

                default:
                    Width = 1700;
                    Height = 2338;
                    isDefaultType = true;
                    break;
            }
        }
    }
}
