using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyProject
{
    struct Picture
    {
        public string Name;
        public string Artist;
        public int Year; 
        public string Style;
        public string Path;

        public Picture(Picture p)
        {
            Name = p.Name;
            Artist = p.Artist;
            Year = p.Year;
            Style = p.Style;
            Path = p.Path;
        }
    }
}
