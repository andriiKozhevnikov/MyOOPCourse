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
    struct Artist
    {
        public string Name;
        public string YearsOfLife;
        public string Style;
        public string Nation;
        public string Photo;

        public Artist(Artist a)
        {
            Name = a.Name;
            YearsOfLife = a.YearsOfLife;
            Style = a.Style;
            Nation = a.Nation;
            Photo = a.Photo;
        }
    }
}
