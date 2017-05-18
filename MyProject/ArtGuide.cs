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
    public partial class ArtGuide : Form
    {
        public ArtGuide()
        {
            InitializeComponent();
        }

        private void ArtGuide_Load(object sender, EventArgs e)
        {
            GatherInfo();
        }
        
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuSearch_DropDownOpened(object sender, EventArgs e)
        {
            MenuSearch.ForeColor = Color.Black;
        }

        private void MenuFile_DropDownOpened(object sender, EventArgs e)
        {
            MenuFile.ForeColor = Color.Black;
        }

        private void MenuFile_DropDownClosed(object sender, EventArgs e)
        {
            MenuFile.ForeColor = Color.White;
        }

        private void MenuSearch_DropDownClosed(object sender, EventArgs e)
        {
            MenuSearch.ForeColor = Color.White;
        }

        private void MenuFileClear_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
        }

        private void MenuMyCollection_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            ShowMyCollection();
        }

        private void MenuSearchPictureFind_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            FindPicture();
        }

        private void ArtGuide_Shown(object sender, EventArgs e)
        {

        }


        private void workWithMyCollection_Click(object sender, EventArgs e)
        {
            ProcessButtonWorkWithMyCollection();
        }

        private void MenuSearchArtistFind_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            FindArtist();
        }

        private void MenuSearchPictureViewAll_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            ViewAllPictures();
        }

        private void MenuSearchArtistViewAll_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            ViewAllArtists();
        }

    }
}
